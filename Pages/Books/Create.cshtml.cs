using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_denisyuk.Models;
using wt_lab5_5razor_denisyuk.Data;

namespace wt_lab5_5razor_denisyuk.Pages.Books;

public class CreateModel : PageModel
{
    [BindProperty]
    public Book NewBook { get; set; } = new();

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        
        // Если есть ошибки валидации - возвращаем ту же страницу с ошибками
        if (!ModelState.IsValid)
        {
            return Page();
        }

        NewBook.Id = BookStore.Books.Any() 
            ? BookStore.Books.Max(b => b.Id) + 1 
            : 1;

        BookStore.Books.Add(NewBook);

        return RedirectToPage("./Index");
    }
}