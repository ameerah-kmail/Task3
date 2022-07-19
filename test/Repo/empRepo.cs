using test.models;
namespace test.Repo
{
    public class empRepo
    {
      
        static List<emp> e{ get; set;}

        static empRepo()
        {
            e = new List<emp>()
            {
                new emp(){ Id = 1, Name ="a" ,Title="cse",Salary=60000},
                new emp(){ Id = 2, Name ="b" ,Title="cs",Salary=60000}

        };
        }

        public static List<emp> getAll ()
        {
            return e;
        }
        /*
        public static List<emp> get(int id)
        {
            return e.FirstOrDefault(emp=>emp.Id==id);
        }
        public static delete(int id)
        {
            var e = get(id);
            if (e == null)
                return NotFound;

        }*/
    }
}
