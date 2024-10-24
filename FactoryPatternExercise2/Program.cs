namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which server would you like to use? List, SQL, or Mongo?");
            
            string usersDatabase = Console.ReadLine();

            IDataAccess database = DataAccessFactory.GetDataAccessType(usersDatabase);

            List<Product> products = database.LoadData();
            database.SaveData();

            Console.WriteLine();
            Console.WriteLine("Here are your products");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"Product Name: {products[i].Name} | {products[i].Price,0:c}");
            }


        }
    }
}
