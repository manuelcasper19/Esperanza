namespace Esperanza.API.UseCases.Interfaces
{
    public interface IUseCaseWithName<T> : IBaseUseCase<T>
    {
        T Execute(string name);
    }
}
