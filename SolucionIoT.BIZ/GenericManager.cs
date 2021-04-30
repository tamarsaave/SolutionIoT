using solucionIoT.COMMON.Entidades;
using solucionIoT.COMMON.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolucionIoT.BIZ
{
    public abstract class GenericManager<T> : IGenericManager<T> where T : BaseDTO
    {
        internal IGenericRepository<T> repository;
        public GenericManager(IGenericRepository<T>repository) 
        {
            this.repository = repository;
        }
        public IEnumerable<T> ObtenerTodo => repository.Read;

        public string Error => repository.Error;

        public T Actualizar(T entidad)
        {
            return repository.Update(entidad);   
        }

        public T BuscarPorId(string id)
        {
            return repository.SearchById(id);
        }

        public bool Eliminar(string id)
        {
            return repository.Delete(id);
        }

        public T Insertar(T entidad)
        {
            return repository.Create(entidad);
        }
    }
}
