using elave_task_todo;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

internal class Program
{
    List<User> users = new List<User>();
    Todo Todo;
    static void Main(string[] args)
    {
        Console.WriteLine("Select command:");
        Console.WriteLine("1. User create");
        Console.WriteLine("2. User remove");
        Console.WriteLine("3. User get all");
        Console.WriteLine("4. Todo create");
        Console.WriteLine("5. Todo remove");
        Console.WriteLine("6. Todo get all by User");
        Console.WriteLine("7. Todo remove All");
        Console.WriteLine("8. Todo remove (IsCheck)");
        Console.WriteLine("9. Exit");
        List<User> users = new List<User>();
        while (true) 
        {
            int command =int .Parse(Console.ReadLine());
            switch(command) 
            {
                case 1:
                    UserCreate();
                    break;
                case 2:
                    UserRemove();
                    break;

                case 3:
                    UserGetAll(); 
                    break;

                case 4:
                    
                    TodoCreat();
                    break;

                case 5:

                    TodoRemove(); 
                    break;

                case 6:
                    TodoGetAllByUser();
                    break;

                case 7:
                    TodoRemoveAll();

                     break;

                case 8:

                    TodoRemoveIsCheck();
                     break;

                case 9:
                    Exit();

                    break;
            }

        }   
    }

    static void UserCreate()
    {
        List<User> users = new List<User>();
        Console.WriteLine("Enter User Name: ");
        string name= Console.ReadLine();

        Console.WriteLine("Enter User Surname: ");
        string surname= Console.ReadLine();

        Console.WriteLine("___User Created___");

        User user = new User(name, surname);
        users.Add(user);
        
    }

    static void UserRemove()
    {
        List<User> users = new List<User>();
        Console.WriteLine("Enter User Id:");
        int id=int.Parse(Console.ReadLine());
        
        User user = users.Find(user => user.Id == id);
        if(user == null) 
        {
            throw new NotFoundException("User Not Found");
        
        }
        users.Remove(user);
        Console.WriteLine("___User removed__");

    }


    static void UserGetAll() 
    {
        List<User> users = new List<User>();
        Console.WriteLine("---Users:");
        foreach(User item in users)
        {
            Console.WriteLine($"{item.Id} {item.Name} {item.Surname}");
        }
    }
    static void TodoCreat()
    {
        List<User> users = new List<User>();
        Todo todo = new Todo("hghghgh", false);
        Console.WriteLine("Enter UserId for TodoCreate");
        int Id=int.Parse(Console.ReadLine());
         User user =users.Find(u=>u.Id == Id);
        
        if (user != null)
        {
            Console.WriteLine("Enter todo title:  ");
            todo.Title = Console.ReadLine();


            todo.IsCheck = false;
            user.Todos.Add(todo);

            Console.WriteLine("___Todo created___");
        }
        else
        {
            throw new NotFoundException("User Not Found");
        }
    }

    static void TodoRemove() 
    {
        List<User> users = new List<User>();
        Console.WriteLine("Enter User Id:  ");
        int userid = int.Parse(Console.ReadLine());
        User user = users.Find(u=> u.Id == userid);
        
        if(user == null) 
        {
            throw new NotFoundException("Not Found User Id");
        }

        Console.WriteLine("Enter Todo Id:   ");
        int todoid=int.Parse(Console.ReadLine());
        Todo todos= user.Todos.Find(u=>u.Id == todoid);
        if(todos == null) 
        
        {
            throw new NotFoundException("TodoId Not Found ");
        }

        user.Todos.Remove(todos);
    }

    static void TodoGetAllByUser() 
    {
        List<User> users = new List<User>();
        Console.WriteLine("Enter UserId for TodoGetAllByUse: ");

        int userId = int.Parse(Console.ReadLine());

        User user = users.Find(u => u.Id == userId);
        if (user == null)
        {
            throw new NotFoundException("Id Not Found");
        }
        foreach(Todo todo in user.Todos) 
        {
            Console.WriteLine($"Id: {todo.Id}, Title:{todo.Title} , Ischeck: {todo.IsCheck}");
        }
    }

    static void TodoRemoveAll() 
    {
        List<User> users = new List<User>();
        foreach (User item in users) 
        {
            item.Todos.Clear();
        }
    }


    static void TodoRemoveIsCheck() 
    {
        bool ischeck = false;
        List<User> users = new List<User>();
        foreach(User item in users) 
        {
            if (ischeck = false)
            {
                item.Todos.RemoveAll(t=>t.IsCheck == ischeck);
            }
        }
    }
    static void Exit()
    {
        Console.WriteLine("Exit program");
    }
}