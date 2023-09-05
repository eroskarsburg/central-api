namespace Application.Shared.Entity.Book
{
    public class BookEntity
    {
        public BookEntity() { }

        public BookEntity(int id, int iSBN_Code, string? title, Editor? editor)
        {
            Id = id;
            ISBN_Code = iSBN_Code;
            Title = title;
            Editor = editor;
        }

        public int Id { get; set; }
        public int ISBN_Code { get; set; }
        public string? Title { get; set; }
        public Editor? Editor { get; set; }
    }
}
