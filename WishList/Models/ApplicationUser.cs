﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using WishList.Models.AccountViewModels;

namespace WishList.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Item> Items { get; set; }
    }
}
