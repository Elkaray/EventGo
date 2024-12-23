﻿using Microsoft.AspNetCore.Http;
using EventGo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventGo.Services
{
    public interface ICategoryRepository
    {

        int delete(int id);
        List<Category> GetAll();
        Category GetById(int id);
        Category GetByName(string name);
        Task<int> insert(Category newCinema,List<IFormFile> Image);
        Task<int> update(Category editMovie, List< IFormFile> Image);
        

    }
}
