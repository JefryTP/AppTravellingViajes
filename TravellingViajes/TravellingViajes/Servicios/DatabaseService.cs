using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using TravellingViajes.Modelos;

namespace TravellingViajes.Servicios
{
    internal class DatabaseService
    {
        readonly SQLiteConnection _database;

        public DatabaseService(string dbPath)
        {
            _database = new SQLiteConnection(dbPath);
            _database.CreateTable<Usuario>();
            _database.CreateTable<Viaje>();
        }
        public void GuardarViaje(Viaje viaje)
        {
            _database.Insert(viaje);
        }
        public List<Viaje> ObtenerViajes()
        {
            return _database.Table<Viaje>().ToList();
        }
        public List<Usuario> ObtenerUsuarios()
        {
            return _database.Table<Usuario>().ToList();
        }
        public Usuario ObtenerUsuarioPorId(int id)
        {
            return _database.Table<Usuario>().FirstOrDefault(u => u.Id == id);
        }
        public void GuardarUsuario(Usuario usuario)
        {
            _database.Insert(usuario);
        }
        public void ActualizarUsuario(Usuario usuario)
        {
            _database.Update(usuario);
        }

        public Usuario ObtenerUsuarioPorCorreo(string correo)
        {
            return _database.Table<Usuario>().FirstOrDefault(u => u.Correo == correo);
        }
        
    }
}
