namespace Esperanza.API.UseCases.Interfaces
{
    public interface IUseCaseWithParameter<T> : IBaseUseCase<T>
    {
        T Execute(T t);
    }
}
