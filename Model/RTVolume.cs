using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Model
{
    public class RTVolume
    {
        [Key]
        public int Tick_Id { get; set; }
        [Required]
        public int Ticker_Id { get; set; }
        [Required]
        [Column(TypeName = "decimal")]
        public decimal Price { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int LastTradeSize { get; set; }
        /*** miliseconds from 1/1/1970 GMT ***/
        [Required]
        [Column(TypeName = "bigint")]
        public long LastTradeTime { get; set; }
        [Required]
        [Column(TypeName = "bigint")]
        public long Volumn { get; set; }
        [Required]
        [Column(TypeName = "decimal")]
        public decimal VWAP { get; set; }
        [Required]
        [Column(TypeName = "bit")]
        public bool Single_Trade_Flag { get; set; }
        [Required]
        public long TimeStamp { get; set; }
    }
}
