using System;
using System.Collections.Generic;
using System.Text;

namespace TAP_TEST.Domain.Entities
{
   public class CardPrefix
    {
        public int Id { get; set; }
        public string Prefix { get; set; }
        public string BankAlias { get; set; }
        public string CardType { get; set; }
    }
}
