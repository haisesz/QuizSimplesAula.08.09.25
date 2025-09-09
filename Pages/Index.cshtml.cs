using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QuizSimplesAula._08._09._25.Pages.Models;

namespace QuizSimplesAula._08._09._25.Pages
{
       public class IndexModel : PageModel
        {
            [BindProperty]
            public QuizModel Quiz { get; set; } = new();

            private readonly Dictionary<string, string> respostasCorretas = new()
        {
            { "Pergunta1", "Brasília" },
            { "Pergunta2", "Amazonas" },
            { "Pergunta3", "Brasil" }
        };

            public void OnGet()
            {
    
            }
            public void OnPost()
            {
                Quiz.Pergunta1Correta = string.Equals(Quiz.Pergunta1, respostasCorretas["Pergunta1"], StringComparison.OrdinalIgnoreCase);
                Quiz.Pergunta2Correta = string.Equals(Quiz.Pergunta2, respostasCorretas["Pergunta2"], StringComparison.OrdinalIgnoreCase);
                Quiz.Pergunta3Correta = string.Equals(Quiz.Pergunta3, respostasCorretas["Pergunta3"], StringComparison.OrdinalIgnoreCase);

                int acertos = 0;
                if (Quiz.Pergunta1Correta == true) acertos++;
                if (Quiz.Pergunta2Correta == true) acertos++;
                if (Quiz.Pergunta3Correta == true) acertos++;

                Quiz.Acertos = acertos;
            }
        }
    }