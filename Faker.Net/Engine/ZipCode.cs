﻿using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Collections.Specialized.BitVector32;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text.RegularExpressions;
namespace Faker.Net.Engine
{
    public class ZipCode
    {
        public static string ZipCodeString() => ZipCodeFill[new Random().Next(1, ZipCodeFill.Length)];

        private static string[] ZipCodeFill { get; } = new string[]
        {
            "32958 Sebastian, FL","47150 New Albany, IN","28358 Lumberton, NC","51501 Council Bluffs, IA","06514 Hamden, CT","02852 North Kingstown, RI","93306 Bakersfield, CA","20832 Olney, MD","30134 Douglasville, GA","07103 Newark, NJ","11746 Huntington Station, NY","47401 Bloomington, IN","70663 Sulphur, LA","60010 Barrington, IL","02360 Plymouth, MA","30188 Woodstock, GA","07960 Morristown, NJ","60085 Waukegan, IL","06082 Enfield, CT","38655 Oxford, MS","02720 Fall River, MA","11361 Bayside, NY","94603 Oakland, CA","02740 New Bedford, MA","08037 Hammonton, NJ","30815 Hephzibah, GA","10002 New York, NY","11552 West Hempstead, NY","28655 Morganton, NC","15401 Uniontown, PA","39208 Pearl, MS","60201 Evanston, IL","98037 Lynnwood, WA","72209 Little Rock, AR","08012 Blackwood, NJ","46375 Schererville, IN","85351 Sun City, AZ","23059 Glen Allen, VA","30038 Lithonia, GA","70605 Lake Charles, LA","45066 Springboro, OH","53151 New Berlin, WI","27540 Holly Springs, NC","37066 Gallatin, TN","27405 Greensboro, NC","19063 Media, PA","19083 Havertown, PA","39120 Natchez, MS","11967 Shirley, NY","46947 Logansport, IN","38017 Collierville, TN","28086 Kings Mountain, NC","50023 Ankeny, IA","10573 Port Chester, NY","04240 Lewiston, ME","34639 Land O Lakes, FL","01752 Marlborough, MA","10950 Monroe, NY","42240 Hopkinsville, KY","01201 Pittsfield, MA","44601 Alliance, OH","12553 New Windsor, NY","08822 Flemington, NJ","33040 Key West, FL","19438 Harleysville, PA","27804 Rocky Mount, NC","21221 Essex, MD","32082 Ponte Vedra Beach, FL","46544 Mishawaka, IN","11510 Baldwin, NY","35758 Madison, AL","55318 Chaska, MN","40004 Bardstown, KY","28376 Raeford, NC","38637 Horn Lake, MS","07111 Irvington, NJ","07060 Plainfield, NJ","80241 Thornton, CO","32003 Fleming Island, FL","02062 Norwood, MA","45840 Findlay, OH","20155 Gainesville, VA","20747 District Heights, MD","11420 South Ozone Park, NY","11001 Floral Park, NY","32547 Fort Walton Beach, FL","06851 Norwalk, CT","29501 Florence, SC","23320 Chesapeake, VA","28115 Mooresville, NC","56401 Brainerd, MN","33880 Winter Haven, FL","68506 Lincoln, NE","55303 Anoka, MN","75080 Richardson, TX","32907 Palm Bay, FL","36330 Enterprise, AL","06824 Fairfield, CT","54401 Wausau, WI","30701 Calhoun, GA","30117 Carrollton, GA","44256 Medina, OH","08087 Tuckerton, NJ","46901 Kokomo, IN","22304 Alexandria, VA","11417 Ozone Park, NY","11561 Long Beach, NY","02453 Waltham, MA","50701 Waterloo, IA","18102 Allentown, PA","48146 Lincoln Park, MI","34997 Stuart, FL","44070 North Olmsted, OH","07424 Little Falls, NJ","54481 Stevens Point, WI","08854 Piscataway, NJ","43551 Perrysburg, OH","45103 Batavia, OH","53140 Kenosha, WI","20745 Oxon Hill, MD","15102 Bethel Park, PA","60193 Schaumburg, IL","20901 Silver Spring, MD","30040 Cumming, GA","35640 Hartselle, AL","49441 Muskegon, MI","49684 Traverse City, MI","37421 Chattanooga, TN","32159 Lady Lake, FL","30004 Alpharetta, GA","38671 Southaven, MS","18974 Warminster, PA","60004 Arlington Heights, IL","85021 Phoenix, AZ","10541 Mahopac, NY","02368 Randolph, MA","67037 Derby, KS","21401 Annapolis, MD","19026 Drexel Hill, PA","27520 Clayton, NC","35173 Trussville, AL","22041 Falls Church, VA","93706 Fresno, CA","30269 Peachtree City, GA","08003 Cherry Hill, NJ","60435 Joliet, IL","43110 Canal Winchester, OH","11590 Westbury, NY","85203 Mesa, AZ","11542 Glen Cove, NY","35405 Tuscaloosa, AL","43123 Grove City, OH","85326 Buckeye, AZ","70001 Metairie, LA","27834 Greenville, NC","21236 Nottingham, MD","23803 Petersburg, VA","27292 Lexington, NC","48060 Port Huron, MI","94070 San Carlos, CA","17109 Harrisburg, PA","45211 Cincinnati, OH","59801 Missoula, MT","85365 Yuma, AZ","29680 Simpsonville, SC","06457 Middletown, CT","46360 Michigan City, IN","34653 New Port Richey, FL","11375 Forest Hills, NY","54449 Marshfield, WI","07024 Fort Lee, NJ","96815 Honolulu, HI","07093 West New York, NJ","53511 Beloit, WI","32708 Winter Springs, FL","17325 Gettysburg, PA","19050 Lansdowne, PA","11793 Wantagh, NY","01826 Dracut, MA","01845 North Andover, MA","30008 Marietta, GA","02127 Boston, MA","06902 Stamford, CT","07470 Wayne, NJ","24502 Lynchburg, VA","78023 Helotes, TX","54901 Oshkosh, WI","78418 Corpus Christi, TX","32084 Saint Augustine, FL","23693 Yorktown, VA","43512 Defiance, OH","33125 Miami, FL","46530 Granger, IN","90278 Redondo Beach, CA","11741 Holbrook, NY","01089 West Springfield, MA","11530 Garden City, NY","97603 Klamath Falls, OR","47905 Lafayette, IN","29576 Murrells Inlet, SC"
        };
    }
}

