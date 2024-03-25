﻿using System.Text.RegularExpressions;

namespace Esperanza.API.Helpers
{
    public static class ValidateDataInput
    {
        public static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }
        public static bool IsValidPassword(string password)
        {
            return password.Length > 5;
        }
        public static bool IsFullnameValid(string nombre)
        {
            string nombrePattern = @"^[a-zA-Z]{3,}(?: [a-zA-Z]{3,})*$";
            return Regex.IsMatch(nombre, nombrePattern);
        }
        public static void ValidateField<T>(T field, Func<T, bool> validationMethod)
        {
            //if (field == null)
            //{
            //    throw new ArgumentNullException(nameof(field), "El campo no puede ser nulo.");
            //}
            //if (field is string && string.IsNullOrWhiteSpace((string)(object)field))
            //{
            //    throw new ArgumentException("El campo no puede estar vacío.");
            //}
            if (!validationMethod(field))
            {
                throw new ArgumentException($"El campo {nameof(field)} no es correcto, por favor vuelva a intentarlo");
            }
        }
    }
}
