using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Navigation
{
    public class Class2
    {
        public ObservableCollection<Class1> Inta { get; set; }

        public Class2()
        {
            Inta = new ObservableCollection<Class1>();
            Inta.Add(new Class1 { image = "https://anhdephd.com/wp-content/uploads/2019/10/anh-dai-dien-avatar-dep-facebook.jpg", name = "Nguyen Viet Duc", noidung = "Duc da like anh cua ban", thongtin = "my name is Duc sky" });
            Inta.Add(new Class1 { image = "https://taimienphi.vn/tmp/cf/aut/mAKI-top-anh-dai-dien-dep-chat-1.jpg", name = "Nguyen Viet Duc", noidung = "Duc da like anh cua ban", thongtin = "my name is Duc sky" });
            Inta.Add(new Class1 { image = "https://taimienphi.vn/tmp/cf/aut/mAKI-top-anh-dai-dien-dep-chat-1.jpg", name = "Nguyen Viet Duc", noidung = "Duc da like anh cua ban", thongtin = "my name is Duc sky" });
            Inta.Add(new Class1 { image = "https://taimienphi.vn/tmp/cf/aut/mAKI-top-anh-dai-dien-dep-chat-1.jpg", name = "Nguyen Viet Duc", noidung = "Duc da like anh cua ban", thongtin = "my name is Duc sky" });
            Inta.Add(new Class1 { image = "https://taimienphi.vn/tmp/cf/aut/mAKI-top-anh-dai-dien-dep-chat-1.jpg", name = "Nguyen Viet Duc", noidung = "Duc da like anh cua ban", thongtin = "my name is Duc sky" });
            Inta.Add(new Class1 { image = "https://taimienphi.vn/tmp/cf/aut/mAKI-top-anh-dai-dien-dep-chat-1.jpg", name = "Nguyen Viet Duc", noidung = "Duc da like anh cua ban", thongtin = "my name is Duc sky" });
            Inta.Add(new Class1 { image = "https://taimienphi.vn/tmp/cf/aut/mAKI-top-anh-dai-dien-dep-chat-1.jpg", name = "Nguyen Viet Duc", noidung = "Duc da like anh cua ban", thongtin = "my name is Duc sky" });
        }

    }
}
