using System;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace Faker.Net.Engine
{
    public class EmailAddress
    {
        public static string EmailString() => EmailFill[new Random().Next(1, EmailFill.Length)];

        private static string[] EmailFill { get; } = new string[]
        {
            "world@me.com","alias@outlook.com","bhtower@outlook.com","graham@mac.com","danzigism@sbcglobal.net","hutton@me.com","slanglois@live.com","skaufman@aol.com","research@icloud.com","tskirvin@sbcglobal.net","kingma@gmail.com","eimear@verizon.net","irving@gmail.com","heckerman@live.com","nimaclea@verizon.net","bowmanbs@verizon.net","kassiesa@yahoo.com","shang@me.com","pgottsch@hotmail.com","paulv@optonline.net","offthelip@me.com","cumarana@mac.com","bhtower@yahoo.ca","alastair@mac.com","khris@verizon.net","killmenow@att.net","garyjb@optonline.net","doormat@outlook.com","gtewari@me.com","mgreen@att.net","jespley@outlook.com","houle@sbcglobal.net","curly@msn.com","dwsauder@yahoo.com","baveja@verizon.net","martyloo@yahoo.ca","fwitness@mac.com","mailarc@yahoo.com","speeves@optonline.net","mrobshaw@att.net","sethbrown@live.com","hikoza@outlook.com","howler@live.com","quantaman@yahoo.ca","sacraver@me.com","carmena@aol.com","erynf@yahoo.ca","jbryan@yahoo.ca","ubergeeb@gmail.com","eidac@gmail.com","gfxguy@sbcglobal.net","rnelson@mac.com","violinhi@yahoo.com","weazelman@optonline.net","mschilli@msn.com","noahb@me.com","lamky@outlook.com","pizza@outlook.com","trieuvan@yahoo.ca","teverett@att.net","ismail@yahoo.com","msusa@yahoo.com","manuals@comcast.net","matty@yahoo.ca","treeves@yahoo.ca","phyruxus@me.com","lauronen@me.com","noahb@att.net","ngedmond@sbcglobal.net","carroll@me.com","wonderkid@live.com","rmcfarla@optonline.net","bwcarty@outlook.com","miltchev@outlook.com","grolschie@live.com","anicolao@hotmail.com","duncand@aol.com","feamster@live.com","nasor@mac.com","pemungkah@hotmail.com","mcraigw@live.com","ganter@live.com","hmbrand@hotmail.com","jmcnamara@me.com","shazow@att.net","peterhoeg@gmail.com","mddallara@outlook.com","malattia@gmail.com","benanov@msn.com","miltchev@yahoo.ca","grinder@verizon.net","mpiotr@sbcglobal.net","madler@mac.com","skippy@aol.com","gospodin@yahoo.ca"
        };
    }
}

