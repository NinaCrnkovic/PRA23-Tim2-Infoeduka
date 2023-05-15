namespace Utilities
{
    public class Utility
    {

        private static Random random = new();
        private const string DATE_FORMAT = "dd.MM.yyyy. hh:mm";


        //poziv za otvarenje linka algebre
        public static void VisitLink(string url)
        {
            //This will make it behave more like just typing it in the 'Run' window:

            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public static int GenerateRandomId()
        {
           
            int id = random.Next(100000, 999999);
            return id;
        }
        public static DateTime GetDateTime(string dateTime)
        {

            DateTime input = DateTime.ParseExact(dateTime, DATE_FORMAT, null);
            return input;

        }


        //Metoda za provjeru upisanog emaila / username na loginu
        public static bool IsUsernameValid(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return false;
            }

            int atIndex = username.IndexOf('@');
            if (atIndex < 1 || atIndex != username.LastIndexOf('@'))
            {
                return false;
            }

            string localPart = username.Substring(0, atIndex);
            string domainPart = username.Substring(atIndex + 1);
            if (string.IsNullOrWhiteSpace(localPart) || string.IsNullOrWhiteSpace(domainPart))
            {
                return false;
            }

            if (domainPart.IndexOf('.') < 1 || domainPart.LastIndexOf('.') == domainPart.Length - 1)
            {
                return false;
            }

            if (username.Length < 5)
            {
                return false;
            }

            return true;
        }

        public static bool IsTextValid(string tekst)
        {
            if (string.IsNullOrWhiteSpace(tekst))
            {
                // Tekst je prazan ili sadrži samo razmake
                return false;
            }
            else if (tekst.Length < 2)
            {
                // Tekst je prekratak
                return false;
            }
            else
            {
                // Tekst je ispravan
                return true;
            }
        }

        public static bool IsEctsValid(string tekst)
        {
            if (int.TryParse(tekst, out int broj))
            {
                // Tekst je uspješno pretvoren u broj
                if (broj >= 1 && broj <= 10)
                {
                    // Broj je unutar raspona
                    return true;
                }
            }
            // Tekst nije broj ili nije u zadanom rasponu
            return false;
        }

    }
}