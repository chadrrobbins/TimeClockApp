using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoogleTimeClock
{
    class Functions
    {
        public void OpenFileStream(out UserCredential credential, string[] Scopes)
        {            
            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/calendar-dotnet-quickstart");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, Scopes, "user", CancellationToken.None, new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }
        }

        public DateTime CreateDateTime(string when)
        {
            string date;
            string time;
            string ampm;
            string chunk;

            if (when.Length != 0)
            {
                date = when.Substring(0, when.IndexOf(" ")).Trim();
                chunk = when.Substring(when.IndexOf(" ") + 1).Trim();
                time = chunk.Substring(0, chunk.IndexOf(" ")).Trim();
                ampm = chunk.Substring(chunk.IndexOf(" ") + 1).Trim();

                string[] dat = date.Split('/');

                string[] tim = time.Split(':');

                int d = Convert.ToInt32(dat[1]);
                int mon = Convert.ToInt32(dat[0]);
                int y = Convert.ToInt32(dat[2]);
                int h = Convert.ToInt32(tim[0]);
                int min = Convert.ToInt32(tim[1]);
                int s = Convert.ToInt32(tim[2]);

                if (ampm.Equals("PM") && h != 12)
                {
                    h += 12;
                }

                return new DateTime(y, mon, d, h, min, s);
            }

            return new DateTime(1, 1, 1, 0, 0, 0);
        }

        public string GetContractorName(string eventInfo)
        {
            string contractorName;

            contractorName = eventInfo.Substring(0, eventInfo.IndexOf(':')).Trim();

            return contractorName;
        }

        public string GetJobTitle(string eventInfo)
        {
            string jobTitle;
            string chunk;

            chunk = eventInfo.Substring(eventInfo.IndexOf(' ') + 1).Trim();
            jobTitle = chunk.Substring(0, chunk.IndexOf(' ')).Trim();

            return jobTitle;
        }   
    }
}
