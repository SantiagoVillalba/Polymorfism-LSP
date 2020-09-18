using System;

namespace LSPLibrary
{
    public class Alert
    {
        /* Por principio de polimorfismo esto esta mal, ya que es un mismo metodo, que cambia su comportamiento
        segun el type, esto podria hacerse en una interfaz, la cual va a una clase o a otra para aplicar 
        el comportamiento segun el parametro. */
        public void Send(string type, string text)
        {
            if (type == "trello")
            {
                new TrelloCardCreator().CreateCard(text);
            }
            else if (type == "text") 
            {
                Console.WriteLine(text);
            }
        }
    }
}