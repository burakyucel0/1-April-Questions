
#region Soru 1
//Ekrana 10 kez “Hello World!” yazdır.

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Hello World!");
//}
#endregion

#region Soru 2
//Dışarıdan girilen sayıya kadar olan çift sayıları ekrana yazdır. Örneğin 11 girdiyse ekrana “2”,”4”,”6”,”8” gibi.

//Console.WriteLine("Lütfen bir sayı giriniz.");
//int number =Convert.ToInt32( Console.ReadLine());

//for (int i = 1; i < number+1; i++)
//{
//    if(i%2 == 0)
//    {
//        Console.Write(i + " ");
//    }

//}
#endregion

#region Soru 3
//Dışarıdan girilen bir sayının rakamlarını tersine çeviren program.Örneğin 123 girdiyse ekrana 321 yazsın gibi

//Console.WriteLine("Lütfen bir sayı giriniz.");
//int number = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < number + 1; i++)
//{
//    if (number >= 10)
//    {
//        Console.Write(number % 10);

//        number /= 10;
//        while (number < 10)
//        {
//            Console.Write(number);
//            break;
//        }
//    }
//}
#endregion

#region Soru 4
//Verilen tamsayının sıfır, pozitif ya da negatif olup olmadığını bulan program.

//Console.WriteLine("Lütfen bir sayı giriniz.");
//int number = Convert.ToInt32(Console.ReadLine());

//if (number > 0)
//{
//    Console.WriteLine("Sayı pozitif");
//}

//else if (number < 0)
//{
//    Console.WriteLine("Sayı negatif");
//}

//else
//{
//    Console.WriteLine("Sayı sıfır");
//}
#endregion

#region Soru 5
//Girilen fiyatın KDV li halini ( % 18 ) ekrana yazdır.

//Console.WriteLine("Lütfen bir sayı giriniz.");
//int number = Convert.ToInt32(Console.ReadLine());

//double newnumber = number * 1.18;

//Console.WriteLine("Kdv dahil fiyat:" + newnumber);
#endregion

#region Soru 6
//Üniversite bir dersin başarı notu bir vize bir final sınav notu ile hesaplanır. Vize notunun kat sayısı %30 final notunun kat sayısı %70’dir.
//Bir öğrencinin sınavda almış olduğu bu notlar neticesinde ders ortalaması bulun.

//Console.WriteLine("Lütfen vize notunuzu giriniz.");
//int quiz1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Lütfen final notunuzu giriniz.");
//int quiz2 = Convert.ToInt32(Console.ReadLine());

//double medium = (quiz1*0.3) + (quiz2*0.7);

//Console.WriteLine("Ders ortalamanız " + medium);
#endregion

#region Soru 7
//Kullanıcıdan alınan sayının tek ya da çift olduğunu kontrol edip ekranda yazdırın

//Console.WriteLine("Lütfen bir sayı giriniz.");
//int number = Convert.ToInt32(Console.ReadLine());

//if (number%2 == 0)
//{
//    Console.WriteLine("Sayı çift");
//}
//else 
//{
//    Console.WriteLine("Sayı tek");
//}
#endregion

#region Soru 8
//Bir kenar uzunluğu ve o kenara ait yüksekliği girilen üçgenin alanını hesaplayın.

//Console.WriteLine("Lütfen bir kenar uzunluğu giriniz.");
//int length = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Lütfen girilen kenarın yüksekliğini giriniz.");
//int height = Convert.ToInt32(Console.ReadLine());

//double area = (length * height) / 2;

//Console.WriteLine("Üçgenin alanı:" + area);
#endregion

#region Soru 9
//Girilen bir x sayısının yine girilen bir y sayısına tam bölünüp bölünmediğini ekrana yazdırın.

//Console.WriteLine("Lütfen birinci sayıyı giriniz.");
//int x = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Lütfen ikinci sayıyı giriniz.");
//int y = Convert.ToInt32(Console.ReadLine());


//if (x % y == 0)
//{
//    Console.WriteLine(x + "sayısı " + y + " sayısına tam bölünüyor.");
//}

//else
//{
//    Console.WriteLine(x + "sayısı " + y + " sayısına tam bölünmüyor.");
//}
#endregion

#region Soru 10
//Çarpma operatörü kullanmadan klavyeden girilen sayının 5 katını bulun.

//Console.WriteLine("Lütfen bir sayı giriniz.");
//int number = Convert.ToInt32(Console.ReadLine());

//int multiplication = 0;

//for (int i = 0; i < 5; i++)
//{
//    multiplication += number;
//}

//Console.WriteLine("Sayının 5 ile çarpımı: " + multiplication);
#endregion

#region Soru 11
//Klavyeden girilen sayının kaç basamaklı olduğunu bulun.

//Console.WriteLine("Lütfen bir sayı giriniz.");
//int number = Convert.ToInt32(Console.ReadLine());


//int counter = 1;

