﻿using Microsoft.AspNetCore.Http;
using EventGo.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventGo.Services
{
    public interface IActorRepository
    {
       
        int delete(int id);
        List<Actor> GetAll();
        Actor GetById(int id);
        Actor GetByName(string name);
     Task< int> insert(Actor newActor,List<IFormFile> Image);
        Task<int> update(Actor EditActor, int id, List<IFormFile> Image);
    }
}