namespace AutomationFramework.Base
{
    public abstract class BasePage : Base
    {
        protected virtual string PageUrl { get; }
        protected virtual string PageTitle { get; }
        public BasePage()
        {
           
        }      

    }
}
