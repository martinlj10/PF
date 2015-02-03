using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class ModeloProveedores
    {
       string _razonSocialProv;
       string razonSocialProv
       {
           set { this._razonSocialProv = value; }
           get { return _razonSocialProv; }
       }

       string _cuitProv;
       string cuitProv
       {
           get { return _cuitProv; }
           set { _cuitProv = value; }
       }
       
       string _direccionProv;
       string direccionProv
       {
           get { return _direccionProv; }
           set { _direccionProv = value; }
       }
       
       string _ciudadProv;
       string ciudadProv
       {
           get { return _ciudadProv; }
           set { _ciudadProv = value; }
       }

       string _provinciaProv;
       string provinciaProv
       {
           get { return _provinciaProv; }
           set { _provinciaProv = value; }

       }

       string _codigoPostalProv;
       string codigoPostalProv
       {
           get { return _codigoPostalProv; }

           set { _codigoPostalProv = value; }
       }
       
       string _obsProv;
       string obsProv
       {
           get { return _obsProv; }
           set { _obsProv = value; }
       }

       
       
       
    }
}
