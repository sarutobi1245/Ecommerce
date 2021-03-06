using System;

namespace ecommerce_api.Data.Interface
{
     public interface IDateTracking
    {
        DateTime CreatedTime { get; set; }
        DateTime? DeletedTime { get; set; }
        DateTime? UpdatedTime { get; set; }
    }
}