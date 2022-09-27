namespace new_bs_integra.Utilitiess
{
    public class PaginationResponse<T>
    {
        public int? Total { get; set; }
        public IEnumerable<T> Data { get; set; }
        public double? TotalPage { get; set; }

        public PaginationResponse(IEnumerable<T> data, int? i, int? len)
        {
            if (data != null)
            {
                Total = data.Count();
                Data = data.Skip((int)((i - 1) * len)).Take((int)len).ToList();
                TotalPage = Math.Ceiling((double)((double)data.Count() / len));

            }
        }
    }
}
