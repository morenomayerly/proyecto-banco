namespace aplication.Behaviours
{
    public interface IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
    }
}