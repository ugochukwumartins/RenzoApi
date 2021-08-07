using Renzorapi.Data.Model;
using Renzorapi.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Renzorapi.Data.Services
{
    public class PoemService
    {
        private AppDbContext _Context;
        public PoemService(AppDbContext context)
        {
            _Context = context;
        }
        public void AddPoem(PoemVm poem)
        {
            var _poem = new Poem()
            {
                Title = poem.Title,
                Catption = poem.Catption,
                Body = poem.Body,
                Dateadded = poem.Dateadded
            };
            _Context.Poems.Add(_poem);
            _Context.SaveChanges();

        }



        public List<Poem> GetAllPoem()
        {
            var allpoems = _Context.Poems.ToList();
            return allpoems;
        }

        public Poem GetPoemByID(int PoemId)
        {
            var allpoems = _Context.Poems.FirstOrDefault(id => id.id == PoemId);
            return allpoems;
        }

        public Poem UpdatePoem(int Poemid, PoemVm poem)
        {
            var _poem = _Context.Poems.FirstOrDefault(id => id.id == Poemid);
            if(_poem != null)
            {
                _poem.Title = poem.Title;
                _poem.Catption = poem.Catption;
                _poem.Body = poem.Body;
                _Context.SaveChanges();
            }

            return _poem;
        }

        public void DeletePoemById(int poemiD)
        {
            var _poem = _Context.Poems.FirstOrDefault(id => id.id == poemiD);
            if(_poem != null)
            {
                _Context.Poems.Remove(_poem);
                _Context.SaveChanges();
            }

        }
    }
}
