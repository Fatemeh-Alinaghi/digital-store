using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalStoreManagement.Enums;

namespace DigitalStoreManagement.Models
{
    public class DigitalProduct : BaseProduct
    {
        
        public CategoryType StorageType { get; set; }

        public override string GetInfo()
        {
            return $"{Name} - {StorageType} - تومان{Price}";
        }
    }
}
