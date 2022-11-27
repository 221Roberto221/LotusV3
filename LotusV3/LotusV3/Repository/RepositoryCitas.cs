using LotusV3.Dependencies;
using LotusV3.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace LotusV3.Repository
{
    public class RepositoryCitas
    {
        private SQLiteConnection cn;
        public RepositoryCitas()
        {
            this.cn = DependencyService.Get<IDataBase>().GetConnection();
        }
        //------------------MÉTODOS:
        public void CrearBBDD()
        {
            this.cn.DropTable<Citas>();

            this.cn.CreateTable<Citas>();

        }

        public List<Citas> GetRazas()
        {
            var consulta = from datos in cn.Table<Citas>()
                           select datos;
            return consulta.ToList();
        }
        public Citas BuscarRaza(int num)
        {
            var consulta = from datos in cn.Table<Citas>()
                           where datos.Codigo == num
                           select datos;
            return consulta.FirstOrDefault();
        }
        public void InsertarRaza(int num, string nom, string car)
        {
            Citas raz = new Citas();
            raz.Caracteristicas = car;
            raz.Codigo = num;
            raz.Nombre = nom;
            this.cn.Insert(raz);
        }

        public void ModificarRaza(int num, string nom, string car)
        {
            Citas raz = this.BuscarRaza(num);
            raz.Nombre = nom;
            raz.Caracteristicas = car;
            this.cn.Update(raz);
        }
        public void EliminarRaza(int num)
        {
            Citas raz = this.BuscarRaza(num);
            this.cn.Delete<Citas>(num);
        }
    }
}
