using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validacija
{
    public class Validacija
    {
        public bool ValidirajUnos(string podatak)
        {
            if(podatak == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool ValidirajJednakostLozinki(string lozinka, string potvrda)
        {
            if(lozinka == potvrda)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidirajJakostLozinke(string lozinka)
        {
            if(lozinka.Length >= 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidirajEmail(string email)
        {
            if(email.Contains("@"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int ValidirajBroj(string unos)
        {
            int broj;
            bool uspjeh = Int32.TryParse(unos, out broj);
            if(uspjeh && broj >= 0)
            {
                return broj;
            }
            else
            {
                return -1;
            }
        }
        public bool ValidirajOdabraniObjekt(object objekt)
        {
            if(objekt == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
