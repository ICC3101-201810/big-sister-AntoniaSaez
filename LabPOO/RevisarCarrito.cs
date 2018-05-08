using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPOO
{
    public delegate void RevisarCompraNecesariaDelegate(Product p);
    


    public class RevisarCarrito
    {
        public event RevisarCompraNecesariaDelegate QuitarProducto;
        

        public RevisarCarrito()
        {
            QuitarProducto += new RevisarCompraNecesariaDelegate(Retar);
        }
        public void ChequearCompra(RevisarCompraNecesariaDelegate deleganterevisarcompra)
        {
                    
            foreach (Product p in Program.cart)
            {
                
                if (Program.ingredientesreceta.Contains(p))
                {
                    continue;
                }
                else
                {

                    QuitarProducto(p);
                    
                    continue;

                }
               
            }
            
                        

        }
        public void Retar(Product p)
        {
            Program.cart.Remove(p);
            Console.WriteLine("Se removio el producto" + p);
        }

    }
    
}
