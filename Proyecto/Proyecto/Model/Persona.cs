using System;

using Newtonsoft.Json;

namespace Proyecto.Model
{
    public class Persona
    {
        [JsonProperty(PropertyName = "name")]
        public string Nombre { get; set; }
    }
}

