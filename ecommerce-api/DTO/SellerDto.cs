using System;

namespace ecommerce_api.DTO
{
    public class SellerDto
    {
        public SellerDto()
        {
            Created_at = DateTime.Now;
        }
        
        public int ID { get; set; }
        public int User_ID { get; set; }
        public int Verification_status { get; set; }
        public string Verification_info { get; set; }
        public int Cash_on_delivery_status { get; set; }
        public double Admin_to_pay { get; set; }
        public string Bank_name { get; set; }
        public string Bank_acc_name { get; set; }
        public string Bank_acc_no { get; set; }
        public int Bank_routing_no { get; set; }
        public int Bank_payment_status { get; set; }

        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
    }
}