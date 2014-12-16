using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace LearningCenter.PhonesWebApi.Models
{
    public class PhoneModel
    {
        public int Age { get; set; }
        public string Carrier { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Snippet { get; set; }

        public static ICollection<PhoneModel> GetAllPhones(string path)
        {
            var phones = new List<PhoneModel>
                   {
                       new PhoneModel
                       {
                           Age = 0,
                           Id = "motorola-xoom-with-wi-fi",
                           ImageUrl = "content/phones/motorola-xoom-with-wi-fi.0.jpg",
                           Name = "Motorola XOOM\u2122 with Wi-Fi",
                           Snippet =
                               "The Next, Next Generation\r\n\r\nExperience the future with Motorola XOOM with Wi-Fi, the world's first tablet powered by Android 3.0 (Honeycomb)."
                       },
                       new PhoneModel
                       {
                           Age = 1,
                           Id = "motorola-xoom",
                           ImageUrl = "content/phones/motorola-xoom.0.jpg",
                           Name = "MOTOROLA XOOM\u2122",
                           Snippet =
                               "The Next, Next Generation\n\nExperience the future with MOTOROLA XOOM, the world's first tablet powered by Android 3.0 (Honeycomb)."
                       },
                       new PhoneModel
                       {
                           Age = 2,
                           Carrier = "AT&amp;T",
                           Id = "motorola-atrix-4g",
                           ImageUrl = "content/phones/motorola-atrix-4g.0.jpg",
                           Name = "MOTOROLA ATRIX\u2122 4G",
                           Snippet =
                               "MOTOROLA ATRIX 4G the world's most powerful smartphone."
                       },
                       new PhoneModel
                       {
                           Age = 3,
                           Id = "dell-streak-7",
                           ImageUrl = "content/phones/dell-streak-7.0.jpg",
                           Name = "Dell Streak 7",
                           Snippet =
                               "Introducing Dell\u2122 Streak 7. Share photos, videos and movies together. It\u2019s small enough to carry around, big enough to gather around."
                       },
                       new PhoneModel
                       {
                           Age = 4,
                           Carrier = "Cellular South",
                           Id = "samsung-gem",
                           ImageUrl = "content/phones/samsung-gem.0.jpg",
                           Name = "Samsung Gem\u2122",
                           Snippet =
                               "The Samsung Gem\u2122 brings you everything that you would expect and more from a touch display smart phone \u2013 more apps, more features and a more affordable price."
                       },
                       new PhoneModel
                       {
                           Age = 5,
                           Carrier = "Dell",
                           Id = "dell-venue",
                           ImageUrl = "content/phones/dell-venue.0.jpg",
                           Name = "Dell Venue",
                           Snippet =
                               "The Dell Venue; Your Personal Express Lane to Everything"
                       },
                       new PhoneModel
                       {
                           Age = 6,
                           Carrier = "Best Buy",
                           Id = "nexus-s",
                           ImageUrl = "content/phones/nexus-s.0.jpg",
                           Name = "Nexus S",
                           Snippet =
                               "Fast just got faster with Nexus S. A pure Google experience, Nexus S is the first phone to run Gingerbread (Android 2.3), the fastest version of Android yet."
                       },
                       new PhoneModel
                       {
                           Age = 7,
                           Carrier = "Cellular South",
                           Id = "lg-axis",
                           ImageUrl = "content/phones/lg-axis.0.jpg",
                           Name = "LG Axis",
                           Snippet =
                               "Android Powered, Google Maps Navigation, 5 Customizable Home Screens"
                       },
                       new PhoneModel
                       {
                           Age = 8,
                           Id = "samsung-galaxy-tab",
                           ImageUrl = "content/phones/samsung-galaxy-tab.0.jpg",
                           Name = "Samsung Galaxy Tab\u2122",
                           Snippet =
                               "Feel Free to Tab\u2122. The Samsung Galaxy Tab\u2122 brings you an ultra-mobile entertainment experience through its 7\u201d display, high-power processor and Adobe\u00ae Flash\u00ae Player compatibility."
                       },
                       new PhoneModel
                       {
                           Age = 9,
                           Carrier = "Cellular South",
                           Id = "samsung-showcase-a-galaxy-s-phone",
                           ImageUrl = "content/phones/samsung-showcase-a-galaxy-s-phone.0.jpg",
                           Name = "Samsung Showcase\u2122 a Galaxy S\u2122 phone",
                           Snippet =
                               "The Samsung Showcase\u2122 delivers a cinema quality experience like you\u2019ve never seen before. Its innovative 4\u201d touch display technology provides rich picture brilliance, even outdoors"
                       },
                       new PhoneModel
                       {
                           Age = 10,
                           Carrier = "Verizon",
                           Id = "droid-2-global-by-motorola",
                           ImageUrl = "content/phones/droid-2-global-by-motorola.0.jpg",
                           Name = "DROID\u2122 2 Global by Motorola",
                           Snippet =
                               "The first smartphone with a 1.2 GHz processor and global capabilities."
                       },
                       new PhoneModel
                       {
                           Age = 11,
                           Carrier = "Verizon",
                           Id = "droid-pro-by-motorola",
                           ImageUrl = "content/phones/droid-pro-by-motorola.0.jpg",
                           Name = "DROID\u2122 Pro by Motorola",
                           Snippet = "The next generation of DOES."
                       },
                       new PhoneModel
                       {
                           Age = 12,
                           Carrier = "AT&amp;T",
                           Id = "motorola-bravo-with-motoblur",
                           ImageUrl = "content/phones/motorola-bravo-with-motoblur.0.jpg",
                           Name = "MOTOROLA BRAVO\u2122 with MOTOBLUR\u2122",
                           Snippet = "An experience to cheer about."
                       },
                       new PhoneModel
                       {
                           Age = 13,
                           Carrier = "T-Mobile",
                           Id = "motorola-defy-with-motoblur",
                           ImageUrl = "content/phones/motorola-defy-with-motoblur.0.jpg",
                           Name = "Motorola DEFY\u2122 with MOTOBLUR\u2122",
                           Snippet = "Are you ready for everything life throws your way?"
                       },
                       new PhoneModel
                       {
                           Age = 14,
                           Carrier = "T-Mobile",
                           Id = "t-mobile-mytouch-4g",
                           ImageUrl = "content/phones/t-mobile-mytouch-4g.0.jpg",
                           Name = "T-Mobile myTouch 4G",
                           Snippet =
                               "The T-Mobile myTouch 4G is a premium smartphone designed to deliver blazing fast 4G speeds so that you can video chat from practically anywhere, with or without Wi-Fi."
                       },
                       new PhoneModel
                       {
                           Age = 15,
                           Carrier = "US Cellular",
                           Id = "samsung-mesmerize-a-galaxy-s-phone",
                           ImageUrl = "content/phones/samsung-mesmerize-a-galaxy-s-phone.0.jpg",
                           Name = "Samsung Mesmerize\u2122 a Galaxy S\u2122 phone",
                           Snippet =
                               "The Samsung Mesmerize\u2122 delivers a cinema quality experience like you\u2019ve never seen before. Its innovative 4\u201d touch display technology provides rich picture brilliance,even outdoors"
                       },
                       new PhoneModel
                       {
                           Age = 16,
                           Carrier = "Sprint",
                           Id = "sanyo-zio",
                           ImageUrl = "content/phones/sanyo-zio.0.jpg",
                           Name = "SANYO ZIO",
                           Snippet =
                               "The Sanyo Zio by Kyocera is an Android smartphone with a combination of ultra-sleek styling, strong performance and unprecedented value."
                       },
                       new PhoneModel
                       {
                           Age = 17,
                           Id = "samsung-transform",
                           ImageUrl = "content/phones/samsung-transform.0.jpg",
                           Name = "Samsung Transform\u2122",
                           Snippet =
                               "The Samsung Transform\u2122 brings you a fun way to customize your Android powered touch screen phone to just the way you like it through your favorite themed \u201cSprint ID Service Pack\u201d."
                       },
                       new PhoneModel
                       {
                           Age = 18,
                           Id = "t-mobile-g2",
                           ImageUrl = "content/phones/t-mobile-g2.0.jpg",
                           Name = "T-Mobile G2",
                           Snippet =
                               "The T-Mobile G2 with Google is the first smartphone built for 4G speeds on T-Mobile's new network. Get the information you need, faster than you ever thought possible."
                       },
                       new PhoneModel
                       {
                           Age = 19,
                           Id = "motorola-charm-with-motoblur",
                           ImageUrl = "content/phones/motorola-charm-with-motoblur.0.jpg",
                           Name = "Motorola CHARM\u2122 with MOTOBLUR\u2122",
                           Snippet =
                               "Motorola CHARM fits easily in your pocket or palm.  Includes MOTOBLUR service."
                       }
                   };

            foreach (var phone in phones)
            {
                phone.ImageUrl = string.Format("{0}/{1}", path, phone.ImageUrl);
            }

            return phones;
        }
    }
}