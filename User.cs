namespace ChatDB
{
    public class User
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public virtual ICollection<Message> IncomingMessages { get; set; }
        public virtual ICollection<Message> OutgoingMessages { get; set; }

    }
}
