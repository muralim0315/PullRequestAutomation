using SeleniumExtras.PageObjects;


namespace AutomationFramework.Base
{
    public class Base
    {
       

        /// <summary>
        /// Initializes page objects in page object model
        /// </summary>
        /// <typeparam name="TPage"></typeparam>
        /// <returns></returns>


        protected TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            TPage pageInstance = new TPage();
            PageFactory.InitElements(DriverContext.Driver, pageInstance);
            return pageInstance;
        }

        /// <summary>
        /// Just for readability purpose
        /// </summary>
        /// <typeparam name="TPage"></typeparam>
        /// <returns></returns>
        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }


       
    }
}
