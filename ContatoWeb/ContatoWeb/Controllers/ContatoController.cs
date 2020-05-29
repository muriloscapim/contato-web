﻿using ContatoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContatoWeb.Controllers
{
    public class ContatoController : Controller
    {
        private ContatoRepository repository = new ContatoRepository();

        // GET: Contato
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Contato contato)
        {
            repository.Save(contato);
            return RedirectToAction("Index");
        }
    }
}