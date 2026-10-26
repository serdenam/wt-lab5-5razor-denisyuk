using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_denisyuk.Models;
using wt_lab5_5razor_denisyuk.Data;

namespace wt_lab5_5razor_denisyuk.Pages.Books;

public class DetailsModel : PageModel
{
    public Book? CurrentBook { get; set; }

    public IActionResult OnGet(int id)
    {
        CurrentBook = BookStore.Books.FirstOrDefault(b => b.Id == id);
        if (CurrentBook == null) return NotFound();
        return Page();
    }
}