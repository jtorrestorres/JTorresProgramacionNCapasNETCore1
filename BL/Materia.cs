namespace BL
{
    public class Materia
    {
        public static ML.Result GetAllLinQ()
        {
            ML.Result result = new ML.Result();

            try
            {
                //using (DL.JTorresProgramacionNCapasEntities context = new DL_EF.JTorresProgramacionNCapasEntities())
                //{
                //    var listMaterias = (from materiaAlias in context.Materias
                //                        select new
                //                        {
                //                            IdMateria1 = materiaAlias.IdMateria,
                //                            Nombre1 = materiaAlias.Nombre,
                //                            Creditos1 = materiaAlias.Creditos,
                //                            Costo1 = materiaAlias.Costo,
                //                            IdSemestre1 = materiaAlias.IdSemestre,
                //                            Imagen = materiaAlias.Imagen
                //                        }).ToList();



                //    if (listMaterias != null)
                //    {

                //        if (listMaterias.Count > 0)
                //        {
                //            result.Objects = new List<object>();
                //            foreach (var obj in listMaterias)
                //            {
                //                ML.Materia materiaItem = new ML.Materia();
                //                materiaItem.IdMateria = obj.IdMateria1;
                //                materiaItem.Nombre = obj.Nombre1;
                //                materiaItem.Creditos = obj.Creditos1.Value;
                //                materiaItem.Costo = obj.Costo1.Value;
                //                materiaItem.Semestre = new ML.Semestre();
                //                materiaItem.Semestre.IdSemestre = (obj.IdSemestre1 == null) ? byte.Parse("0") : obj.IdSemestre1.Value;
                //                materiaItem.Imagen = obj.Imagen;
                //                result.Objects.Add(materiaItem);
                //            }

                //            result.Correct = true;

                //        }
                //        else
                //        {
                //            result.Correct = false;
                //            result.ErrorMessage = "La tabla Materia no tiene registros";
                //        }
                //    }

                 
                //}
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;

        }
    }
}