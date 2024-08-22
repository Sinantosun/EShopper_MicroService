using EShopper.Message.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.Message.Persistance.Context
{
    public class MessageContext :DbContext
    {
        public MessageContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<UserMessage> userMessages { get; set; }
    }
}
