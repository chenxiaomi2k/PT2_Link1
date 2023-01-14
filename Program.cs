int menu()
{
    Console.WriteLine("1. Nhap 1 so nguyen N (0 < N < 50)");
    Console.WriteLine("2. Nhap mang gom N so thuc");
    Console.WriteLine("3. Tim so lon nhat trong mang");
    Console.WriteLine("4. Tim so nho nhat trong mang");
    Console.WriteLine("5. Tim so duong chan lon nhat trong mang");
    Console.WriteLine("6. Tim so am le nho nhat trong mang");
    Console.WriteLine("7. Tim so chinh phuong trong mang");
    Console.WriteLine("8. Tinh tong mang");
    Console.WriteLine("9. Tinh trung binh cong cac phan tu mang");
    Console.WriteLine("10. Tim nhung phan tu lon hon trung binh cong");
    Console.WriteLine("11. Sap xep mang tang dan");
    Console.WriteLine("12. Sap xep mang giam dan");
    Console.WriteLine("13. In ra trung binh cong cac phan tu ko am trongg mang");
    Console.WriteLine("0. Exit");
    while (true)
    {
        Console.Write("Chon 1 lua chon: ");
        int choice = int.Parse(Console.ReadLine());
        if (choice >= 0 && choice <= 13)
        {
            return choice;
        }
    }
}

int nhapSoNguyenN()
{
    while (true)
    {
        Console.Write("Nhap N (0 < N < 50): ");
        int n = int.Parse(Console.ReadLine());
        if (n > 0 && n < 50)
        {
            return n;
        }
        else
        {
            Console.WriteLine("Nhap lai n!");
        }
    }
}

double[] nhapMangN(int n)
{
    double[] mang = new double[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write("Nhap so thu {0}: ", i + 1);
        mang[i] = double.Parse(Console.ReadLine());
    }
    return mang;
}

double soLonNhat(double[] mang)
{
    double max = mang[0];
    for (int i = 0; i < mang.Length - 1; i++)
    {
        if (max < mang[i + 1])
        {
            max = mang[i + 1];
        }
    }
    return max;
}

double soNhoNhat(double[] mang)
{
    double min = mang[0];
    for (int i = 0; i < mang.Length - 1; i++)
    {
        if (min > mang[i + 1])
        {
            min = mang[i + 1];
        }
    }
    return min;
}

double soDuongChanLonNhat(double[] mang)
{
    double[] chan = new double[mang.Length];
    for (int i = 0; i < mang.Length; i++)
    {
        if (mang[i] % 2 == 0 && mang[i] > 0)
        {
            chan[i] = mang[i];
        }
    }
    double max = chan[0];
    for (int i = 0; i < chan.Length - 1; i++)
    {
        if (max < chan[i + 1])
        {
            max = chan[i + 1];
        }
    }
    return max;
}

double soAmLeNhoNhat(double[] mang)
{
    double[] chan = new double[mang.Length];
    for (int i = 0; i < mang.Length; i++)
    {
        if (mang[i] % 2 != 0 && mang[i] < 0)
        {
            chan[i] = mang[i];
        }
    }
    double min = chan[0];
    for (int i = 0; i < chan.Length - 1; i++)
    {
        if (min > chan[i + 1])
        {
            min = chan[i + 1];
        }
    }
    return min;
}

void soChinhPhuong(double[] mang)
{
    Console.Write("So chinh phuong trong mang: ");
    for (int i = 0; i < mang.Length; i++)
    {
        if (mang[i] > 0)
        {
            if (Math.Sqrt(mang[i]) * Math.Sqrt(mang[i]) == mang[i])
            {
                Console.Write("{0} ", mang[i]);
                Console.WriteLine();
            }
        }
    }
}

double tinhTongMang(double[] mang)
{
    double sum = 0;
    for (int i = 0; i < mang.Length; i++)
    {
        sum += mang[i];
    }
    return sum;
}

double tinhTrungBinhMang(double[] mang)
{
    double sum = 0;
    int count = 0;
    for (int i = 0; i < mang.Length; i++)
    {
        sum += mang[i];
        count++;
    }
    return (sum / count);
}

void timPhanTuLonHonTB(double[] mang)
{
    double sum = 0;
    int count = 0;
    for (int i = 0; i < mang.Length; i++)
    {
        sum += mang[i];
        count++;
    }
    Console.Write("Phan tu lon hon trung binh cong cua mang la: ");
    for (int i = 0; i < mang.Length; i++)
    {
        if (mang[i] > (sum / count))
        {
            Console.Write("{0} ", mang[i]);
            Console.WriteLine();
        }
    }
}

void sapXepTangDan(double[] mang)
{
    for (int i = 0; i < mang.Length; i++)
    {
        for (int j = i + 1; j < mang.Length; j++)
        {
            if (mang[i] > mang[j])
            {
                double temp = mang[i];
                mang[i] = mang[j];
                mang[j] = temp;
            }
        }
    }
    Console.Write("Tang dan: ");
    for (int i = 0; i < mang.Length; i++)
    {
        Console.Write("{0} ", mang[i]);
    }
    Console.WriteLine();
}

void sapXepGiamDan(double[] mang)
{
    for (int i = 0; i < mang.Length - 1; i++)
    {
        for (int j = i + 1; j < mang.Length; j++)
        {
            if (mang[i] < mang[j])
            {
                double temp = mang[i];
                mang[i] = mang[j];
                mang[j] = temp;
            }
        }
    }
    Console.Write("Giam dan: ");
    for (int i = 0; i < mang.Length; i++)
    {
        Console.Write("{0} ", mang[i]);
    }
    Console.WriteLine();
}

double tinhTrungBinhKoAmMang(double[] mang)
{
    double sum = 0;
    int count = 0;
    for (int i = 0; i < mang.Length; i++)
    {
        if (mang[i] > 0)
        {
            sum += mang[i];
            count++;
        }
    }
    return (sum / count);
}

int n = 0;
double[] mang = new double[n];
while (true)
{
    int choice = menu();
    switch (choice)
    {
        case 1:
            n = nhapSoNguyenN();
            break;
        case 2:
            mang = nhapMangN(n);
            break;
        case 3:
            Console.WriteLine(soLonNhat(mang));
            break;
        case 4:
            Console.WriteLine(soNhoNhat(mang));
            break;
        case 5:
            Console.WriteLine(soDuongChanLonNhat(mang));
            break;
        case 6:
            Console.WriteLine(soAmLeNhoNhat(mang));
            break;
        case 7:
            soChinhPhuong(mang);
            break;
        case 8:
            Console.WriteLine("{0:0.##}", tinhTongMang(mang));
            break;
        case 9:
            Console.WriteLine("{0:0.##}", tinhTrungBinhMang(mang));
            break;
        case 10:
            timPhanTuLonHonTB(mang);
            break;
        case 11:
            sapXepTangDan(mang);
            break;
        case 12:
            sapXepGiamDan(mang);
            break;
        case 13:
            Console.WriteLine("{0:0.##}", tinhTrungBinhKoAmMang(mang));
            break;
        case 0:
            return;
    }
}