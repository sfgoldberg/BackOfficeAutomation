namespace Back_Office_Automation.Objects
{
    class Page
    {
        public static string PageTitle()
        {
            {
                //gets and returns the page title as a string

                var title = Driver.Instance.Title;

                return title;
            }
        }

    }
}
