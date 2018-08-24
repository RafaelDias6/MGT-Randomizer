using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MGT_Randomizer
{
    class Updater
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/drive-dotnet-quickstart.json
        static string[] Scopes = { DriveService.Scope.DriveFile };
        static string ApplicationName = "Drive API .NET Quickstart";
        static string NomeArquivo = "Blacklist.txt";
        static string CaminhoArquivo = string.Format("{0}{1}{2}", Form1.Caminho , @"\" ,"Blacklist.txt");

        public static Google.Apis.Drive.v3.DriveService Credencial()
        {
            ServiceAccountCredential credential;

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            { 
                credential = GoogleCredential.FromStream(stream)
                                     .CreateScoped(Scopes)
                                     .UnderlyingCredential as ServiceAccountCredential;
            }

            return new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

        }

        public static void Upload(DriveService servico)
        {
            var arquivo = new Google.Apis.Drive.v3.Data.File
            {
                Name = System.IO.Path.GetFileName(CaminhoArquivo)
            };

            FilesResource.UpdateMediaUpload request;

            var id = PegarIdArquivo(servico);

            if (id != "") { 
                using (var stream = new System.IO.FileStream(CaminhoArquivo, System.IO.FileMode.Open))
                {
                    request = servico.Files.Update(arquivo, id, stream, "text/plain");
                    request.Upload();
                }
            }

        }

        public static void Download(DriveService servico)
        {
            var id = PegarIdArquivo(servico);

            if (id != "")
            {
                var requisiscao = servico.Files.Get(id);

                using (var stream = new System.IO.FileStream(CaminhoArquivo, System.IO.FileMode.Create, System.IO.FileAccess.Write))
                    requisiscao.Download(stream);
            }
        }

        private static string PegarIdArquivo(DriveService servico)
        {
            var busca = servico.Files.List();

            busca.Q = string.Format("name = '{0}'", NomeArquivo);

            busca.Fields = "files(id)";
            var retorno = busca.Execute();
            if (retorno.Files.Count < 1)
                return "";
            else
                return retorno.Files.First().Id;

        }
    }
}
