﻿using Newtonsoft.Json;
using pix_dynamic_payload_generator.net.Extentions;
using System;
using System.Collections.Generic;
using System.Text;

namespace pix_dynamic_payload_generator.net.Responses
{
    public class PixDevolutionRequestResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("rtrId")]
        public string RtrId { get; set; }

        [JsonProperty("valor")]
        public string Valor { get; set; }

        [JsonProperty("horario")]
        public Horario Horario { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class Horario
    {
        [JsonProperty("solicitacao")]
        public DateTime Solicitacao { get; set; }

        [JsonIgnore]
        public string Display => Solicitacao.ToDisplay();
    }
}
