using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace iTechGmail
{
    public static class GMail
    {
        static string[] Scopes = { GmailService.Scope.GmailReadonly };
        static string ApplicationName = "Itech Gmail";
        static GmailService service;

        public static void UserAuthorization()
        {
            UserCredential credential;

            using (var stream = new FileStream(@"..\..\credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }

        public static List<Message> ListMessages(bool includeSpamTrash = false)
        {
            List<Message> result = new List<Message>();
            UsersResource.MessagesResource.ListRequest request = service.Users.Messages.List("me");
            request.IncludeSpamTrash = includeSpamTrash;
            request.Q = "in:inbox";
            do
            {
                try
                {
                    ListMessagesResponse response = request.Execute();
                    result.AddRange(response.Messages);
                    request.PageToken = response.NextPageToken;
                }
                catch (Exception e)
                {
                    return result;
                }
            } while (!String.IsNullOrEmpty(request.PageToken));

            return result; 
        }

        public static Message GetMessage(string messageId)
        {
            try
            {
                return service.Users.Messages.Get("me", messageId).Execute();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Error");
            }

            return null;
        }

        public static MessageInfo GetMessageInfo(Message message)
        {
            var result = new MessageInfo(message.Id);
            foreach (var messageHeader in message.Payload.Headers)
            {
                switch (messageHeader.Name)
                {
                    case "From":
                        result.From = messageHeader.Value;
                        break;
                    case "To":
                        result.To = messageHeader.Value;
                        break;
                    case "Subject":
                        result.Subject = messageHeader.Value;
                        break;
                    case "Date":
                        result.Date = messageHeader.Value;
                        break;
                }
            }

            return result;
        }
    }
}
