using System;
using DAL;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
namespace BLL
{
    public static class UserSession
    {
        public static User CurrentUser { get; set; }
    }
}
