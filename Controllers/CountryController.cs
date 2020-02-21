﻿using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace WebApplication.Controllers
{
    [Route("ctry")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        [HttpGet]
        public List<Country> Get()
        {
            List<Country> countryList = new List<Country>();
            GetCountryList(countryList);
            return countryList;
        }
        
        private List<Country> GetCountryList(List<Country> countryList)
        {
            Country country1 = new Country { id = 1, name = "United States", capital = "Washington, D.C.", description = "The United States of America, commonly known as the United States (U.S.) or America, is a federal republic composed of 50 states, a federal district, five major self-governing territories, and various possessions. Forty-eight of the fifty states and the federal district are contiguous and located in North America between Canada and Mexico. The state of Alaska is in the northwest corner of North America, bordered by Canada to the east and across the Bering Strait from Russia to the west. The state of Hawaii is an archipelago in the mid-Pacific Ocean. The U.S. territories are scattered about the Pacific Ocean and the Caribbean Sea, stretching across nine time zones. The extremely diverse geography, climate and wildlife of the United States make it one of the world's 17 megadiverse countries.", area = 9833520, population = 323127513, gdp = 57220 };
            countryList.Add(country1);
            Country country2 = new Country { id = 2, name = "United Kingdom", capital = "London", description = "The United Kingdom of Great Britain and Northern Ireland, commonly known as the United Kingdom (UK) or Britain, is a sovereign country in western Europe. Lying off the north-western coast of the European mainland, the United Kingdom includes the island of Great Britain, the north-eastern part of the island of Ireland and many smaller islands. Northern Ireland is the only part of the United Kingdom that shares a land border with another sovereign state‍—‌the Republic of Ireland. Apart from this land border, the United Kingdom is surrounded by the Atlantic Ocean, with the North Sea to its east, the English Channel to its south and the Celtic Sea to its south-south-west, giving it the 12th-longest coastline in the world.", area = 242495, population = 65648000, gdp = 42514 };
            countryList.Add(country2);
            Country country3 = new Country {id = 3, name = "Canada", capital = "Ottawa", description ="Canada is a country in the northern part of North America. Its ten provinces and three territories extend from the Atlantic to the Pacific and northward into the Arctic Ocean, covering 9.98 million square kilometres, making it the world's second-largest country by total area and the fourth-largest country by land area. Canada's southern border with the United States is the world's longest bi-national land border. The majority of the country has a cold or severely cold winter climate, but southerly areas are warm in summer. Canada is sparsely populated, the majority of its land territory being dominated by forest and tundra and the Rocky Mountains.", area = 9984670, population = 35151728, gdp = 46199};
            countryList.Add(country3);
            Country country4 = new Country {id = 4, name = "Australia", capital = "Canberra", description ="Australia officially the Commonwealth of Australia, is a country comprising the mainland of the Australian continent, the island of Tasmania and numerous smaller islands. It is the largest country in Oceania and the world's sixth-largest country by total area. The neighbouring countries are Papua New Guinea, Indonesia and East Timor to the north; the Solomon Islands and Vanuatu to the north-east; and New Zealand to the south-east. Australia's capital is Canberra, and its largest urban area is Sydney.", area = 7692024, population = 24598900, gdp = 48806};
            countryList.Add(country4);
            Country country5 = new Country {id = 5, name = "New Zealand", capital = "Wellington", description ="New Zealand is an island nation in the southwestern Pacific Ocean. The country geographically comprises two main landmasses—the North Island (or Te Ika-a-Māui), and the South Island (or Te Waipounamu)—and around 600 smaller islands. New Zealand is situated some 1,500 kilometres east of Australia across the Tasman Sea and roughly 1,000 kilometres south of the Pacific island areas of New Caledonia, Fiji, and Tonga. Because of its remoteness, it was one of the last lands to be settled by humans. During its long period of isolation, New Zealand developed a distinct biodiversity of animal, fungal and plant life.", area = 268021, population = 4801440, gdp = 36950};
            countryList.Add(country5);
            Country country6 = new Country {id = 6, name = "France", capital = "Paris", description ="France, officially the French Republic, is a country with territory status in western Europe and several overseas regions and territories. The European, or metropolitan, area of France extends from the Mediterranean Sea to the English Channel and the North Sea, and from the Rhine to the Atlantic Ocean. The republic also includes French Guiana on the South American continent and several islands in the Atlantic, Pacific and Indian oceans. The country's 18 integral regions (5 of which are situated overseas) span a combined area of 643,801 square kilometres which, as of January 2017, has a total population of almost 67 million people. France is a unitary semi-presidential republic with its capital in Paris, the country's largest city and main cultural and commercial centre. Other major urban centres include Marseille, Lyon, Lille, Nice, Toulouse and Bordeaux.", area = 643801, population = 66991000, gdp = 43652};
            countryList.Add(country6);
            Country country7 = new Country {id = 7, name = "Germany", capital = "Berlin", description ="Germany, German: Deutschland, officially the Federal Republic of Germany is a federal parliamentary republic in central-western Europe. It includes 16 constituent states, covers an area of 357,021 square kilometres, and has a largely temperate seasonal climate. With about 82 million inhabitants, Germany is the most populous member state of the European Union. After the United States, it is the second most popular immigration destination in the world. Germany's capital and largest metropolis is Berlin, while its largest conurbation is the Ruhr, with its main centres of Dortmund and Essen. The country's other major cities are Hamburg, Munich, Cologne, Frankfurt, Stuttgart, Düsseldorf, Leipzig, Bremen, Dresden, Hannover and Nuremberg.", area = 357168, population = 82175700, gdp = 48111};
            countryList.Add(country7);
            Country country8 = new Country {id = 8, name = "Italy", capital = "Rome", description ="Italy, Italian: Italia, officially the Italian Republic, is a unitary parliamentary republic in Europe. Located in the heart of the Mediterranean Sea, Italy shares open land borders with France, Switzerland, Austria, Slovenia, San Marino and Vatican City. Italy covers an area of 301,338 km2 and has a largely temperate seasonal and Mediterranean climate. Due to its shape, it is often referred to in Italy as lo Stivale (the Boot). With 61 million inhabitants it is the fourth most populous EU member state.", area = 301338, population = 60599936, gdp = 36833};
            countryList.Add(country8);
            Country country9 = new Country {id = 9, name = "Spain", capital = "Madrid", description ="Spain, Spanish: España, officially the Kingdom of Spain (Spanish: Reino de España), is a sovereign state located on the Iberian Peninsula in southwestern Europe, with two large archipelagoes, the Balearic Islands in the Mediterranean Sea and the Canary Islands off the North African Atlantic coast, two cities, Ceuta and Melilla, in the North African mainland and several small islands in the Alboran Sea near the Moroccan coast. The country's mainland is bordered to the south and east by the Mediterranean Sea except for a small land boundary with Gibraltar; to the north and northeast by France, Andorra, and the Bay of Biscay; and to the west and northwest by Portugal and the Atlantic Ocean. It is the only European country to have a border with an African country Morocco and its African territory accounts for nearly 5% of its population, mostly in the Canary Islands but also in Ceuta and Melilla.", area = 505990, population = 46468102, gdp =38239};
            countryList.Add(country9);
            Country country10 = new Country { id = 10, name = "Japan", capital = "Tokyo", description = "Japan, Japanese: 日本 Nippon or Nihon, is a sovereign island nation in East Asia. Located in the Pacific Ocean, it lies off the eastern coast of the Asian mainland, and stretches from the Sea of Okhotsk in the north to the East China Sea and Taiwan in the southwest. The kanji that make up Japan's name mean 'sun origin'. Japan is often referred to by the famous epithet 'Land of the Rising Sun' in reference to its Japanese name.", area = 377972, population = 126740000, gdp = 42860 };
            countryList.Add(country10); 
            Country country11 = new Country {id = 11, name = "Russia", capital = "Moscow", description ="Russia, Russian: Росси́я Rossija also officially known as the Russian Federation Russian is a country in Eurasia. At 17,075,200 square kilometres, Russia is the largest country in the world by surface area, covering more than one-eighth of the Earth's inhabited land area, and the ninth most populous, with over 144 million people at the end of March 2016. The European western part of the country is much more populated and urbanised than the eastern; about 77% of the population live in European Russia. Russia's capital Moscow is one of the largest cities in the world; other major urban centers include Saint Petersburg, Novosibirsk, Yekaterinburg, Nizhny Novgorod, and Kazan.", area = 17075200, population = 144463451, gdp = 27466};
            countryList.Add(country11);
            Country country12 = new Country {id = 12, name = "China", capital = "Beijing", description ="China, Chinese: 中国 Zhōngguó officially the People's Republic of China (PRC), is a unitary sovereign state in East Asia and the world's most populous country, with a population of over 1.381 billion. Covering approximately 9.6 million square kilometres, it is the world's second-largest state by land area and third- or fourth-largest by total area. Governed by the Communist Party of China, it exercises jurisdiction over 22 provinces, five autonomous regions, four direct-controlled municipalities (Beijing, Tianjin, Shanghai, and Chongqing) and the Special Administrative Regions Hong Kong and Macau, also claiming sovereignty over Taiwan. China is a great power and a major regional power within Asia, and has been characterized as a potential superpower.", area = 9596961, population = 1373541278, gdp = 16676};
            countryList.Add(country12);
            Country country13 = new Country {id = 13, name = "India", capital = "New Delhi", description ="India, officially the Republic of India, is a country in South Asia. It is the seventh-largest country by area, the second-most populous country, and the most populous democracy in the world. It is bounded by the Indian Ocean on the south, the Arabian Sea on the southwest, and the Bay of Bengal on the southeast. It shares land borders with Pakistan to the west; China, Nepal, and Bhutan to the northeast; and Myanmar (Burma) and Bangladesh to the east. In the Indian Ocean, India is in the vicinity of Sri Lanka and the Maldives. India's Andaman and Nicobar Islands share a maritime border with Thailand and Indonesia.", area = 3287263, population = 1326572000, gdp = 7153};
            countryList.Add(country13);
            Country country14 = new Country {id = 14, name = "Brazil", capital = "Brasília", description ="Brazil, Portuguese: Brasil officially the Federative Republic of Brazil, About this sound listen, is the largest country in both South America and Latin America. As the world's fifth-largest country by both area and population, it is the largest country to have Portuguese as an official language and the only one in the Americas. Bounded by the Atlantic Ocean on the east, Brazil has a coastline of 7,491 kilometers. It borders all other South American countries except Ecuador and Chile and covers 47.3% of the continent's land area. Its Amazon River basin includes a vast tropical forest, home to diverse wildlife, a variety of ecological systems, and extensive natural resources spanning numerous protected habitats. This unique environmental heritage makes Brazil one of 17 megadiverse countries, and is the subject of significant global interest and debate regarding deforestation and environmental protection.", area = 8515767, population = 207350000, gdp = 15646};
            countryList.Add(country14);
            Country country15 = new Country {id = 15, name = "Mexico", capital = "Mexico City", description ="Mexico, Spanish: Méxic officially the United Mexican States, is a federal republic in the southern portion of North America. It is bordered to the north by the United States; to the south and west by the Pacific Ocean; to the southeast by Guatemala, Belize, and the Caribbean Sea; and to the east by the Gulf of Mexico. Covering almost two million square kilometers, Mexico is the sixth largest country in the Americas by total area and the 13th largest independent nation in the world.", area = 1972550, population = 119530753, gdp = 19481};
            countryList.Add(country15);
            Country country16 = new Country {id = 16, name = "South Korea", capital = "Seoul", description ="South Korea, officially the Republic of Korea, is a sovereign state in East Asia, constituting the southern part of the Korean Peninsula. Officially, its territory consists of the whole Korean Peninsula and its adjacent islands, which are largely mountainous. South Koreans lead a distinctive urban lifestyle, as half of them live in high-rises concentrated in the Seoul Capital Area with 25 million residents. The capital Seoul is the world's sixth leading global city with the fifth largest economy and is the seventh most sustainable city in the world.", area = 100210, population = 51446201, gdp = 39446};
            countryList.Add(country16);
            Country country17 = new Country {id = 17, name = "North Korea", capital = "Pyongyang", description ="North Korea, officially the Democratic People's Republic of Korea, is a country in East Asia constituting the northern part of the Korean Peninsula. Pyongyang is the nation's capital and largest city. To the north and northwest the country is bordered by China and by Russia along the Amnok (known as the Yalu in China) and Tumen rivers; it is bordered to the south by South Korea, with the heavily fortified Korean Demilitarized Zone separating the two. However, the territory is wholly claimed by the Republic of Korea according to the constitution.", area = 120540, population = 25155317, gdp = 1800};
            countryList.Add(country17);
            Country country18 = new Country {id = 18, name = "Taiwan", capital = "Taipei", description ="Taiwan, officially the Republic of China (ROC), is a state in East Asia. Its neighbors include China (officially the People's Republic of China, PRC) to the west, Japan to the northeast, and the Philippines to the south. Taiwan is the most populous state that is not a member of the United Nations and the largest economy outside the UN.", area = 36197, population = 23550077, gdp = 24027};
            countryList.Add(country18);
            Country country19 = new Country {id = 19, name = "Singapore", capital = "Singapore", description ="Singapore, officially the Republic of Singapore, sometimes referred to as the Lion City, the Garden City or the Little Red Dot, is a sovereign city-state in Southeast Asia. It lies one degree (137 km) north of the equator, at the southern tip of peninsular Malaysia, with Indonesia's Riau Islands to the south. Singapore's territory consists of one main island along with 62 other islets. Since independence, extensive land reclamation has increased its total size by 23%, and its greening policy has covered the densely populated island with tropical flora, parks and gardens.", area = 719, population = 5607300, gdp = 90724};
            countryList.Add(country19);
            Country country20 = new Country {id = 20, name = "Israel", capital = "Jerusalem", description ="Israel, Hebrew: יִשְׂרָאֵל‎, Arabic: إِسْرَائِيل‎‎, officially the State of Israel, is a country in the Middle East, on the southeastern shore of the Mediterranean Sea and the northern shore of the Red Sea. It has land borders with Lebanon to the north, Syria to the northeast, Jordan on the east, the Palestinian territories of the West Bank and Gaza Strip to the east and west, respectively, and Egypt to the southwest. The country contains geographically diverse features within its relatively small area. Israel's economy and technology center is Tel Aviv, while its seat of government and proclaimed capital is Jerusalem, although the state's sovereignty over East Jerusalem is not recognised internationally.", area = 22072, population = 8720040, gdp = 36379};
            countryList.Add(country20);
            Country country21 = new Country {id = 21, name = "Malaysia", capital = "Kuala Lumpur", description ="Malaysia is a federal constitutional monarchy located in Southeast Asia. It consists of thirteen states and three federal territories and has a total landmass of 330,803 square kilometres separated by the South China Sea into two similarly sized regions, Peninsular Malaysia and East Malaysia. Peninsular Malaysia shares a land and maritime border with Thailand and maritime borders with Singapore, Vietnam, and Indonesia. East Malaysia shares land and maritime borders with Brunei and Indonesia and a maritime border with the Philippines and Vietnam. The capital city is Kuala Lumpur, while Putrajaya is the seat of the federal government. With a population of over 30 million, Malaysia is the 44th most populous country. The southernmost point of continental Eurasia, Tanjung Piai, is in Malaysia. Located in the tropics, Malaysia is one of 17 megadiverse countries on earth, with large numbers of endemic species.", area = 330803, population = 31603000, gdp = 28490};
            countryList.Add(country21);
            Country country22 = new Country {id = 22, name = "Indonesia", capital = "Jakarta", description ="Indonesia officially the Republic of Indonesia, is a unitary sovereign state and transcontinental country located mainly in Southeast Asia with some territories in Oceania. Situated between the Indian and Pacific oceans, it is the world's largest island country, with more than seventeen thousand islands. At 1,904,569 square kilometres, Indonesia is the world's 14th-largest country in terms of land area and world's 7th-largest country in terms of combined sea and land area. It has an estimated population of over 260 million people and is the world's fourth most populous country, the most populous Austronesian nation, as well as the most populous Muslim-majority country. The world's most populous island, Java, contains more than half of the country's population.", area = 1904569, population = 263510000, gdp = 12432};
            countryList.Add(country22);
            Country country23 = new Country {id = 23, name = "Thailand", capital = "Bangkok", description ="Thailand, officially the Kingdom of Thailand and formerly known as Siam, is a country at the centre of the Indochinese peninsula in Southeast Asia. With a total area of approximately 513,000 km2, Thailand is the world's 50th-largest country. It is the 20th-most-populous country in the world, with around 66 million people.", area = 513120, population = 67959000, gdp = 17750};
            countryList.Add(country23);
            Country country24 = new Country {id = 24, name = "Vietnam", capital = "Hanoi", description ="Vietnam, Vietnamese: Việt Nam [vîət nāːm], officially the Socialist Republic of Vietnam is the easternmost country on the Indochina Peninsula in Southeast Asia. With an estimated 92.7 million inhabitants as of 2016, it is the world's 14th-most-populous country, and the ninth-most-populous Asian country. Vietnam is bordered by China to the north, Laos to the northwest, Cambodia to the southwest, Thailand across the Gulf of Thailand to the southwest, and the Philippines, Malaysia and Indonesia across the South China Sea to the east and southeast. Its capital city has been Hanoi since the reunification of North and South Vietnam in 1976, with Ho Chi Minh City as a historical city as well.", area = 332698, population = 92700000, gdp = 6925};
            countryList.Add(country24);
            Country country25 = new Country {id = 25, name = "South Africa", capital = "Pretoria", description ="South Africa, officially the Republic of South Africa (RSA), is the southernmost country in Africa. It is bounded on the south by 2,798 kilometres of coastline of Southern Africa stretching along the South Atlantic and Indian Oceans; on the north by the neighbouring countries of Namibia, Botswana, and Zimbabwe; and on the east and northeast by Mozambique and Swaziland; and surrounds the kingdom of Lesotho. South Africa is the 25th-largest country in the world by land area, and with close to 56,000,000 people, is the world's 24th-most populous nation. It is the southernmost country on the mainland of the Old World or the Eastern Hemisphere. About 80% of South Africans are of Sub-Saharan African ancestry, divided among a variety of ethnic groups speaking different Bantu languages, nine of which have official status. The remaining population consists of Africa's largest communities of European, Asian, and multiracial ancestry.", area = 1221037, population = 54956900, gdp = 13321};
            countryList.Add(country25);
            Country country26 = new Country {id = 26, name = "Saudi Arabia", capital = "Riyadh", description ="Saudi Arabia: Arabic: المملكة العربية السعودية Al-Mamlakah Al-ʾĀrabīyah As-Saʿūdīyah, officially the Kingdom of Saudi Arabia (KSA), is an Arab sovereign state in Western Asia constituting the bulk of the Arabian Peninsula. With a land area of approximately 2,150,000 km2, Saudi Arabia is geographically the fifth-largest state in Asia and second-largest state in the Arab world after Algeria. Saudi Arabia is bordered by Jordan and Iraq to the north, Kuwait to the northeast, Qatar, Bahrain and the United Arab Emirates to the east, Oman to the southeast and Yemen to the south. It is separated from Israel and Egypt by the Gulf of Aqaba. It is the only nation with both a Red Sea coast and a Persian Gulf coast and most of its terrain consists of arid desert and mountains.", area = 2149690, population = 33000000, gdp = 55229};
            countryList.Add(country26);
            Country country27 = new Country {id = 27, name = "UAE", capital = "Abu Dhabi", description ="The United Arab Emirates: Arabic: دولة الإمارات العربية المتحدة‎‎ Dawlat al-Imārāt al-'Arabīyah al-Muttaḥidah, sometimes simply called the Emirates or the UAE, is a federal absolute monarchy in Western Asia at the southeast end of the Arabian Peninsula on the Persian Gulf, bordering Oman to the east and Saudi Arabia to the south, as well as sharing maritime borders with Qatar to the west and Iran to the north. In 2013, the UAE's population was 9.2 million, of which 1.4 million are Emirati citizens and 7.8 million are expatriates.", area = 22072, population = 10139000, gdp = 40162};
            countryList.Add(country27);
            Country country28 = new Country {id = 28, name = "Dubai", capital = "Dubai", description ="Dubai is the largest and most populous city in the United Arab Emirates (UAE). It is located on the southeast coast of the Persian Gulf and is the capital of the Emirate of Dubai, one of the seven emirates that make up the country. Abu Dhabi and Dubai are the only two emirates to have veto power over critical matters of national importance in the country's legislature. The city of Dubai is located on the emirate's northern coastline and heads the Dubai-Sharjah-Ajman metropolitan area. Dubai will host World Expo 2020.", area = 1287, population = 2788929, gdp = 44000};
            countryList.Add(country28);
            Country country29 = new Country {id = 29, name = "Argentina", capital = "Buenos Aires", description ="Argentina: Spanish: [aɾxenˈtina]), officially the Argentine Republic, is a federal republic in the southern portion of South America. Sharing the bulk of the Southern Cone with its neighbor Chile to the west, the country is also bordered by Bolivia and Paraguay to the north, Brazil to the northeast, Uruguay and the South Atlantic Ocean to the east, and the Drake Passage to the south. With a mainland area of 2,780,400 km2, Argentina is the eighth-largest country in the world, the second largest in Latin America, and the largest Spanish-speaking one. The country is subdivided into twenty-three provinces and one autonomous city, Buenos Aires, which is the federal capital of the nation as decided by Congress. The provinces and the capital have their own constitutions, but exist under a federal system.", area = 2780400, population = 43417000, gdp = 20170};
            countryList.Add(country29);
            Country country30 = new Country { id = 30, name = "Hong Kong", capital = "Hong Kong", description = "Hong Kong, officially the Hong Kong Special Administrative Region of the People's Republic of China, is an autonomous territory in East Asia. It has an area of 1,104 km2 and shares its northern border with the Guangdong Province of Mainland China. With around 7.2 million Hongkongers of various nationalities, Hong Kong is the world's fourth most densely populated country or territory.", area = 2755, population = 7374900, gdp = 58322 };
            countryList.Add(country30);

            return countryList;
        }
    }
}