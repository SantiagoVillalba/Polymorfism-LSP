namespace LSPLibrary
{
    public class Event
    {
        public string EventName { get; set; }
        public string EventType { get; set; }

        /* No cumple con polimorfismo ya que tambien cambia lo que hace el codigo segun el string de EventType
        y esto podria facilitarse y cumplir con el principio usando una interfaz.*/
        public void Notify()
        {
            new Alert().Send("text", this.EventName);

            if (this.EventType == "severe")
            {
                new Alert().Send("trello", this.EventName);
            }
        }
    }
}