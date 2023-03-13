using modul4_1302210084;

public class main
{
    static void Main(string[] args)
    {
        KodeBuah.NamaBuah buah = KodeBuah.NamaBuah.Pisang;
        string kodeBuah = KodeBuah.getKodeBuah(buah);
        Console.WriteLine("Buah "+buah+": "+kodeBuah);

        PosisiKarakterGame kar = new PosisiKarakterGame();
        kar.movement();
    }
}