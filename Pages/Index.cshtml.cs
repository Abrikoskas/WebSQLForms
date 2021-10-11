using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;



namespace WebSQLForms.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private PgSQL pg = new PgSQL();
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string Message { get; set; }
        public string LMessage { get; set; }
        public DateTime date1 = DateTime.Now;

        public List<Check> listForCheck = new List<Check>(5);


        [BindProperty]
        public PersonInfo Inf { get; set; }
        public void OnGet()
        {
            Message = "CONTACT";
            LMessage = "US";
        }
        public void OnPost()
        {
            listForCheck.Add(new Check(Inf.Surname.Equals(null), Inf.Surname, false, "surnames"));
            listForCheck.Add(new Check(Inf.Name.Equals(null), Inf.Name, false, "names"));
            listForCheck.Add(new Check(Inf.Middlename.Equals(null), Inf.Middlename, false, "middlenames"));
            listForCheck.Add(new Check(Inf.Street.Equals(null), Inf.Street, false, "streets"));
            listForCheck.Add(new Check(Inf.Phone.Equals(null), Inf.Phone, true, "clients"));

            Message = PgSQL.WriteToDB(listForCheck);
            listForCheck.Clear();
        }

    }
}
