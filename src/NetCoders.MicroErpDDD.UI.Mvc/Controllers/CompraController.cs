using AutoMapper;
using NetCoders.MicroErpDD.Domain.Entities;
using NetCoders.MicroErpDD.Domain.Interfaces.Repository;
using NetCoders.MicroErpDDD.Application.Interfaces;
using NetCoders.MicroErpDDD.UI.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace NetCoders.MicroErpDDD.UI.Mvc.Controllers
{
    public class CompraController : Controller
    {
        private readonly ICompraApplicationService _compraApplicationService;
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IProdutoRepository _produtoRepository;
        private readonly ICompraRepository _compraRepository;

        public CompraController(
            ICompraApplicationService compraApplicationService,
            IFornecedorRepository fornecedorRepository,
            IProdutoRepository produtoRepository,
            ICompraRepository compraRepository)
        {
            _compraApplicationService = compraApplicationService;
            _fornecedorRepository = fornecedorRepository;
            _produtoRepository = produtoRepository;
            _compraRepository = compraRepository;
        }

        public ActionResult Index()
        {
            var compras = _compraRepository.ConsultarComFornecedor();
            var comprasModel = Mapper.Map<IList<CompraModel>>(compras);
            return View(comprasModel);
        }

        // GET: Compra/Create
        public ActionResult Create()
        {
            CarregarCombos();
            return View();
        }

        // POST: Compra/Create
        [HttpPost]
        public ActionResult Create(CompraModel compraModel)
        {
            if (!ModelState.IsValid)
            {
                CarregarCombos();
                return View(compraModel);
            }

            try
            {
                var compra = Mapper.Map<Compra>(compraModel);
                _compraApplicationService.Salvar(compra);
            }
            catch (Exception ex)
            {
                CarregarCombos();
                ModelState.AddModelError("Erro", ex.Message);
                return View(compraModel);

                //Caso fosse ajax, o método poderia ser void e exibir o erro assim:
                //Response.StatusCode = (int)HttpStatusCode.BadRequest;
                //Response.Write(ex.Message);
            }

            return RedirectToAction("Index");
        }

        private void CarregarCombos()
        {
            var fornecedores = _fornecedorRepository.Get();
            ViewBag.Fornecedores = new SelectList(fornecedores, "IdFornecedor", "Nome");

            var produtos = _produtoRepository.Get();
            ViewBag.Produtos = new SelectList(produtos, "IdProduto", "Nome");
        }

    }
}
