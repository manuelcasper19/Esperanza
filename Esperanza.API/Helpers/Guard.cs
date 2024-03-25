namespace Universidad.Console.Helpers
{
    public static class Guard
    {
        public static void AgainstNullOrEmpty(string value, string paramName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("El valor no puede ser nulo o vacio", paramName);
            }
        }

        public static void AgainstNull(object value, string paramName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(paramName, "El valor no puede ser nulo");
            }

        }
    }
}