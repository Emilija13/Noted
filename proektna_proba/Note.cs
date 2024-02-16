using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace proektna_proba
{
    [Serializable]
    public class Note : Comparer<Note>, ISerializable
    {
        public static int counter = 0;
        public int ID { get; set; } = 0;
        public String Title { get; set; }
        public Color Color { get; set; } = Color.Black;
        public string RichTextBoxRtf { get; set; }
        public DateTime DateTime { get; set; }
        public bool Favorite { get; set; } = false;
        public String Category { get; set; }

        public static BindingList<String> categories = new BindingList<String> {"All Notes"};

        public Dictionary<string, string> Hyperlinks = new Dictionary<string, string>();

       public Note(string title, Color color, string richTextBoxRtf, bool favorite,
           string category, Dictionary<string, string> hyperlinks)
        {
            Title = title;
            Color = color;
            this.RichTextBoxRtf = richTextBoxRtf;
            DateTime = DateTime.Now;
            this.Favorite = favorite;
            ID = counter++;
            Category = category;
            Hyperlinks = hyperlinks;
        }


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Title", Title);
            info.AddValue("Color", Color);
            info.AddValue("Note Content", RichTextBoxRtf);
            info.AddValue("Last modified", DateTime);
            info.AddValue("Favorite", Favorite);
            info.AddValue("ID", ID);
            info.AddValue("Counter", counter);
            info.AddValue("Category", Category);
            info.AddValue("Categories", categories);
            info.AddValue("Hyperlinks", Hyperlinks);
        }

        public override int Compare(Note x, Note y)
        {
            if(x.Favorite == true && y.Favorite == false)
            {
                return -1;
            }
            else if (x.Favorite == false && y.Favorite == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public Note(SerializationInfo info, StreamingContext context)
        {
            Title =(string) info.GetValue("Title", typeof(string));
            Color = (Color)info.GetValue("Color", typeof(Color));
            RichTextBoxRtf = (string)info.GetValue("Note Content", typeof(string));
            DateTime = (DateTime)info.GetValue("Last modified", typeof(DateTime));
            Favorite = (bool)info.GetValue("Favorite", typeof(bool));
            ID = (int)info.GetValue("ID", typeof(int));
            counter = (int)info.GetValue("Counter", typeof(int));
            Category = (string)info.GetValue("Category", typeof(string));
            categories = (BindingList<string>)info.GetValue("Categories", typeof(BindingList<string>));
            Hyperlinks = (Dictionary<string, string>)info.GetValue("Hyperlinks", typeof(Dictionary<string, string>));
        }
    }
}
