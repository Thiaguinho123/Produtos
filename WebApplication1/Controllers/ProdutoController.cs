using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Data.Entity;
using System.Net;

namespace WebApplication1.Controllers
{
    public class ProdutoController : Controller
    {
        private EFContext context = new EFContext();

        // GET: Produto//Index
        public ActionResult Index()
        {
            var veiculos =
            context.Produtos.Include(c => c.Departamento).
            OrderBy(n => n.Descricao);
            return View(veiculos);
        }
        // GET: Produto//Details//5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = context.Produtos.Where(p => p.ProdutoId == id).
            Include(c => c.Departamento).First();
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }
        // GET: Produtos//Create
        public ActionResult Create()
        {
            ViewBag.DepartamentoId = new SelectList(context.Departamentos.OrderBy(b => b.Nome), "DepartamentoId", "Nome");
            return View();
        }
        // POST: Produtos//Create
        [HttpPost]
        public ActionResult Create(Produto produto)
        {
            try
            {
                context.Produtos.Add(produto);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(produto);
            }
        }
    }
}