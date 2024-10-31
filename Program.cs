
// SortedDictionary koleksiyonu, dictionary koleksiyonun key değerine göre koleksiyonu sıralayan versiyonudur!!!


// Tanımlama : 

SortedDictionary<int,string> dictionary = new SortedDictionary<int, string>();

dictionary.Add(5, "Ahmet");
dictionary.Add(2, "Hasan");
dictionary.Add(-1,"Yıldız");
dictionary.Add(-1,"ipek");


// Ekrana yazdıralım 

foreach(KeyValuePair<int,string> item in dictionary){

    Console.WriteLine("Key : {0}",item.Key);
    Console.WriteLine("Value : {0}",item.Value);
}