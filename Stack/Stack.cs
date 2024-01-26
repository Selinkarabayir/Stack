using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Stack
    {
        public int top;
        public int boyut;
        public int[] values;
        public int[] tmp;
        public int index;
        
        public Stack(int boyut)
        {
            this.boyut = boyut;
            this.top = -1;
            values = new int[boyut];
            tmp = new int[boyut];
          


        }
        Boolean stackdolumu()
        {
            if (this.top ==( this.boyut - 1))
                return true;
            else
                return false;
        }
        Boolean stackbosmu()
        {
            if (this.top == -1)
                return true;
            else
                return false;
        }
        public void push(int veri)
        {
            if (stackdolumu())
                Console.WriteLine("stack dolu ");
            else
            {
                this.top++;
                this.values[this.top] = veri;
            }

        }
        public void print()
        {
            if (stackbosmu())
                Console.WriteLine("stack boş");
            else
            {
                for (int i = this.top ; i > -1; i--)
                {
                    Console.WriteLine(this.values[i]);
                }
            }


        }
        public void pop(int cikartilacakveri)
        {
            if (stackbosmu())
                Console.WriteLine("stack boş");

            else
            {
                int index = -1;
                while (values[this.top] != cikartilacakveri)
                {
                    top--;
                    index++;
                    tmp[index] = this.values[this.top + 1];
                    if (this.top == -1)
                    {
                        Console.WriteLine("Silmek istediğiniz eleman yığında bulunamadı");
                        break;

                    }

                }
                    if(this.top != -1)
                    top--;
                    for (int j = index; j > -1; j--)
                    {
                        push(tmp[j]);
                    }

            }
        }
        public void yerdegistir()
        {
            int soneleman = values[this.top];
            int index = -1;
            top--;
            index++;
           
            while (this.top != 0)
            {
                top--;
                index++;
                tmp[index] = this.values[this.top + 1];
            }
            
            index++;
            int ilkeleman = values[this.top];
            top--;  

            push(soneleman);

            for (int k=index-1; k>0; k--)
            {  
               
              push(tmp[k]);
               
            }
            push(ilkeleman);

            

        }
    }
}

