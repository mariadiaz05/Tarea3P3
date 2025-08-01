public void EditarUsuario(int id, string nuevoNombre, string nuevoCorreo)
{
    var usuario = usuarios.FirstOrDefault(u => u.Id == id);
    if (usuario == null)
    {
        Console.WriteLine(" Usuario no encontrado.");
        return;
    }

    usuario.Nombre = nuevoNombre;
    usuario.Correo = nuevoCorreo;
    Console.WriteLine(" Usuario actualizado correctamente.");
}
