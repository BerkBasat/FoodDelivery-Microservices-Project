﻿using Ecommerce.Web.Models;

namespace Ecommerce.Web.Service.IService
{
    public interface ICartService
    {
        Task<ResponseDTO?> GetCartByUserIdAsync(string userId);
        Task<ResponseDTO?> UpsertCartAsync(CartDTO cartDTO);
        Task<ResponseDTO?> RemoveFromCartAsync(int cartDetailsId);
        Task<ResponseDTO?> ApplyCouponAsync(CartDTO cartDTO);
    }
}
