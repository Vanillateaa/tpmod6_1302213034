using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace tpmod6_1302213034
{
    internal class sayatubevideo_1302213034
    {
        private int id;
        private string title;
        private int playcount;

        public sayatubevideo_1302213034(String title)
        {
            Debug.Assert(title.Length <= 100 && title != null, "judul video harus memiliki panjang lagu maks 100 karakter dan tidak boleh kosong. ");
            this.title = title;
            var random = new Random();
            this.id = random.Next(10000, 99999);
            this.playcount = 0;
        }

        public void IncreasePlayCount_1302213034(int playCount)
        {
            Debug.Assert(playCount > 10000000 || playCount < 0, "input penamabah play count maksimal 10000000 per panggilan method-nya. ");
            try
            {
                this.playcount = checked(this.playcount + playCount);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("overflow exception: " + e.Message);
            }
        }

        public void printvideodetails_1302213034()
        {
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Tittle: " + this.title);
            Console.WriteLine("jumlah dimainkan: " + this.playcount);
        }

    }
}
