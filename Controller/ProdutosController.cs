using System.Linq;
using Microsoft.AspNetCore.Mvc;
using primeiroapp.models;

namespace primeiroapp{
    public class ProdutosController : Controller{

        public BancoDBContext Banco { get; set; }
        public ProdutosController(BancoDBContext banco)
        {
            this.Banco = banco;
        }
        public IActionResult Index()
        {
                        return View(this.Banco.Produtos.ToList());   
        }
        public IActionResult Editar(int id)
        {
          var produto = this.Banco.Produtos.FirstOrDefault(_=>_.ProdutoID == id);
          if(Produto == null){
              return NotFound();
          }
        }
        public IActionResult Excluir()
        {
            
        }
    }

}