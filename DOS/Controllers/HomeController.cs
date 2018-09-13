using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOS.Controllers
{
    public class HomeController : Controller
    {
        private MvcProjesiContext Context = new MvcProjesiContext();
        [HttpGet]

        // GET: Home
        public ActionResult Index()
        {
            Baglanti.ConnectionString = "Data Source = localhost; Initial Catalog = T"

            SqlCommand Komut = new SqlCommand("Select * from Rehbers", Baglanti);
            DataTable DOS = new DataTable();
            SqlDataAdapter Adaptor = new SqlDataAdapter(Komut);
            Adaptor.Fill(DOS);
            int Satir = Convert.ToInt32(DOS.Rows.Count);

            List<Rehber> RehberListesi = new List<Rehber>();
            Rehber R = new Rehber();
            for(int j = 0; j < Satir; j++)
            {
                R = new Rehber();
                R.Id = Convert.ToInt32(DOS.Rows[j]["Id"]);
                R.Name = Convert.ToString(DOS.Rows[j]["Name"]);
                R.City = Convert.ToString(DOS.Rows[j]["City"]);
                R.Address = Convert.ToString(DOS.Rows[j]["Address"]);
                RehberListesi.Add(R);
            }

            return View(RehberListesi);
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
