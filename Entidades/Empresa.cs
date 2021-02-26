using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Prova_Suficiencia.Interfaces;

namespace Prova_Suficiencia.Entidades
{
    /// <summary>
    /// ANDRÉ MARCOS HINCKEL
    /// </summary>
    public class Empresa
    {
        public List<IViagem> Viagens { get; set; } = new List<IViagem>();

        public List<IPassageiro> GetPassageirosMaisVelho()
        {
            return Viagens.SelectMany(x => x.Passageiros)
                .OrderByDescending(x => x.Idade)
                .ThenBy(x => x.Nome).ToList();
        }

        public void AddViagem(IViagem viagem)
        {
            Viagens.Add(viagem);
        }

        public List<IViagem> ReadJsonFile()
        {
            var json = File.ReadAllText("./Resources/ListaViagens.json");
            if (string.IsNullOrEmpty(json) || json.Trim() == "{}")
            {
                return new List<IViagem>();
            }

            try
            {
                return new List<IViagem> {JsonConvert.DeserializeObject<Viagem>(json, new SerializationConverter())};
            }
            catch (JsonSerializationException e)
            {
                return new List<IViagem>();
            }
        }
    }
    
    public class SerializationConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            JToken t = JToken.FromObject(value);

            if (t.Type != JTokenType.Object)
            {
                t.WriteTo(writer);
            }
            else
            {
                JObject o = (JObject)t;
                IList<string> propertyNames = o.Properties().Select(p => p.Name).ToList();

                o.AddFirst(new JProperty("Keys", new JArray(propertyNames)));

                o.WriteTo(writer);
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            object test = serializer.Deserialize<List<Passageiro>>(reader);

            if (test == null)
            {
                test = serializer.Deserialize<List<Idoso>>(reader);
            }

            if (test == null)
            {
                test = serializer.Deserialize<List<Estudante>>(reader);
            }
            
            return test;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IPassageiro);
        }
    }
}