using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Security.Cryptography;
using System.Web;
using System.Text;
using System.Globalization;
using System.Net.Http;

namespace aspnetcoreapp.Pages
{
    public class IndexModel : PageModel
    {
        private static int count = 0;
        public bool test = false;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        // public void OnGet(string Firma, string Geschl, string Vorname, string Nachname, string Strasse,
        // string PLZ, string Ort, string Land, string Homepage, string Email)
        // {
        //     if (count != 0)
        //     {
        //         FormObject _formObject = new FormObject
        //         {
        //             Firma = Firma,
        //             Geschl = Geschl,
        //             Vorname = Vorname,
        //             Nachname = Nachname,
        //             Strasse = Strasse,
        //             PLZ = PLZ,
        //             Ort = Ort,
        //             Land = Land,
        //             Homepage = Homepage,
        //             Email = Email
        //         };

        //         string json = JsonSerializer.Serialize(_formObject);

        //         ViewData["Result"] = json;

        //         Console.WriteLine(json);

        //         test = true;

        //         SendToBlob(json);
        //     }
        //     count++;
        // }

        // public void SendToBlob(string jsonData)
        // {
        //     string fileName = JsonSerializer.Deserialize<FormObject>(jsonData).Email;
        //     string url = "https://saewebsitedatatorage.blob.core.windows.net/regdataappservice" + fileName + "?sp=r&st=2021-03-07T18:17:11Z&se=2022-04-01T01:17:11Z&spr=https&sv=2020-02-10&sr=c&sig=GWoOxRMG3Zm7kUgPhi5Ohh1WGHCxTfBIB2xPi%2B3Wq7k%3D";

        //     HttpClient client = new HttpClient();

        //     var content = new StringContent(jsonData);

        //     var response = client.PostAsync(url, content);

        // }

        // private static string createToken(string resourceUri, string keyName, string key)
        // {
        //     TimeSpan sinceEpoch = DateTime.UtcNow - new DateTime(1970, 1, 1);
        //     var week = 60 * 60 * 24 * 7;
        //     var expiry = Convert.ToString((int)sinceEpoch.TotalSeconds + week);
        //     string stringToSign = HttpUtility.UrlEncode(resourceUri) + "\n" + expiry;
        //     HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(key));
        //     var signature = Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(stringToSign)));
        //     var sasToken = String.Format(CultureInfo.InvariantCulture, "SharedAccessSignature sr={0}&sig={1}&se={2}&skn={3}", HttpUtility.UrlEncode(resourceUri), HttpUtility.UrlEncode(signature), expiry, keyName);
        //     return sasToken;
        // }
    }

    public class FormObject
    {
        public string Firma { get; set; }
        public string Geschl { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Strasse { get; set; }
        public string PLZ { get; set; }
        public string Ort { get; set; }
        public string Land { get; set; }
        public string Homepage { get; set; }
        public string Email { get; set; }
    }
}
