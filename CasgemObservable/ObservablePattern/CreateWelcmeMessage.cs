using CasgemObservable.Dal;

namespace CasgemObservable.ObservablePattern
{
    public class CreateWelcmeMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context =new Context();

        public CreateWelcmeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.WelcomeMessages.Add(new WelcomeMessage
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Content = "dergi bültnine üye oldduğunuz için tşk "
            });
            context.SaveChanges();
        }
    }
}
