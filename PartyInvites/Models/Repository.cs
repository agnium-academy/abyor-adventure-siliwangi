using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
    public class Repository
    {
        private static Dictionary<string, GuestResponse> responses;
        static Repository()
        {
            responses = new Dictionary<string, GuestResponse>();
            responses.Add("Uccu", new GuestResponse
            {
                Nama = "Uccu",
                Alamat = "Serang",
                Umur = "27"
            });
            responses.Add("Trio", new GuestResponse
            {
                Nama = "Trio",
                Alamat = "Bogor Utara",
                Umur = "22"
            });
           
        }
        public static void Add(GuestResponse newResponse)
        {
            string key = newResponse.Nama.ToLowerInvariant();
            if (responses.ContainsKey(key))
            {
                responses[key] = newResponse;
            }
            else {
                responses.Add(key, newResponse);
            }
        }
        public static IEnumerable<GuestResponse> Responses
        {
            get { return responses.Values; }
        }
    }
}