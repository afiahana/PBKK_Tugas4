using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tugas4_PBKK
{
    class ItemPenjualan
    {
        public ItemPenjualan()
        {
            DiskonPersen = 0;
        }

        public long Id { get; set; }
        public string NamaBarang { get; set; }
        public int Jumlah { get; set; }
        public decimal Harga { get; set; }
        public decimal DiskonPersen { get; set; }
        public decimal Total()
        {
            decimal total = Jumlah * Harga;
            return total - (DiskonPersen / 100 * total);
        }
    }
}
