using LINQDataContext;

namespace ExerciceDeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataContext dc = new DataContext();

            #region Faites vos exos ici

            /* 2.1 */
            /*//var queryResult = dc.Students.Select(s => new { 
            //    Nom = s.Last_Name, 
            //    DateNaissance = s.BirthDate, 
            //    Resultat = s.Year_Result, 
            //    s.Login });

            var queryResult = from s in dc.Students
                              select new
                              {
                                  Nom = s.Last_Name,
                                  DateNaissance = s.BirthDate,
                                  Resultat = s.Year_Result,
                                  s.Login
                              };

            foreach (var student in queryResult)
            {
                Console.WriteLine($"{student.Nom} : {student.Resultat}/20 né le {student.DateNaissance.ToString("dd/MM/yyyy")} se logue au profil : {student.Login}");
            }*/

            /* 2.3 */
            /*
            //IEnumerable<string> queryResult = dc.Students.Select(
            //        s => $"{s.Student_ID}|{s.Last_Name}|{s.First_Name}|{s.BirthDate}|{s.Login}|{s.Section_ID}|{s.Year_Result}|{s.Course_ID}"
            //    );

            IEnumerable<string> queryResult = from s in dc.Students
                                              select $"{s.Student_ID}|{s.Last_Name}|{s.First_Name}|{s.BirthDate}|{s.Login}|{s.Section_ID}|{s.Year_Result}|{s.Course_ID}";

            foreach (string info in queryResult)
            {
                Console.WriteLine(info);
            }*/
            #endregion

            #region Console.ReadLine()
            Console.ReadLine();
            #endregion
        }
    }
}