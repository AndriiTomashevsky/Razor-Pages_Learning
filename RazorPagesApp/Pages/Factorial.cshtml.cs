using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApp.Pages
{
    public class FactorialModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Input a number";
        }

        public void OnPost(int? number)
        {
            if (number == null || number < 1)
            {
                Message = "Invalid number. Repeat inputing";
            }
            else
            {
                int result = 1;

                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }

                Message = $"Factorial of number {number} is {result}";
            }
        }
    }
}