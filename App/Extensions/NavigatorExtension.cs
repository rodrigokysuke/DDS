namespace App.Extensions
{
    internal static class NavigatorExtension
    {
        internal static void Navigate(this Form windowFrom, Type windowTo)
        {
            var newWindow = Activator.CreateInstance(windowTo);
            if (newWindow != null)
                ((Form)newWindow).Show();
            windowFrom.Hide();
        }
    }
}
