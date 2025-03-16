namespace Entities
{
    public class ProgrammingLanguage
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Teknolojilerin bu dil ile ilişkili olduğunu belirten bir koleksiyon
        public List<Technology> Technologies { get; set; }

        public ProgrammingLanguage()
        {
            Technologies = new List<Technology>(); // Teknolojileri başlatıyoruz
        }
    }
}
