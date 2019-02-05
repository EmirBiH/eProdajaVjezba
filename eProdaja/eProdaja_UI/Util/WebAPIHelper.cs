﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja_UI.Util
{
    class WebAPIHelper
    {
        public HttpClient client { get; set; }
        public string route { get; set; }

        public WebAPIHelper(string uri, string route)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            this.route = route;
        }

        public HttpResponseMessage GetResponse()
        {
            return client.GetAsync(route).Result;
        }

        //api/Korisnici/{username}
        public HttpResponseMessage GetResponse(string parametar)
        {
            return client.GetAsync(route + "/" + parametar).Result;
        }

        public HttpResponseMessage PostResponse(object obj)
        {
            return client.PostAsJsonAsync(route, obj).Result;
        }
    }
}