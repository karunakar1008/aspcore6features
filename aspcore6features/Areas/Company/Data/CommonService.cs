namespace aspcore6features.Areas.Company.Data
{
    public class CommonService : ICommonService
    {
        public string DisplayMessage(string name)
        {
            return $"Hi {name}, How are you doing?";
        }
    }
}
