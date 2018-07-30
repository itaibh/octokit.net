using System;

namespace Octokit.Reactive.Clients
{
    public interface IObservableApplicationClient
    {
        IObservable<Application> Create();
    }
}
