namespace BarberBoss.Exception.ExceptionsBase
{
    public abstract class BarberBossException : SystemException
    {
        protected BarberBossException(string message) : base(message) { }
    }
}
