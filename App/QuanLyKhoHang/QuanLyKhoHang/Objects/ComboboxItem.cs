using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang
{
    class ComboboxItem
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public override string ToString()
        {
            return Ten;
        }
    }
}
