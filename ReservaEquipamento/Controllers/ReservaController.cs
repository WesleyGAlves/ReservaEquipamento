using Microsoft.AspNetCore.Mvc;
using ReservaEquipamento.Data;
using ReservaEquipamento.Models;

namespace ReservaEquipamento.Controllers
{
    public class ReservaController : Controller
    {

        readonly private ApplicationDbContext _db;

        public ReservaController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<ReservaModel> reservas = _db.Reservas;

            return View(reservas);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            ReservaModel reserva = _db.Reservas.FirstOrDefault(x => x.id == id);

            if (reserva == null)
            {
                return NotFound();
            }

            return View(reserva);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            ReservaModel reserva = _db.Reservas.FirstOrDefault(x => x.id == id);

            if(reserva == null)
            {
                return NotFound();
            }

            return View(reserva);
        }
    
        [HttpPost]
        public IActionResult Cadastrar(ReservaModel reservas)
        {
            if (ModelState.IsValid)
            {
                _db.Reservas.Add(reservas);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Reserva realizada com sucesso!";

                return RedirectToAction("Index");

            }

            return View();

        }


        [HttpPost]
        public IActionResult Editar(ReservaModel reserva)
        {

            if (ModelState.IsValid)
            {
                _db.Reservas.Update(reserva);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Edição realizada com sucesso!";

                return RedirectToAction("Index");
            }

            return View(reserva);

        }


        [HttpPost]
        public IActionResult Excluir(ReservaModel reserva)
        {
            if(reserva == null)
            {
                return NotFound();
            }

            _db.Reservas.Remove(reserva);
            _db.SaveChanges();

            TempData["MensagemSucesso"] = "Exclusão realizada com sucesso!";

            return RedirectToAction("Index");
        }
    }
}
