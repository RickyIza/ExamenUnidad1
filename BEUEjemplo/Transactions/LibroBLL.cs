using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEUEjemplo.Transactions
{
    public class LibroBLL
    {
        public static void Create(Libro a)
        {
            using (Entities db = new Entities())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Libro.Add(a);
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static Libro Get(int? id)
        {
            Entities db = new Entities();
            return db.Libro.Find(id);
        }

        public static void Update(Libro libro)
        {
            using (Entities db = new Entities())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Libro.Attach(libro);
                        db.Entry(libro).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static void Delete(int? id)
        {
            using (Entities db = new Entities())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        Libro libro = db.Libro.Find(id);
                        db.Entry(libro).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static List<Libro> List()
        {
            Entities db = new Entities();

            return db.Libro.ToList();

          
        }


        private static List<Libro> GetLibros(string criterio)
        {
            Entities db = new Entities();
            return db.Libro.Where(x => x.titulo.ToLower().Contains(criterio)).ToList();
        }

        private static Libro GetLIbro(string cedula)
        {
            Entities db = new Entities();
            return db.Libro.FirstOrDefault(x => x.autores == cedula);
        }


    }
}
