// See https://aka.ms/new-console-template for more information

using GiuaKi.Model;

internal class Program
{
    private static List<Sach> sachs348 = new List<Sach>
    {
        new Sach(1, "Sinh Hoc", "Vat Ly", 1, "Thanh", 100),
        new Sach(2, "Toan", "Lich Su", 2, "Thanh", 200),
    };
    
    private static List<Bao> baos348 = new List<Bao>
    {
        new Bao(1, "Hoc Tro", "Dong A", 1, new DateTime(2024, 6, 11)),
        new Bao(2, "Nguoi Lon", "Dao Da", 2, new DateTime(2024, 3, 01)),
    };
    
    private static List<TapChi> tapChis348 = new List<TapChi>
    {
        new TapChi(1, "Hoc Duong", "Kim Dong", 1, 1, 20),
        new TapChi(2, "Nguoi Lon", "Lau Da", 2, 2, 20),
    };

    private static List<DanhMuc> danhMucs348 = new List<DanhMuc>
    {
        new DanhMuc(1, "Hoc Sinh", 1, 1, 1),
        new DanhMuc(2, "Nguoi Lon", 2, 2, 2),
    };

    private static List<TaiLieu> taiLieus348 = new List<TaiLieu>
    {
    };
    
    public static void Main(string[] args)
    {
        taiLieus343.AddRange(sachs348);
        taiLieus343.AddRange(baos348);
        taiLieus343.AddRange(tapChis348);

        var sachLoc348 = taiLieus348.Where(tl => tl.GetType() == typeof(Sach));
        var baoLoc348 = taiLieus348.Where(tl => tl.GetType() == typeof(Bao));
        var tapChiLoc348 = taiLieus348.Where(tl => tl.GetType() == typeof(TapChi));

        var firstMarch348 = new DateTime(2024, 3, 1);
        var lastMarch348 = new DateTime(2024, 3, 31);
        
        var baoInMarch348 = baos348.Where(b => b.NgayPh >= firstMarch348 && b.NgayPh <= lastMarch348);

    }
}