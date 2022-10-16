using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    internal class Stapel<I>
    {
        private List<I> Container = new List<I>();


        public void Toevoegen(I eenObject)
        {
            Container.Add(eenObject);
        }

        public I Verwijderen()
        {
            I wegGegooidObject = Container.Last();
            Container.Remove(Container.Last());

            return wegGegooidObject;
        }

        public void LeegMaken()
        {
            Container.Clear();
        }

        public override string ToString()
        {
            String containerValue = "";
            if(Container.Count == 0)
            {
                containerValue = "Container is leeg";
            }
            else
            {
                for(int i = 0; i < Container.Count; i++)
                {
                    containerValue += Container[i].ToString();
                    containerValue += " | ";
                }
            }

            return containerValue;
        }

        public bool IsAanwezig(I eenObject)
        {
            if (Container.Contains(eenObject))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Stapel<I> Copy()
        {
            Stapel<I> clonedStapel = (Stapel<I>)this.MemberwiseClone();

            return clonedStapel;
        }

    }
}
