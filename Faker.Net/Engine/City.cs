﻿using System;
namespace Faker.Net.Engine
{
    public class City
    {
        public static string CityString() => CityFill[new Random().Next(1, CityFill.Length)];


        private static string[] CityFill { get; } = new string[]
        {
           "Tokyo","Jakarta","Delhi","Manila","São Paulo","Seoul","Mumbai","Shanghai","Mexico City","Guangzhou","Cairo","Beijing","New York","Kolkāta","Moscow","Bangkok","Dhaka","Buenos Aires","Ōsaka","Lagos","Istanbul","Karachi","Kinshasa","Shenzhen","Bangalore","Ho Chi Minh City","Tehran","Los Angeles","Rio de Janeiro","Chengdu","Baoding","Chennai","Lahore","London","Paris","Tianjin","Linyi","Shijiazhuang","Zhengzhou","Nanyang","Hyderābād","Wuhan","Handan","Nagoya","Weifang","Lima","Zhoukou","Luanda","Ganzhou","Tongshan","Kuala Lumpur","Chicago","Heze","Chongqing","Hanoi","Fuyang","Changsha","Dongguan","Jining","Jinan","Pune","Foshan","Bogotá","Ahmedabad","Nanjing","Changchun","Tangshan","Cangzhou","Dar es Salaam","Hefei","Hong Kong","Shaoyang","Zhanjiang","Shangqiu","Nantong","Yancheng","Nanning","Hengyang","Zhumadian","Shenyang","Xingtai","Xi’an","Santiago","Yantai","Riyadh","Luoyang","Kunming","Shangrao","Hangzhou","Bijie","Quanzhou","Miami","Wuxi","Huanggang","Maoming","Nanchong","Zunyi","Qujing","Baghdad","Xinyang","Jieyang","Khartoum","Madrid","Allahābād","Yulin","Changde","Liaocheng","Qingdao","Dallas","Nangandao","Xiangyang","Philadelphia","Giza","Lu’an","Zhaotong","Yichun","Dezhou","Nairobi","Nanchang","Tai’an","Dazhou","Houston","Guadalajara","Yongzhou","Atlanta","Rangoon","Toronto","Suihua","Saint Petersburg","Washington","Qiqihar","Suzhou","Shantou","Weinan","Changzhou","Singapore","Fuzhou","Pudong","Belo Horizonte","Zhangzhou","Yuncheng","Suzhou","Xianyang","Guilin","Taizhou","Abidjan","Huaihua","Ji’an","Xiaoganzhan","Pingdingshan","Jiujiang","Sūrat","Guiyang","Alexandria","Bozhou","Sydney","Huizhou","Huai’an","Chenzhou","Barcelona","Anqing","Suqian","Boston","Jiangmen","Mianyang","Harbin","Huanglongsi","Melbourne","Zibo","Dalian","Hengshui","Yibin","Yangzhou","Timbío","Johannesburg","Yiyang","Guigang","Xinpu","Meizhou","Casablanca","Langfang","Zhangjiakou","Chifeng","Linfen","Jiangguanchi","Kabul","Phoenix","Luzhou","Taiyuan","Zhaoqing","Xiaoxita","Xiamen","Fuzhou","Liuzhou","Zhuzhou","Amman","Jeddah","Chuzhou","Loudi","Deyang","Qingyuan","Kano","Wuhu","Seattle","Yokohama","Binzhou","Baojishi","Zaozhuang","Neijiang","Baicheng","Berlin","Anshan","Lanzhou","Puyang","San Francisco","Jiaozuo","Hechi","Montréal","Detroit","Chengde","Busan","Algiers","Hanzhong","Shiyan","Lucknow","Siping","Yulinshi","Changzhi","Qinzhou","Bazhou","Qincheng","Zhongshan","Suining","Leshan","San Diego","Faisalabad","Guang’an","Tongren","Bengbu","Santa Cruz","Qinhuangdao","Tongliao","Jinzhou","Zhenjiang","Ürümqi","Heyuan","Jaipur","Xinzhou","Wuzhou","Addis Ababa","Chaoyang","Brasília","Mashhad","Shaoguan","Kuwait City","Shanwei","Quezon City","Minneapolis","Kyiv","Sanaa","Meishan","Guatemala City","Incheon","Ningde","Tampa","Daqing","Putian","Bandung","Surabaya","Salvador","Denver","Rome","La Paz","Hohhot","Xiangtan","Pyongyang","Taichung","Weihai","Rizhao","Mudanjiang","Kaohsiung","Guayaquil","Tieling","Cawnpore","Dingxi","Taipei","Nanping","Zigong","Chaozhou","Baotou","Gulou","Longyan","Ankang","Baoshan","Huludao","Antananarivo","Yanjiang","Chattogram","Santo Domingo","Sanming","Longba","Brooklyn","Yangjiang","Jiamusi","Ibadan","Luohe","Lincang","Medellín","Xuanzhou","Yunfu","Dubai","Mirzāpur","Tashkent","Guangyuan","Cali","Huangshi","Ouagadougou","Daegu","Fortaleza","Yaoundé","Douala","Jilin","Dandong","Lianshan","Yingkou","Nāgpur","Omdurman","Bekasi","Ghāziābād","Yuxi","Brisbane","Anshun","Depok","Shangzhou","Huainan","Kuaidamao","Accra","Fukuoka","Jincheng","Vancouver","Tangerang","Sanmenxia","Laibin","Queens","Qinbaling","Xining","Ma’anshan","Yan’an","Baku","Gaoping","Harare","Havana","Phnom Penh","Ningbo","Mogadishu","Puning","Medan","Huaibei","Qingyang","Riverside","Baltimore","Haiphong","Las Vegas","Chongzuo","Rawalpindi","Kumasi","Portland","Vadodara","Hezhou","Pingliang","San Antonio","Perth","Vishākhapatnam","Shengli","Gujranwala","Baicheng","Fushun","St. Louis","Bamako","Quito","Minsk","Indore","Yinchuan","Kananga","Peshawar","Sapporo","Eşfahān","Caracas","Pingxiang","Aleppo","Tijuana","Almaty","Vienna","Thāne","Sacramento","Blantyre","Tainan","Zhuhai","Bucharest","Curitiba","Multan","Xiping","Ecatepec","Jixi","Saidu Sharif","Liaoyang","Hamburg","Meru","Brazzaville","Orlando","Fuxin","Wuwei","Manaus","Bhopāl","San Jose","Warsaw","Lubumbashi","Davao","Haikou","Damascus","Shuyangzha","Brussels","Lusaka","Hyderabad City","Budapest","Shuozhou","Cleveland","Benxi","Baiyin","Pittsburgh","Patna","Mosul","Caloocan City","Austin","Sanzhou","Beihai","Mecca","Heihe","Jingdezhen","Conakry","Kampala","Cincinnati","Recife","Yushan","Zhongli","Kansas City","Manhattan","Bilāspur","Semarang","Ludhiāna","Novosibirsk","Chengtangcun","Āgra","Karaj","Wenzhou","Indianapolis","León de los Aldama","Puebla","Kalyān","Madurai","Mbuji-Mayi","Hebi","Shīrāz","Jamshedpur","Columbus","Tabrīz","Maracaibo","Kawasaki","Aba","Palembang","Zhangjiajie","Kōbe","Charlotte","Changshu","Lianjiang","Ximeicun","Jianguang","Yucheng","Belém","Guiping","Leizhou","Gwangju","Munich","Nāsik","Porto Alegre","Valencia","Onitsha","Abu Dhabi","Virginia Beach","Daejeon","Zapopan","Yekaterinburg","Huazhou","Kyōto","Shuangyashan","Pizhou","El Kelaa des Srarhna","Kharkiv","Yangshe","Guyuan","Khulna","Muscat","Bronx","Gaozhou","Chizhou","Farīdābād","Ulaanbaatar","Goiânia","Fuqing","Belgrade","Pingdu","Milan","Aurangābād","Yutan","Milwaukee","Huangshan","Auckland","Makassar","Santiago","Prague","Rājkot","Liangshi","Córdoba","Guarulhos","Al Başrah","Saitama","Juárez","Montevideo","Xintai","Wusong","Meerut","Yushu","Rongcheng","Huazhou","Yangquan","Adelaide","Baishan","Dayan","Haicheng","Jiangyin","Huaiyin","Wuzhong","Cacuaco","Barranquilla","Sofia","Soweto","Jabalpur","Rucheng","Nizhniy Novgorod","Shaoyang","Dhanbād","Comayagüela","Laiwu","Sharjah","Jingling","Kazan","Suwon","Yongcheng","Calgary","Cần Thơ","Abuja","Mandalay","Beidao","Xiangshui","Dadukou","Vila Velha","Chelyabinsk","Mombasa","Providence","Vārānasi","Qom","Zhangye","Hiroshima","Maiduguri","Maputo","Doha","Rosario","Pikine","Xinyu","Ahvāz","Jacksonville","Medina","Srīnagar","Omsk","Liaoyuan","Cilacap","Yingtan","Bandar Lampung","Samara","Guankou","Ulsan","Dingzhou","Campinas","Lianyuan","Dakar","Rongcheng","Kaiyuan","Nay Pyi Taw","Kigali","Leiyang","Yichun","Benin City","Birmingham","Xiantao","Amritsar","Callao","Monterrey","Alīgarh","Yingchuan","Ciudad Nezahualcóyotl","Tripoli","Nampo","Rostov","Tegucigalpa","Tbilisi","Guwāhāti","Ufa","Fès","Biên Hòa","N’Djamena","Ikare","Salt Lake City","Bhilai","Hāora","Tamale","Xibeijie","Copenhagen","Nezahualcóyotl","Hanchuan","Gongzhuling","Krasnoyarsk","Cologne","Yicheng","Zhufeng","São Gonçalo","Nashville","Yerevan","Nur-Sultan","Nouakchott","Vereeniging","Richmond","São Luís","Rānchi","San Pedro Sula","Taixing","Gwalior","Memphis","Goyang","Bezwāda","Edmonton","Bishkek","Mizhou","Tunis","Xishan","Ezhou","Barquisimeto","Sendai","Hegang","Kathmandu","Mexicali","Voronezh","Perm","Changwon","Zhongwei","Shouguang","Bogor","Raleigh","Cartagena","Chandīgarh","Matola","Jodhpur","Ogbomoso","Shymkent","Niamey","Taizhou","Managua","Bagam","Shubrā al Khaymah","Maceió","Monrovia","Wafangdian","Zhongxiang","Odesa","Port-au-Prince","New Orleans","Villahermosa","Thủ Đức","Volgograd","Mysore","Islamabad","Xinyi","Raipur","Arequipa","Port Harcourt","Louisville","Zaoyang","Shuizhai","Xingyi","Kota","Quetta","Ottawa","Stockholm","Asmara","Freetown","Vientiane","Jerusalem","Bangui","Panama City","Amsterdam","Lomé","Libreville","Zagreb","Dushanbe","Lilongwe","Cotonou","Colombo","Pretoria","Winnipeg","Quebec City","Oslo","Athens","Bujumbura","Helsinki","Skopje","Chisinau","Riga","Kingston","Rabat","Vilnius","San Salvador","Djibouti","Dublin","The Hague","Asunción","Lisbon","Bratislava","Kitchener","Tallinn","Beirut","Cape Town","Tirana","Wellington","Dodoma","Halifax","Bissau","Canberra","Juba","Yamoussoukro","Victoria","Maseru","Nicosia","Windhoek","Port Moresby","Porto-Novo","Sucre","San José","Ljubljana","Sarajevo","Nassau","Bloemfontein","Fort-de-France","New Delhi","Gaborone","Paramaribo","Dili","Male","Georgetown","Gibraltar","Saint-Denis","Malabo","Podgorica","Manama","Port Louis","Willemstad","Bern","Papeete","Luxembourg","Reykjavík","Praia","Sri Jayewardenepura Kotte","Bridgetown","Moroni","Thimphu","Mbabane","Nouméa","Honiara","Suva","Ankara","Castries","Cayenne","São Tomé","Port-Vila","Hamilton","Bandar Seri Begawan","Monaco","Gitega","Port of Spain","Apia","Tarawa","Oranjestad","Saint Helier","Banjul","Mamoudzou","Majuro","Douglas","George Town","Victoria","Kingstown","Andorra la Vella","Saint John’s","Nuku‘alofa","Ashgabat","Nuuk","Belmopan","Roseau","Basseterre","Tórshavn","Pago Pago","Valletta","Gaza","Grand Turk","Palikir","Funafuti","Vaduz","Lobamba","Avarua","Saint George’s","San Marino","Al Quds","Capitol Hill","Stanley","Vatican City","Alofi","Basse-Terre","Hagåtña","Marigot","Jamestown","Brades","Philipsburg","Yaren","Pristina","Gustavia","Road Town","Ngerulmud","Saint-Pierre","The Valley","Mata-Utu","Kingston","Longyearbyen","Tifariti","Adamstown","Flying Fish Cove","King Edward Point","Bareilly","Quảng Hà","Xingcheng","Dongtai","Al Manşūrah","Yingcheng","Chiba","Pekanbaru","Luocheng","Dnipro","Danyang","Natal","Nada","Zamboanga City","Kirkuk","Naples","Wuchuan","Huilong","Oklahoma City","Morelia","Cebu City","Shaoxing","Coimbatore","Santo Domingo Este","Setagaya","Sŏngnam","Taishan","Fangchenggang","Solāpur","Tangier","Anqiu","Feicheng","Kermānshāh","Kitakyūshū","Meishan","Khartoum North","Kisangani","Aguascalientes","Marrakech","Donetsk","Trujillo","Taihe","Bridgeport","Trichinopoly","Xin’an","Taihecun","Naucalpan de Juárez","Owerri","Padang","Qingzhou","Buffalo","Lichuan","Daye","Fort Worth","Hengzhou","Campo Grande","Zhuanghe","Hartford","Bobo-Dioulasso","Ad Dammām","Lhasa","Jiaozhou","Taguig City","Mérida","Yangchun","Bucheon","Dengtalu","Antipolo","Hubli","Abeokuta","Cancún","Tucson","Krasnodar","Natal","Chihuahua","Klang","Turin","Ar Ramādī","Laiyang","Sale","Jalandhar","Kaifeng Chengguanzhen","Ikeja","Malang","Marseille","Saltillo","Gaomi","Ipoh","Hai’an","Oran","Hermosillo","Weichanglu","Shache","Leping","Hailun","Macheng","Akure","Ilorin","Teresina","Yuci","Omaha","Saratov","Erbil","Iguaçu","El Paso","Pasig City","Denpasar","Dehui","Bhubaneshwar","Tongchuan","Cheongju","Warri","Pointe-Noire","Sakai","Rongjiawan","Butterworth","Renqiu","Honolulu","Xindi","Wu’an","São Bernardo do Campo","Gaoyou","Culiacán","Hejian","Yiyang","Puxi","Zijinglu","João Pessoa","McAllen","Querétaro","Abaeté","Palermo","Qingping","Valencia","Niigata","Leeds","Morādābād","Hamamatsu","Xiangxiang","Chaohucun","Fuyang","Homs","Lubango","San Luis Potosí","Cencheng","Dali","Hamhŭng","Kraków","Hempstead","Frankfurt","Al ‘Ayn","Songzi","Laixi","Bahawalpur","Zhongba","Kaduna","Qingnian","Albuquerque","Xinhualu","Nerima","Guangshui","Tlajomulco de Zúñiga","Samarinda","Pietermaritzburg","Changhua","Kolhāpur","Sizhan","Ciudad Guayana","Cúcuta","Licheng","Ōta-ku","Thiruvananthapuram","Tyumen","Nampula","Zaporizhzhia","Chengguan","Kumamoto","Nehe","Birmingham","Zunhua","Valenzuela","Orūmīyeh","Wugang","Osogbo","Shuangqiao","Comodoro Rivadavia","Cagayan de Oro","Langzhong","Qian’an","Lviv","Zouping","An Najaf","Sagamihara","Sarasota","Mississauga","Okayama","Anlu","Dayton","Changsha","Torreón","Shihezi","George Town","Enugu","Soledad","Jaboatão","Yanggok","Yatou","Santo André","Xichang","Bhiwandi","City of Parañaque","Dasmariñas","Chengxiang","Sahāranpur","Warangal","Edogawa","Osasco","Dashiqiao","Latakia","Rochester","Fresno","Banjarmasin","Salem","General Santos","Ḩamāh","Bacoor","Shishi","Guadalupe","Adachi","Qianxi","Tolyatti","Macau","Bauchi","Hamilton","Łódź","Miluo Chengguanzhen","Gaizhou","Mālegaon","Karbalā’","Leling","São José dos Campos","Sevilla","Jianshe","Shizuoka","Jingcheng","Kochi"
        };
    }
}
