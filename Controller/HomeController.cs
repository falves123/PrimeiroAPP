using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using primeiroapp.models;
using primeiroapp.ViewModel;

namespace primeiroapp
{
    public class HomeController : Controller
    {
        public BancoDBContext Banco { get; set; }
        public HomeController(BancoDBContext banco)
        {
            this.Banco = banco;
        }
        public IActionResult index()
        {
            /*
            this.Banco.Produtos.Add(new Produto{ Descricao = "Bola de Futebol", DataCadastro = DateTime.Now });
            
            this.Banco.SaveChanges();
*/
            return View(new HomeViewModel{
                Mensagem = $"Bem Vindo from Controller, Quantidade de produto: {this.Banco.Produtos.Count()}"
                });
    
        }   
        public IActionResult Sobre(){
            return View(this.Banco.Produtos.ToList());
        } 
        
        public IActionResult Contato(){
            return View();
        } 
        override protected void Dispose(bool disposing){
            if(disposing){
                    this.Banco.Dispose();   
            }
        }


    }

}