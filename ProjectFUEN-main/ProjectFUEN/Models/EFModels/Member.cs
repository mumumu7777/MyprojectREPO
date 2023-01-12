﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ProjectFUEN.Models.EFModels
{
    public partial class Member
    {
        public Member()
        {
            ActivityCollections = new HashSet<ActivityCollection>();
            ActivityMembers = new HashSet<ActivityMember>();
            Albums = new HashSet<Album>();
            OrderDetails = new HashSet<OrderDetail>();
            Photos = new HashSet<Photo>();
            Questions = new HashSet<Question>();
            ShoppingCarts = new HashSet<ShoppingCart>();
            Coupons = new HashSet<Coupon>();
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string EmailAccount { get; set; }
        public string EncryptedPassword { get; set; }
        public string RealName { get; set; }
        public string NickName { get; set; }
        public DateTime? BirthOfDate { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string PhotoSticker { get; set; }
        public string About { get; set; }
        public string ConfirmCode { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsInBlackList { get; set; }

        public virtual ICollection<ActivityCollection> ActivityCollections { get; set; }
        public virtual ICollection<ActivityMember> ActivityMembers { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }

        public virtual ICollection<Coupon> Coupons { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}