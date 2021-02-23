using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace TuFarmaApp.Models
{
    public class ProductModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [JsonIgnore]
        private string mainImage = "";

        public List<JObject> extras { get; set; }

        //[JsonProperty("subcategory")]
        //public Subcategory Subcategory { get; set; }

        //[JsonProperty("category")]
        //public Category Category { get; set; }

        [JsonIgnore]
        public string MainImage
        {
            get
            {
                if (Pictures.Any())
                {
                    return Pictures[0];
                }
                return mainImage;
            }
        }
        public string Thumbnail { get; set; }

        //[JsonIgnore]
        //public Color TimeLineColor
        //{
        //    get;
        //    set;
        //}

        [JsonIgnore]
        public int Index
        {
            get;
            set;
        }

        //stars
        [JsonProperty("stars")]
        public string product_review_points
        {
            get;
            set;
        }

        //id
        [JsonProperty("id")]
        public string product_key
        {
            get;
            set;
        }

        //name
        [JsonProperty("name")]
        public string Title
        {
            get;
            set;
        }

        //description
        [JsonProperty("description")]
        public string Description
        {
            get;
            set;
        }

        public string short_description { get; set; }
        //price
        [JsonProperty("price")]
        public string Price
        {
            get;
            set;
        }

        //username
        [JsonProperty("username")]
        public string Seller
        {
            get;
            set;
        }

        //status
        [JsonProperty("status")]
        public string Status
        {
            get;
            set;
        }

        //pictures
        [JsonProperty("pictures")]
        public List<string> Pictures
        {
            get;
            set;
        }

        public string NameReaccion
        {
            get;
            set;
        }

        public ImageSource MeGustaWhite
        {
            get;
            set;
        }

        public int IndexEmoji
        {
            get;
            set;
        }

        public bool visibleEmojisGusta
        {
            get;
            set;
        }

        public bool visibleEmojisEncanta
        {
            get;
            set;
        }

        public bool visibleEmojisImporta
        {
            get;
            set;
        }

        public bool visibleEmojisDivierte
        {
            get;
            set;
        }

        public bool visibleEmojisSorpresa
        {
            get;
            set;
        }

        public bool visibleEmojisGustaEscogido
        {
            get;
            set;
        }

        public bool visibleEmojisBuenPrecio
        {
            get;
            set;
        }

        public bool activoEmojis
        {
            get;
            set;
        }

        public int ContMeGusta
        {
            get;
            set;
        }

        public int ContMeEncanta
        {
            get;
            set;
        }

        public int ContMeImporta
        {
            get;
            set;
        }

        public int ContMeDivierte
        {
            get;
            set;
        }

        public int ContMeSorprende
        {
            get;
            set;
        }

        public int TotalReacciones
        {
            get;
            set;
        }

        public bool visibleContadorGusta
        {
            get;
            set;
        }

        public bool visibleContadorEncanta
        {
            get;
            set;
        }

        public bool visibleContadorImporta
        {
            get;
            set;
        }

        public bool visibleContadorDivierte
        {
            get;
            set;
        }

        public bool visibleContadorSorprende
        {
            get;
            set;
        }

        public bool visibleContadorBuenPrecio
        {
            get;
            set;
        }

        public bool visibleContador
        {
            get;
            set;
        }

        public bool visibleNameReaction
        {
            get;
            set;
        }

        public bool ejecutandose
        {
            get;
            set;
        }

        //public List<Carousel> CarouselOne
        //{
        //    get;
        //    set;
        //}

        //public StoreData storeData { get; set; }

        [JsonIgnore]
        public bool IsBusy { get; set; }

        [JsonProperty("isFavorite")]
        public bool IsFavorite
        {
            get;
            set;
        }
    }
}
