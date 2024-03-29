﻿using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string AttackCannotLogged = "Attack loglanamadı";

        public static string UserAdded = "Kullanıcı eklendi";

        public static string UserDeleted = "Kullanıcı silindi";

        public static string UserUpdated = "Kullanıcı güncellendi";

        public static string SystemInMaintenance = "Sistem bakımda";

        public static string DailyPriceNotExists = "Günlük fiyat alanı boş bırakılamaz";

        public static string InvalidPrice = "Günlük fiyat 0 olamaz";

        public static string RentDetailsListed = "Kiralama detayları listelendi";

        public static string BrandRequired = "Araba eklemek için marka gereklidir";

        public static string ImageAdded = "Resim eklendi";

        public static string ImageDeleted = "Resim silindi";

        public static string ImageUpdated = "Resim güncellendi";

        public static string ImageAdditionFailed = "Resim ekleme başarısız oldu";

        public static string CarDoesntExists = "Bu id'ye ait bir araba bulunmamaktadır";

        public static string AuthorizationDenied = "Yetkiniz yok...";

        public static string UserRegistered = "Kayıt oldu";

        public static string UserNotFound = "Kullanıcı bulunamadı";

        public static string PasswordError = "Parola hatası";

        public static string SuccessfulLogin = "Başarılı giriş";

        public static string UserAlreadyExists = "Kullanıcı veritabanında mevcut";

        public static string AccessTokenCreated = "Token verildi";

        public static string SamePassword = "Değiştirmek istediğiniz parola zaten kullanılıyor";
    }
}