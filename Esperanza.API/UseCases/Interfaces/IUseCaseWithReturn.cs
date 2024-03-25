namespace Esperanza.API.UseCases.Interfaces
{
    public interface IUseCaseWithReturn<T> : IBaseUseCase<T>
    {
     T Execute();
    }
}