//for (int i = 0; i < number; i++)         // Pozitif değerler için basamak hesabı
//{
//    number /= 10;
//    counter++;

//}

//for (int i = -1; i > number; i--)          // Negatif değerler için basamak hesabı
//{
//    number /= 10;
//    counter++;

//}

//Console.WriteLine(counter + " basamaklı bir sayı girdiniz.");
#endregion

#region Soru 12

//int[] sayilar = new int[5];

//Random rnd = new Random();

//int index = 0;

//for (int i = 0; i < 5; i++)
//{

//    sayilar[i] = rnd.Next(0, 100);

//    Console.Write(sayilar[i]+ " ");

//}

//int minimumValue = sayilar[0];

//for (int i = 0; i < sayilar.Length; i++)
//{

//    if (sayilar[i] < minimumValue)
//    {
//        minimumValue = sayilar[i];
//        index = i;
//    }
//}

//Console.WriteLine("En küçük değer " + minimumValue + " İndeks numarası " + index);

//Console.ReadLine();

#endregion

#region Soru 13
//N elemanlı bir dizi yi yedek dizi KULLANMADAN tersine çeviren program

//int[] numbers = new int[] { 10, 20, 30, 40, 50 };

//int temp = 0;

//for(int i = 0; i < numbers.Length / 2; i++)
//            {
//    temp = numbers[i];
//    numbers[i] = numbers[numbers.Length - i - 1];
//    numbers[numbers.Length - i - 1] = temp;
//}
//foreach (int sayi in numbers)
//{
//    Console.WriteLine(sayi);
//}
//Console.ReadKey();


#endregion

#region Soru 14
//Dışarıdan girilen bir cümledeki kelime sayısını bulan program

//Console.WriteLine("Lütfen bir cümle yanız.");
//string sentence = Console.ReadLine();

//string newsentence = sentence.Replace(" ", "");


//int counter = sentence.Length - newsentence.Length;

//counter++;

//Console.WriteLine(counter + " adet kelime vardır.");
#endregion

#region Soru 15
//Dışarıdan girilen en az 5 basamaklı sayının ilk ve son basamakları arasındaki sayıların toplamını bulan program.

//Console.WriteLine("Lütfen en az 5 basamaklı bir sayı giriniz.");
//int number = Convert.ToInt32(Console.ReadLine());

//while (number < 1000)
//{
//    Console.WriteLine("Lütfen en az 5 basamaklı bir sayı giriniz.");
//    number = Convert.ToInt32(Console.ReadLine());
//}

//int[] numbersList = new int[] { };

//int newnumber = number;

//string text = number.ToString();                 //sayıyı stringe dönüştürür.
//int result = 0;
//for (int i = 1; i < text.Length - 1; i++)
//{
//    int a = text[i] - '0';                    //ilk karakteri atlaması için 1 den başlatıldı.
//    result += a;                               // sıfır değeri dönmesi durumunda silinir.
//}
//Console.WriteLine("sonuc: " + result);

#endregion

#region Soru 16
//Dışarıdan girilen sayının faktöriyelini hesapla

//Console.WriteLine("Lütfen bir sayı giriniz.");
//int number = Convert.ToInt32(Console.ReadLine());

//int result = 1;

//for (int i = 1;  i <= number; i++)  //sıfır ile çarpmaması için 1 den başlatıldı. 
//{
//    result *= i; 

//}

//Console.WriteLine(result + " sayının faktöriyeli");

#endregion


#region Soru 17
//Aşağıdaki formu ekrana yazdıran program.

//1

//2 3

//4 5 6

//7 8 9 10

//11 12 13 14 15


int temp = 1;

//for (int i = 0; i < 7; i++)
//{


//    for (int k = 1; k < i; k++)
//    {
//        Console.Write(temp + " ");

//        temp++;
//    }

//    Console.Write("\n");

//}


#endregion

#region Soru 18
//Aşağıdaki formu ekrana yazdıran program.

//2 3 4 5 6

//3 5 7 9 11

//4 7 10 13 16

//5 9 13 17 21

//6 11 16 21 26

//int line2 = 3;

//int line3 = 4;

//int line4 = 5;

//int line5 = 6;



//for (int i = 2; i <= 6; i++)
//{
//   while (i<=6)
//    {
//        Console.Write(i + " ");

//        i++;

//    }

//   Console.WriteLine();

//    while (line2 <= 11)
//    {
//        Console.Write (line2 + " ");

//        line2 += 2;

//    }
//    Console.WriteLine();

//    while (line3 <= 16)
//    {
//        Console.Write(line3 + " ");

//        line3 += 3;

//    }

//    Console.WriteLine();

//    while (line4 <= 21)
//    {
//        Console.Write(line4 + " ");

//        line4 += 4;

//    }

//    Console.WriteLine();

//    while (line5 <= 26)
//    {
//        Console.Write(line5 + " ");

//        line5 += 5;

//    }
//    Console.WriteLine();
//}
#endregion


