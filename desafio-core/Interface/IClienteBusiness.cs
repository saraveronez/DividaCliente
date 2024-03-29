using desafio_core.Model;
using desafio_core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace desafio_core.Interface
{
    public interface IClienteBusiness
    {
        public Task<bool> Criar(ClienteViewModel vm);
        public Task<List<ClienteViewModel>> GetAll();
    }
}
