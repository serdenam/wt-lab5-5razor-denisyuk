using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_denisyuk.Models;
using wt_lab5_5razor_denisyuk.Data;

namespace wt_lab5_5razor_denisyuk.Pages.Books;

public class IndexModel : PageModel
{
    public List<Book> Books { get; set; } = new();

    public void OnGet()
    {
        Books = BookStore.Books;
    }
        public IActionResult OnPostDelete(int id)
    {
        var book = BookStore.Books.FirstOrDefault(b => b.Id == id);
        if (book != null)
        {
            BookStore.Books.Remove(book);
        }
        return RedirectToPage("./Index");
    }
}