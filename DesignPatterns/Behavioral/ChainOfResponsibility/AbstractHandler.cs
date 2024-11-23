namespace Behavioral.ChainOfResponsibility
{
    internal abstract class AbstractHandler : IHandler
    {
        private IHandler? _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;

            // Returning a handler from here will let us link handlers in a
            // convenient way like this:
            // monkey.SetNext(squirrel).SetNext(dog);
            return handler;
        }

        public virtual object? Handle(object request)
        {
            return _nextHandler != null ? _nextHandler.Handle(request) : null;
        }
    }
}
