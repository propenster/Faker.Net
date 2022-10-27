using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Query.ExpressionVisitors.Internal;
using static System.Collections.Specialized.BitVector32;
using System.Net.Sockets;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text.RegularExpressions;
namespace Faker.Net.Engine
{
    public class Address
    {
        //public static IEnumerable<string> Fill { get; } = new string[]
        //{
        //    "No 5, Foxtrot, CA, South Illinois"
        //};
        public static string AddressString() => AddressFill[new Random().Next(1, AddressFill.Length)];
        private static string[] AddressFill { get; } = new string[]
        {
            "939 Hamilton St.","Buford, GA 30518","65 Rockland Drive","Toledo, OH 43612","9576 Orchard Lane","Norcross, GA 30092","508 Vine Court","Graham, NC 27253","7926 Hillcrest St.","Stevens Point, WI 54481","8198 Pulaski Court","Southampton, PA 18966","9294 N. Williams Lane","Catonsville, MD 21228","719 Division Lane","Hollywood, FL 33020","1 W. Market Drive","Union, NJ 07083","78 East Orchard Street","Elizabethton, TN 37643","771 Williams Ave.","Essex, MD 21221","12 Fairground Drive","Basking Ridge, NJ 07920","1 Mountainview Ave.","Concord, NH 03301","409 North Arch Rd.","Streamwood, IL 60107","5 Harvard Street","Saugus, MA 01906","245 S. Tanglewood St.","Beckley, WV 25801","137 Shub Farm Drive","Charlotte, NC 28205","687 Holly Street","Baldwinsville, NY 13027","88 E. Mayfair Court","San Angelo, TX 76901","9966 Foster St.","New Philadelphia, OH 44663","653 Beechwood Rd.","Yuba City, CA 95993","8219 Country Ave.","Emporia, KS 66801","887 S. Vermont Street","Hicksville, NY 11801","34 Jockey Hollow St.","Erie, PA 16506","9826 Manor Station St.","Canonsburg, PA 15317","20 North Newport St.","Jacksonville Beach, FL 32250","9167 Canal St.","Sugar Land, TX 77478","984 Central Ave.","Quakertown, PA 18951","9 10th St.","Pittsfield, MA 01201","9128 Lakeview Avenue","Winder, GA 30680","9325 Shore Street","Council Bluffs, IA 51501","9332 Garfield St.","Madison Heights, MI 48071","7678 Kingston Ave.","Bountiful, UT 84010","194 Hawthorne Ave.","Bethpage, NY 11714","302 Saxton Court","Niagara Falls, NY 14304","9814 Bayport Street","North Haven, CT 06473","4 Nut Swamp Dr.","Stoughton, MA 02072","8199 New Rd.","Howell, NJ 07731","8085 Sulphur Springs Drive","Baltimore, MD 21206","9 N. Theatre Dr.","Apple Valley, CA 92307","7194 Alderwood Court","Mesa, AZ 85203","8601 Overlook Court","Fairport, NY 14450","103 Race St.","Grand Haven, MI 49417","191 South Cherry Ave.","Niceville, FL 32578","499 East Armstrong Ave.","Meriden, CT 06450","7828 S. Canal St.","Piqua, OH 45356","7 Elizabeth St.","South Windsor, CT 06074","67 Oakwood Drive","Chapel Hill, NC 27516","7188 Gainsway Street","Palatine, IL 60067","25 East Lake Drive","Vienna, VA 22180","9 Lakewood Road","Suite 263","East Hartford, CT 06118","146 North Roosevelt Dr.","Phoenixville, PA 19460","9424 Brookside Lane","Ringgold, GA 30736","804 Manor Dr.","Eugene, OR 97402","62 St Paul St.","Savannah, GA 31404","553 Princeton Dr.","Los Angeles, CA 90008","337 Peninsula Ave.","Garden City, NY 11530","747 Annadale Ave.","New Berlin, WI 53151","549 Glen Eagles Road","Wallingford, CT 06492","7075 N. Lake Forest St.","Mahwah, NJ 07430","884 San Juan St.","Deltona, FL 32725","2 W. Rock Maple Avenue","Middle Village, NY 11379","21 Randall Mill Drive","Lockport, NY 14094","369 St Margarets Street","Park Forest, IL 60466","76 Honey Creek Drive","Winter Park, FL 32792","9 Indian Summer Dr.","Oviedo, FL 32765","2 Westport St.","Teaneck, NJ 07666","9617 Jones Street","Erlanger, KY 41018","9682 Beacon Dr.","Glendale Heights, IL 60139","997 Shadow Brook St.","Sun Prairie, WI 53590","9260 Liberty Street","Cordova, TN 38016","9816 Queen Ave.","Leesburg, VA 20175","6 Littleton Street","Oconomowoc, WI 53066","9390 Bridgeton Drive","Lakeville, MN 55044","977 Evergreen Street","Shakopee, MN 55379","9027 Prairie Court","Libertyville, IL 60048","432 Santa Clara Road","Elk Grove Village, IL 60007","843 Surrey Ave.","Fishers, IN 46037","489 Windsor Lane","Oak Ridge, TN 37830","7733 Nicolls Rd.","Ashburn, VA 20147","167 Mechanic Street","Marlborough, MA 01752","2 James St.","Reno, NV 89523","7 W. Boston Ave.","Anderson, SC 29621","141 Grant Ave.","North Ridgeville, OH 44039","46 Swanson Ave.","San Carlos, CA 94070","181 Pierce Lane","Ladson, SC 29456","451 St Paul Ave.","Westminster, MD 21157","29 Berkshire St.","Old Bridge, NJ 08857","45 South Fulton Drive","Massapequa, NY 11758","9163 S. Deerfield Rd.","Montclair, NJ 07042","7788 E. Grant Avenue","Prattville, AL 36067","792 Overlook Court","Austin, MN 55912","65 S. Beacon Street","Grand Island, NE 68801","13 Cherry Hill St.","Elmont, NY 11003","405 Lancaster St.","Nazareth, PA 18064","100 Arlington Street","Powell, TN 37849","868 Lake View St.","Nashville, TN 37205","468 Bank Drive","Raleigh, NC 27603","8922 Brook Street","Manitowoc, WI 54220","622 Newbridge Street","Vineland, NJ 08360"
        };
    }
}

