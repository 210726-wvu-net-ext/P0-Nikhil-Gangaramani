using Data;
namespace App
{
    /// <summary>
    /// Declaring a delegate of type void
    /// </summary>
    static delegate void DelCatOperations();
    public class UsingData
    {
         public static void CallDatabaseCon(){
           using (DatabaseConnection connection =  new DatabaseConnection())
           {
                System.Console.WriteLine("Using connection");
           }

        }

        // anonymous methods - they are created for single use
        DelCatOperations del = delegate(){
            var cats=FileRepoXML.Init();
            if(cats.Count > 0){
                FileRepoXML.AddCats(cats);
                System.Console.WriteLine("Data has been stored in XML");
            }
        };

        // lamda expression is short hand notation for anonymous method

        DelCatOperations del1 =()=>{
            var cats=FileRepoXML.Init();
            if(cats.Count > 0){
                FileRepoXML.AddCats(cats);
                System.Console.WriteLine("Data has been stored in XML");
            }
        };
        /* public static void Serialize_Xml(){

            var cats=FileRepoXML.Init();
            if(cats.Count > 0){
                FileRepoXML.AddCats(cats);
                System.Console.WriteLine("Data has been stored in XML");
            }
        } */
        
        Action deserialize_Xml =()=>{

            var cats = FileRepoXML.GetCats();
            System.Console.WriteLine("Reading from XML....");
            foreach (var cat in cats)
            {
                System.Console.WriteLine($"{cat.Id} {cat.Name} {cat.FurType}");
            }
        };
        
        /* public static void Deserialize_Xml(){

            var cats = FileRepoXML.GetCats();
            System.Console.WriteLine("Reading from XML....");
            foreach (var cat in cats)
            {
                System.Console.WriteLine($"{cat.Id} {cat.Name} {cat.FurType}");
            }
        } */

        public static void Serialize_Json()
        {
           var cats = FileRepoXML.Init();
           if(cats.Count > 0)
                FileRepoJson.AddCats(cats);
            
        }

        public static void DeSerialize_Json()
        {
           var cats = FileRepoJson.GetCats().Result;
           System.Console.WriteLine("Reading from Json...");
           foreach (var cat in cats)
            {
                System.Console.WriteLine($"{cat.Id} {cat.Name} {cat.FurType}");
            }
        }
    }
}