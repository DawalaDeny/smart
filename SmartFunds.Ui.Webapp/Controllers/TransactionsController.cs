using Microsoft.AspNetCore.Mvc;
using SmartFunds.Ui.Webapp.Data;

namespace SmartFunds.Ui.Webapp.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly SmartFundsDbContext _dbContext;

        public TransactionsController(SmartFundsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index(int id)
        {
            var transactions = _dbContext.Transactions
                .Where(t => t.OrganizationId == id)
                .ToList();

            return View(transactions);
        }
    }
}
