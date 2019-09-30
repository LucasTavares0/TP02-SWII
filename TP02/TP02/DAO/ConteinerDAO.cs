using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP02.Models;

namespace TP02.DAO
{
    public class ConteinerDAO
    {
        public void Adiciona(Container container)
        {
            using (var context = new ListagemContext())
            {
                context.Containeres.Add(container);
                context.SaveChanges();
            }
        }

        public IList<Container> Lista()
        {
            using (var context = new ListagemContext())
            {
                return context.Containeres.Include("BL").ToList();
            }
        }

        public Container BuscaPorId(int id)
        {
            using (var context = new ListagemContext())
            {
                return context.Containeres.Include("BL").Where(p => p.Id == id).FirstOrDefault();
            }
        }

        public void Atualiza(Container container)
        {
            using (var context = new ListagemContext())
            {
                context.Entry(container).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Exclui(int id)
        {
            using (var context = new ListagemContext())
            {
                Container container = context.Containeres.Include("BL").Where(p => p.Id == id).FirstOrDefault();
                context.Containeres.Remove(container);
                context.SaveChanges();
            }
        }
    }
}