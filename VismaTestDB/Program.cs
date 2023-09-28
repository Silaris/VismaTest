// See https://aka.ms/new-console-template for more information
using VismaTestDB;

Console.WriteLine("Visma data started!");

using (ApplicationContext db = new ApplicationContext())
{
    db.Developers.ToList();
    Console.WriteLine("Data received!");
}