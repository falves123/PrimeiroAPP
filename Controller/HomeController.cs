using Microsoft.AspNetCore.Mvc;
using primeiroapp.ViewModel;

namespace primeiroapp
{
    public class HomeController : Controller
    {
    
        public IActionResult index(){
            return View(new HomeViewModel{Mensagem = "Bem Vindo from Controller"});
        } 
        public IActionResult Sobre(){
            return View();
        } 
        
        public IActionResult Contato(){
            return View();
        } 


    }

}