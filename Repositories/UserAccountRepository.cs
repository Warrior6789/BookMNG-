using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserAccountRepository
    {
        private BookManagementDbContext _context;
        public UserAccount? GetAccount(String email, String password) // có thể trả về null 
        {
            _context = new();
            return _context.UserAccounts.FirstOrDefault(x =>
            x.Email == email && x.Password == password
            );
            // .select(đưa vào lambda trả về) list acc 
            // .firstorDefault(Lambda) trả về 1 dòng hoặc null theo tiêu chí lambda
        }
    }
}
