// Caminho: Controllers/LoginController.cs
using Microsoft.AspNetCore.Mvc;
using BookGrap.Models; // ou ajuste para onde está Usuario.cs
using BookGrap.Data;   // onde está AppDbContext
using System.Linq;

public class LoginController : Controller
{

    // LoginController.cs
    public IActionResult Login(){
        return View("login");
    }


    private readonly AppDbContext _context;

    public LoginController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(string login, string senha)
    {
        var usuario = _context.Usuarios
                              .FirstOrDefault(u => u.Login == login && u.Senha == senha);

        if (usuario != null)
        {
            return RedirectToAction("Index", "Home");
        }

        ViewBag.Erro = "Login ou senha inválidos.";
        return View();
    }
}
