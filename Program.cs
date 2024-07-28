//1. Vaqt kalkulyatori:
Console.Write("daqiqiqani kiriting=> ");
int daqiqa = Convert.ToInt32(Console.ReadLine());
int soat = daqiqa/60;
int min = daqiqa%60;
Console.WriteLine($"{soat}:{min}");
Console.WriteLine();

//2. Yosh toifasini aniqlash:
Console.Write("Yoshingizni kiriting=> ");
int yosh = Convert.ToInt32(Console.ReadLine());
if (yosh>=0 && yosh<=12)
{
    Console.WriteLine("bola");
}
else if (yosh>=13 && yosh<=19)
{
    Console.WriteLine("o'smir");
}
else if (yosh>=20 && yosh<=59)
{
    Console.WriteLine("kattalar");
}
else
{
    Console.WriteLine("katta");
}
Console.WriteLine();

//3. O'rtacha ballni hisoblash:
Console.WriteLine("Olgan bahoyingizni kiriting (0 dan 100 gacha)=> ");
int baho = Convert.ToInt32(Console.ReadLine());
string result = (baho>=80 && baho<=100)
    ? "A'lo"
    : (baho>=60 && baho<=79)
        ? "Yaxshi"
        : (baho>=40 && baho<=59)
            ? "Qoniqarli"
            : (baho>=0 && baho <=40)
                ? "Qoniqarsiz"
                : "Bunday baho mavjud emas";
Console.WriteLine(result);
Console.WriteLine();

//4. "Raqamni toping" o'yini:
Random rand = new Random();
int tasodifiyRaqam = rand.Next(1, 101); // 1 dan 100 gacha tasodifiy raqam generatsiya qilish
Console.WriteLine("1 dan 100 gacha tasodifiy bir raqam tanlandi. Toping! ");
Console.Write("Raqamni kiriting: ");
int foydalanuvchiRaqami = Convert.ToInt32(Console.ReadLine());
string maslahat = foydalanuvchiRaqami > tasodifiyRaqam 
    ? "Siz kiritgan raqam katta" 
    : (foydalanuvchiRaqami < tasodifiyRaqam 
        ? "Siz kiritgan raqam kichik" 
        : "Tabriklaymiz, to'g'ri topdingiz!");
Console.WriteLine($"{maslahat} tasodifiy raqamdan.");
Console.WriteLine($"Tasodifiy raqam: {tasodifiyRaqam}");