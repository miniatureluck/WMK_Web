using System.ComponentModel;
using WMK_Web.Models;

namespace WMK_Web.Services
{
    public class ClientServices
    {
        public int indexCounter = _clientsDataBase.Count + 1;
        private static List<Client> _clientsDataBase = new List<Client>
        {
            new Client() { Id = 1, Name = "Marek Zegarek", LastUsed = DateTime.Now.AddDays(-1)},
            new Client() { Id = 2, Name = "Stefcia Klepcia", LastUsed = DateTime.Now.AddDays(-3)},
            new Client() { Id = 3, Name = "Ziutek Bomba", LastUsed = DateTime.Now.AddDays(-2)}
        };

        private static List<Session> _sessions1 = new List<Session>
        {
            new Session() { StartTime = DateTime.Now.AddDays(-10), Comment = Session.Comments.Rozmowy, Time = TimeSpan.FromMinutes(10) },
            new Session() { StartTime = DateTime.Now.AddDays(-5), Comment = Session.Comments.Pisma, Time = TimeSpan.FromMinutes(10) },
            new Session() { StartTime = DateTime.Now.AddDays(-3), Comment = Session.Comments.Rozprawy, Time = TimeSpan.FromMinutes(10) },
            new Session() { StartTime = DateTime.Now.AddDays(-1), Comment = Session.Comments.Korespondencja, Time = TimeSpan.FromMinutes(10) },
        };
        private static List<Session> _sessions2 = new List<Session>
        {
            new Session() { StartTime = DateTime.Now.AddDays(-20), Comment = Session.Comments.Rekomendacje, Time = TimeSpan.FromMinutes(10) },
            new Session() { StartTime = DateTime.Now.AddDays(-50), Comment = Session.Comments.Pisma, Time = TimeSpan.FromMinutes(10) },
            new Session() { StartTime = DateTime.Now.AddDays(-30), Comment = Session.Comments.Analiza, Time = TimeSpan.FromMinutes(10) },
        };
        private static List<Session> _sessions3 = new List<Session>
        {
            new Session() { StartTime = DateTime.Now.AddDays(-13), Comment = Session.Comments.Inne, CustomComment = "Oł je bejbe", Time = TimeSpan.FromMinutes(10) },
            new Session() { StartTime = DateTime.Now.AddDays(-111), Comment = Session.Comments.Korespondencja, Time = TimeSpan.FromMinutes(10) },
        };
        public List<Client> GetAll()
        {
            var list = _clientsDataBase.OrderByDescending(x => x.LastUsed).ToList();
            return list;
        }
        public Client GetById(int id)
        {
            return _clientsDataBase.FirstOrDefault(x => x.Id == id);
        }
        public void AddNew(Client client)
        {
            client.Id = indexCounter;
            client.Created = DateTime.Now;
            client.LastUsed = DateTime.Now;
            _clientsDataBase.Add(client);

        }
    }


}
