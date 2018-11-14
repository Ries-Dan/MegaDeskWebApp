using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWebApp.Models
{
    public class DeskQuote
    {
        // eNum for DeskMaterial
        public enum DeskMaterial
        {
            oak      = 200,
            laminate = 100,
            pine     = 50,
            rosewood = 300,
            veneer   = 125
        }

        // MEMBER VARIABLES
        // ID
        public int ID { get; set; }

        // CustName
        [Display(Name = "Customer Name")]
        [RegularExpression(@"^[a-zA-Z""'\s-]*$")]
        [Required]
        public string CustName { get; set; }

        // Width
        [Range(DESK_WIDTH_MIN, DESK_WIDTH_MAX)]
        [Display(Name = "Width")]
        [RegularExpression(@"^[0-9]*$")]
        [Required]
        public int DeskWidth { get; set; }

        // Depth
        [Range(DESK_DEPTH_MIN, DESK_DEPTH_MAX)]
        [Display(Name = "Depth")]
        [RegularExpression(@"^[0-9]*$")]
        [Required]
        public int DeskDepth { get; set; }

        // Drawers
        [Range(DESK_DRAWERS_MIN, DESK_DRAWERS_MAX)]
        [Display(Name = "Drawers")]
        [RegularExpression(@"^[0-9]*$")]
        [Required]
        public int DeskDrawers { get; set; }

        // Material
        [EnumDataType(typeof(DeskMaterial), ErrorMessage = "Invalid desk material")]
        [Required]
        public DeskMaterial Material;

        // RushDays
        [Display(Name = "Rush Days")]
        [RegularExpression(@"^[0-9]*$")]
        [Required]
        public int RushDays { get; set; }

        // QuoteDate - this is populated by the program
        [Display(Name = "Quote Date")]
        [DataType(DataType.Date)]
        public DateTime DeskQuoteDate { get; set; }

        // QuoteTotal - this is popualted by the program
        [Display(Name = "Quote Total")]
        [DataType(DataType.Currency)]
        public int DeskQuoteTotal { get; set; }

        // CONSTANTS
        public const int DESK_WIDTH_MIN      = 24;
        public const int DESK_WIDTH_MAX      = 96;
        public const int DESK_DEPTH_MIN      = 12;
        public const int DESK_DEPTH_MAX      = 48;
        public const int DESK_DRAWERS_MIN    = 0;
        public const int DESK_DRAWERS_MAX    = 7;
        public const int DESK_BASE_PRICE     = 200;
        public const int DESK_AREA_THRESHOLD = 1000;
        public const int DESK_AREA_PRICE     = 1;
        public const int DESK_DRAWER_PRICE   = 50;

        // METHODS
        public void CalculateQuote()
        {
            // Start with base desk price and calcuate area
            int totalQuote = DESK_BASE_PRICE;
            int deskArea = DeskDepth * DeskWidth;

            // Determine additional desk area cost, if any
            if (deskArea > DESK_AREA_THRESHOLD)
                totalQuote += (deskArea - DESK_AREA_THRESHOLD) * DESK_AREA_PRICE;

            // Determine drawer cost
            totalQuote += DeskDrawers * DESK_DRAWER_PRICE;

            // Determine material cost
            totalQuote += (int)Material;

            // Determine rush order cost
            // Determine rush order cost by rush days - 14 days has no additional cost
            switch (RushDays)
            {
                // 3 day rush order
                case 3:
                    // desk area less than 1000
                    if (deskArea < 1000)
                        totalQuote += 60;
                    // desk area 1000 to 2000
                    else if (deskArea >= 1000 && deskArea <= 2000)
                        totalQuote += 70;
                    // desk area greater than 2000
                    else
                        totalQuote += 80;
                    break;
                // 5 day rush order
                case 5:
                    // desk area less than 1000
                    if (deskArea < 1000)
                        totalQuote += 40;
                    // desk area 1000 to 2000
                    else if (deskArea >= 1000 && deskArea <= 2000)
                        totalQuote += 50;
                    // desk area greater than 2000
                    else
                        totalQuote += 60;
                    break;
                // 7 day rush order
                case 7:
                    // desk area less than 1000
                    if (deskArea < 1000)
                        totalQuote += 30;
                    // desk area 1000 to 2000
                    else if (deskArea >= 1000 && deskArea <= 2000)
                        totalQuote += 35;
                    // desk area greater than 2000
                    else
                        totalQuote += 40;
                    break;
            }
            
            // trying to get it only add a date if one does not exist. does not seem to be pulling the date form the database right.
            /*
            if (DeskQuoteDate == null)
            {
                DeskQuoteDate = DateTime.Now;
            }
            else
            {
                DeskQuoteDate = DeskQuoteDate;
            }
            */

            // End of method. Quote should be calculated at this point.
            DeskQuoteTotal = totalQuote;
        }
    }
}
