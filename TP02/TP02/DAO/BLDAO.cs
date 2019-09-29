using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP02.Models;

namespace TP02.DAO
{
    public class BLDAO
    {
        public void Adiciona(BL Bl)
        {
            using (var context = new ListagemContext())
            {
                context.Bls.Add(Bl);
                context.SaveChanges();
            }
        }

        public IList<BL> Lista()
        {
            using (var context = new ListagemContext())
            {
                return context.Bls.ToList();
            }
        }

        public BL BuscaPorId(int id)
        {
            using (var context = new ListagemContext())
            {
                return context.Bls.Where(p => p.Id == id).FirstOrDefault();
            }
        }

        public void Atualiza(BL Bl)
        {
            using (var context = new ListagemContext())
            {
                context.Entry(Bl).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Exclui(BL bl)
        {
            using (var context = new ListagemContext())
            {
                context.Bls.Remove(bl);
                context.SaveChanges();
            }
        }
    }
}