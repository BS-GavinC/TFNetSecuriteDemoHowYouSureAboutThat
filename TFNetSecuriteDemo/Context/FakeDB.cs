using TFNetSecuriteDemo.Models;

namespace TFNetSecuriteDemo.Context
{
    public static class FakeDB
    {
        public static List<User> Users { get; set; } = new List<User>()
        {
            new User(1, "Brigitte", "Bardot", DateTime.Now, "Bardo@Brigou.fr", "F"),
            new User(2, "Jean", "Dupont", DateTime.Now, "Jean.Dupont@email.fr", "M"),
            new User(3, "Marie", "Curie", DateTime.Now, "Marie.Curie@email.fr", "F"),
            new User(4, "Pierre", "Curie", DateTime.Now, "Pierre.Curie@email.fr", "M"),
            new User(5, "Victor", "Hugo", DateTime.Now, "Victor.Hugo@email.fr", "M"),
            new User(6, "Simone", "de Beauvoir", DateTime.Now, "Simone.deBeauvoir@email.fr", "F"),
            new User(7, "Albert", "Camus", DateTime.Now, "Albert.Camus@email.fr", "M"),
            new User(8, "Françoise", "Sagan", DateTime.Now, "Francoise.Sagan@email.fr", "F"),
            new User(9, "Gustave", "Flaubert", DateTime.Now, "Gustave.Flaubert@email.fr", "M"),
            new User(10, "Émile", "Zola", DateTime.Now, "Emile.Zola@email.fr", "M"),
        };
    }
}
