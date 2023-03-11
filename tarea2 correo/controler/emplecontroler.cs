using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using tarea2_correo.model;

namespace tarea2_correo.controler
{
    public class emplecontroler
    {
        readonly SQLiteAsyncConnection _connection;
        //contructor de la clase
        public emplecontroler(string DBPath) 
        {
            
            _connection= new SQLiteAsyncConnection(DBPath); 
            _connection.CreateTableAsync<model.Empleado>();
        }

       // public Task<int> SaveEmple(model.Empleado empleado)
       public Task<int> SaveEmple(model.Empleado empleado)
        {
            if (empleado.id != 0)
                return _connection.UpdateAsync(empleado);
           else 
            return _connection.InsertAsync(empleado);
        }
        public Task<model.Empleado> GetEmpleado(int pid)
        {
            return _connection.Table<model.Empleado>()
                .Where(i => i.id == pid)
                .FirstOrDefaultAsync();
        }

        public Task<List<model.Empleado>> GetListEmple()
        {
            return _connection.Table<model.Empleado>().ToListAsync();
        }
        public Task<int> DeleteEmple(model.Empleado empleado)
        {
            return _connection.DeleteAsync(empleado);
        }
    }
}
