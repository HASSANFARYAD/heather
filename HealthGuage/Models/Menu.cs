﻿using Template.Models;

namespace HealthGuage.Models
{
    public class Menu : BaseModel
    {
        public string? Name { get; set; }
        public DateTime? Date { get; set; }
        public string? Photo { get; set; }
        public string? Cooking { get; set; }
        public string? Weight { get; set; }
        public string? Link { get; set; }
        public string? PreperationForBeaorStaff { get; set; }
        public int? CategoryId { get; set; }
        public int? MenuTypeId { get; set; }
        public string? Notes { get; set; }
        public List<MenuIngredient?> MenuIngredient { get; set; }
        public List<MenuPreperation?> MenuPreperation { get; set; }
        public List<MenuProduct?> MenuProduct { get; set; }
    }
}
