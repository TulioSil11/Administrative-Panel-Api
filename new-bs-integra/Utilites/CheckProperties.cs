namespace new_bs_integra.Utilites
{
    public static class CheckProperties
    {
        public static bool  ItsNull <T>(T model) =>
            typeof(T).GetProperties()
                     .All(a => a
                     .GetValue(model) != null);
    }
}
