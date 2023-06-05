using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class MateriaController : Controller
    {
        public IActionResult GetAll()
        {
            ML.Materia resultmateria = new ML.Materia();
            resultmateria.Materias = new List<Object>();

            ML.Result result = BL.Materia.GetAllLinQ();
            resultmateria.Materias = result.Objects;


            return View(resultmateria);
        }


      
    }
}
