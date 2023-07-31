using CasgemObservable.Dal;

namespace CasgemObservable.ObservablePattern
{
    public interface IObserver
    {
        void CreateNewUser(AppUser appUser);
    }
}
