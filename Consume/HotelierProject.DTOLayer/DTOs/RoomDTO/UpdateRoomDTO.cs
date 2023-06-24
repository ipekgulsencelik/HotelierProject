﻿using System.ComponentModel.DataAnnotations;

namespace HotelierProject.DTOLayer.DTOs.RoomDTO
{
    public class UpdateRoomDTO
    {
        public int RoomID { get; set; }

        [Required(ErrorMessage = "Lütfen oda numarasını yazınız")]
        public string RoomNumber { get; set; }


        [Required(ErrorMessage = "Lütfen oda görseli giriniz")]
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Lütfen fiyat bilgisi giriniz")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen oda başlığı bilgisi giriniz")]
        [StringLength(100, ErrorMessage = "Lütfen en fazla 100 karater veri girişi yapınız")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen yatak sayısı giriniz")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Lütfen banyo sayısı giriniz")]
        public string BathCount { get; set; }

        public string? WiFi { get; set; }

        [Required(ErrorMessage = "Lütfen açıklamayı yazınız")]
        public string? Description { get; set; }
    }
}