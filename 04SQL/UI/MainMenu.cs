using System; 
using Models;
using System.Collections.Generic; 

    

    

    

using BL;


namespace UI
{
    public class MainMenu: IMenu
    {   
        
         private IPetBL _petbl;
         public MainMenu(IPetBL bl)
         {
             _petbl = bl;
         }

        public void Start(){
           
           
           // Cat cat = new Cat();

            bool repeat = true;

             do
             {
             Console.WriteLine("Welcome to Cat Manager!");
             Console.WriteLine("[0] Exit");
             Console.WriteLine("[1] Add a Cat");
             Console.WriteLine("[2] Feed All Cats");
             Console.WriteLine("[3] ViewAllCats");

             switch (Console.ReadLine())
             {
                 
                 case "0":
                    Console.WriteLine("Good bye!");
                    repeat = false;
                    break;

                 case "1":
                    AddACat();
                    break;

                 case "2":
                    FeedACat();
                    break;

                 case "3":
                    ViewAllCats();
                    break;

                 default:
                    Console.WriteLine("We dont understand what you're doing");
                    break;
            
             } 

             
            }while (repeat); 
    }

        private void AddACat(){
            Console.WriteLine("You're adding a Cat");
        }
        private void FeedACat(){
             Console.WriteLine("You're feeding a Cat");
        }

        private void ViewAllCats(){
             Console.WriteLine("You're Viewing all Cats");
        }
    }
}