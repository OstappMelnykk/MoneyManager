using System;
using System.Collections.Generic;

namespace MoneyManagerApp.DAL.Models;

public partial class User
{
    public int UsersId { get; set; }

    public string UsersName { get; set; } = null!;

    public string UsersPhonenumber { get; set; } = null!;

    public string UsersPassword { get; set; } = null!;

    public string UsersEmail { get; set; } = null!;

    public byte[]? UsersPhoto { get; set; }

    public virtual ICollection<Account> Accounts { get; } = new List<Account>();
}
