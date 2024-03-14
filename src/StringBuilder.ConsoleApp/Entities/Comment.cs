// Devido a um conflito de nomes, o namespace original foi alterado
//namespace StringBuilder.ConsoleApp.Entities
namespace ConsoleApp.Entities
{
    internal class Comment(string text)
    {
        public string Text { get; set; } = text;
    }
}
