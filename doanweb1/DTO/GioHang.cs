namespace doanweb1.DTO
{
    public class GioHang
    {
        public GioHang() {
            CardItem = new List<card_item>();
        }

        public List<card_item> CardItem { get; set; }

        public float price { get; set; }
    }
}
