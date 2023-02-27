using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using WMK_Web.Models;
using WMK_Web.Services;

namespace WMK_Web.Controllers
{
    public class ClientController : Controller
    {
        private readonly ClientServices _clientServices;
        public ClientController()
        {
            _clientServices = new ClientServices();
        }

        // GET: ClientController
        public ActionResult Index()
        {
            var clientList = _clientServices.GetAll();
            return View(clientList);
        }

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {
            var client = _clientServices.GetById(id);
            return View(client);
        }

        // GET: ClientController/Create
        public ActionResult Create(int id)
        {
            var client = _clientServices.GetById(id);
            return View(client);
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Client client)
        {
            //SqlConnection sqlCon = new SqlConnection("Server = localhost; Database = wmkancelaria; User Id = joanna; Password = natan");
            try
            {
                _clientServices.AddNew(client);
                //SqlCommand sqlCmd = new SqlCommand("Clients", sqlCon);
                //sqlCmd.CommandType = CommandType.StoredProcedure;
                //sqlCmd.Parameters.AddWithValue("Name", client.Name);
                //sqlCmd.Parameters.AddWithValue("LastUsed", DateTime.Now);
                //sqlCon.Open();
                //sqlCmd.ExecuteNonQuery();
                //sqlCon.Close();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
