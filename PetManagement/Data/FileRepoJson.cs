using System.Text.Json;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic; 

    


namespace Data
{
    public class FileRepoJson
    {
        private static string path ="C:/Revature/JsonCats.json";
        public static async void AddCats(List<Cat> cats){
            using (FileStream stream = File.Create(path))
            {
                try
                {
                    await JsonSerializer.SerializeAsync(stream, cats);
                }
                catch(DirectoryNotFoundException)
                {
                    throw;
                }
                catch (System.Exception)
                {
                    
                    throw;
                }
                
                System.Console.WriteLine("Cats are stored in the Json file");
            }
        }

        public static async Task<List<Cat>> GetCats(){
            using (FileStream stream = File.OpenRead(path))
            {
               var cats = await JsonSerializer.DeserializeAsync<List<Cat>>(stream);
               return cats;
            }
        }
    }
}