using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AccountService
    {
        UserAccountRepository accountRepo = new();

        public UserAccount? CheckLogin(String email, String password)
        {
            return accountRepo.GetAccount(email, password); 
        }
    }
}
