using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Enums
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum KhuVuc
    {
        [Description("Thành phố Quy Nhơn (Bùi Thị Xuân)")]
        ThanhPhoQuyNhonBuiThiXuan,
        [Description("Thành phố Quy Nhơn (Đống Đa)")]
        ThanhPhoQuyNhonDongDa,
        [Description("Thành phố Quy Nhơn (Ghềnh Ráng)")]
        ThanhPhoQuyNhonGhenhRang,
        [Description("Thành phố Quy Nhơn (Hải Cảng)")]
        ThanhPhoQuyNhonHaiCang,
        [Description("Thành phố Quy Nhơn (Lê Hồng Phong)")]
        ThanhPhoQuyNhonLeHongPhong,
        [Description("Thành phố Quy Nhơn (Lê Lợi)")]
        ThanhPhoQuyNhonLeLoi,
        [Description("Thành phố Quy Nhơn (Lý Thường Kiệt)")]
        ThanhPhoQuyNhonLyThuongKiet,
        [Description("Thành phố Quy Nhơn (Ngô Mây)")]
        ThanhPhoQuyNhonNgoMay,
        [Description("Thành phố Quy Nhơn (Nguyễn Văn Cừ)")]
        ThanhPhoQuyNhonNguyenVanCu,
        [Description("Thành phố Quy Nhơn (Nhơn Bình)")]
        ThanhPhoQuyNhonNhonBinh,
        [Description("Thành phố Quy Nhơn (Nhơn Hải)")]
        ThanhPhoQuyNhonNhonHai,
        [Description("Thành phố Quy Nhơn (Nhơn Phú)")]
        ThanhPhoQuyNhonNhonPhu,
        [Description("Thành phố Quy Nhơn (Phước Mỹ)")]
        ThanhPhoQuyNhonPhuocMy,
        [Description("Thành phố Quy Nhơn (Quang Trung )")]
        ThanhPhoQuyNhonQuangTrung,
        [Description("Thành phố Quy Nhơn (Quy Nhơn)")]
        ThanhPhoQuyNhonQuyNhon,
        [Description("Thành phố Quy Nhơn (Thị Nại)")]
        ThanhPhoQuyNhonThiNai,
        [Description("Thành phố Quy Nhơn (Trần Hưng Đạo)")]
        ThanhPhoQuyNhonTranHungDao,
        [Description("Thành phố Quy Nhơn (Trần Phú)")]
        ThanhPhoQuyNhonTranPhu,
        [Description("Thành phố Quy Nhơn (Trần Quang Diệu)")]
        ThanhPhoQuyNhonTranQuangDieu,

        [Description("Huyện Tuy Phước (Thị Trấn Diêu Trì)")]
        HuyenTuyPhuocThiTranDieuTri,
        [Description("Huyện Tuy Phước (Thị Trấn Tuy Phước)")]
        HuyenTuyPhuocThiTranTuyPhuoc,
        [Description("Huyện Tuy Phước (Phước An)")]
        HuyenTuyPhuocPhuocAn,
        [Description("Huyện Tuy Phước (Phước Hiệp)")]
        HuyenTuyPhuocPhuocHiep,
        [Description("Huyện Tuy Phước (Phước Hòa)")]
        HuyenTuyPhuocPhuocHoa,
        [Description("Huyện Tuy Phước (Phước Hưng)")]
        HuyenTuyPhuocPhuocHung,
        [Description("Huyện Tuy Phước (Phước Lộc)")]
        HuyenTuyPhuocPhuocLoc,
        [Description("Huyện Tuy Phước (Phước Nghĩa)")]
        HuyenTuyPhuocPhuocNghia,
        [Description("Huyện Tuy Phước (Phước Quang)")]
        HuyenTuyPhuocPhuocQuang,
        [Description("Huyện Tuy Phước (Phước Sơn)")]
        HuyenTuyPhuocPhuocSon,
        [Description("Huyện Tuy Phước (Phước Thành)")]
        HuyenTuyPhuocPhuocThanh,
        [Description("Huyện Tuy Phước (Phước Thắng)")]
        HuyenTuyPhuocPhuocThang,
        [Description("Huyện Tuy Phước (Phước Thuận)")]
        HuyenTuyPhuocPhuocThuan,


        [Description("Huyện An Nhơn (Thị Trấn Bình Định)")]
        HuyenAnNhonThiTranBinhDinh,
        [Description("Huyện An Nhơn (Đập Đá)")]
        HuyenAnNhonDapDa,
        [Description("Huyện An Nhơn (Nhơn Hưng)")]
        HuyenAnNhonNhonHung,
        [Description("Huyện An Nhơn (Nhơn Thành )")]
        HuyenAnNhonNhonThanh,
        [Description("Huyện An Nhơn (Nhơn Hòa)")]
        HuyenAnNhonNhonHoa,

        [Description("Huyện Phù Cát (Thị Trấn Ngô Mây)")]
        HuyenPhuCatThiTranNgoMay,
        [Description("Huyện Phù Cát (Cát Chánh)")]
        HuyenPhuCatCatChanh,
        [Description("Huyện Phù Cát (Cát Hải)")]
        HuyenPhuCatCatHai,
        [Description("Huyện Phù Cát (Cát Hanh)")]
        HuyenPhuCatCatHanh,
        [Description("Huyện Phù Cát (Cát Hiệp)")]
        HuyenPhuCatCatHiep,
        [Description("Huyện Phù Cát (Cát Hưng)")]
        HuyenPhuCatCatHung,
        [Description("Huyện Phù Cát (Cát Khánh)")]
        HuyenPhuCatCatKhanh,
        [Description("Huyện Phù Cát (Cát Lâm)")]
        HuyenPhuCatCatLam,
        [Description("Huyện Phù Cát (Cát Minh)")]
        HuyenPhuCatCatMinh,
        [Description("Huyện Phù Cát (Cát Nhơn)")]
        HuyenPhuCatCatNhon,
        [Description("Huyện Phù Cát (Cát Sơn)")]
        HuyenPhuCatCatSon,
        [Description("Huyện Phù Cát (Cát Tài)")]
        HuyenPhuCatCatTai,
        [Description("Huyện Phù Cát (Cát Tân)")]
        HuyenPhuCatCatTan,
        [Description("Huyện Phù Cát (Cát Thành)")]
        HuyenPhuCatCatThanh,
        [Description("Huyện Phù Cát (Cát Thắng)")]
        HuyenPhuCatCatThang,
        [Description("Huyện Phù Cát (Cát Tiến)")]
        HuyenPhuCatCatTien,
        [Description("Huyện Phù Cát (Cát Trinh)")]
        HuyenPhuCatCatTrinh,
        [Description("Huyện Phù Cát (Cát Tường)")]
        HuyenPhuCatCatTuong,

        [Description("Huyện Phù Mỹ (Thị Trấn Phù Mỹ)")]
        HuyenPhuMyThiTranPhuMy,
        [Description("Huyện Phù Mỹ (Bình Dương)")]
        HuyenPhuMyBinhDuong,
        [Description("Huyện Phù Mỹ (Mỹ An)")]
        HuyenPhuMyMyAn,
        [Description("Huyện Phù Mỹ (Mỹ Cát)")]
        HuyenPhuMyMyCat,
        [Description("Huyện Phù Mỹ (Mỹ Chánh Tây)")]
        HuyenPhuMyMyChanhTay,
        [Description("Huyện Phù Mỹ (Mỹ Chánh )")]
        HuyenPhuMyMyChanh,
        [Description("Huyện Phù Mỹ (Mỹ Châu)")]
        HuyenPhuMyMyChau,
        [Description("Huyện Phù Mỹ (Mỹ Đức)")]
        HuyenPhuMyMyDuc,
        [Description("Huyện Phù Mỹ (Mỹ Hiệp)")]
        HuyenPhuMyMyHiep,
        [Description("Huyện Phù Mỹ (Mỹ Hòa)")]
        HuyenPhuMyMyHoa,
        [Description("Huyện Phù Mỹ (Mỹ Lộc)")]
        HuyenPhuMyMyLoc,
        [Description("Huyện Phù Mỹ (Mỹ Lợi)")]
        HuyenPhuMyMyLoi,
        [Description("Huyện Phù Mỹ (Mỹ Phong)")]
        HuyenPhuMyMyPhong,
        [Description("Huyện Phù Mỹ (Mỹ Quang)")]
        HuyenPhuMyMyQuang,
        [Description("Huyện Phù Mỹ (Mỹ Tài)")]
        HuyenPhuMyMyTai,
        [Description("Huyện Phù Mỹ (Mỹ Thành )")]
        HuyenPhuMyMyThanh,
        [Description("Huyện Phù Mỹ (Mỹ Thắng)")]
        HuyenPhuMyMyThang,
        [Description("Huyện Phù Mỹ (Mỹ Thọ)")]
        HuyenPhuMyMyTho,
        [Description("Huyện Phù Mỹ (Mỹ Trinh)")]
        HuyenPhuMyMyTrinh,

        [Description("Huyện Hoài Nhơn (Thị Trấn Bồng Sơn)")]
        HuyenHoaiNhonThiTranBongSon,
        [Description("Huyện Hoài Nhơn (Hoài Châu)")]
        HuyenHoaiNhonHoaiChau,
        [Description("Huyện Hoài Nhơn (Hoài Châu Bắc)")]
        HuyenHoaiNhonHoaiChauBac,
        [Description("Huyện Hoài Nhơn (Hoài Đức)")]
        HuyenHoaiNhonHoaiDuc,
        [Description("Huyện Hoài Nhơn (Hoài Hải)")]
        HuyenHoaiNhonHoaiHai,
        [Description("Huyện Hoài Nhơn (Hoài Hảo)")]
        HuyenHoaiNhonHoaiHao,
        [Description("Huyện Hoài Nhơn (Hoài Hương)")]
        HuyenHoaiNhonHoaiHuong,
        [Description("Huyện Hoài Nhơn (Hoài Mỹ)")]
        HuyenHoaiNhonHoaiMy,
        [Description("Huyện Hoài Nhơn (Hoài Phú)")]
        HuyenHoaiNhonHoaiPhu,
        [Description("Huyện Hoài Nhơn (Hoài Sơn)")]
        HuyenHoaiNhonHoaiSon,
        [Description("Huyện Hoài Nhơn (Hoài Tân)")]
        HuyenHoaiNhonHoaiTan,
        [Description("Huyện Hoài Nhơn (Hoài Thanh)")]
        HuyenHoaiNhonHoaiThanh,
        [Description("Huyện Hoài Nhơn (Hoài Thanh Tây)")]
        HuyenHoaiNhonHoaiThanhTay,
        [Description("Huyện Hoài Nhơn (Hoài Xuân)")]
        HuyenHoaiNhonHoaiXuan,
        [Description("Huyện Hoài Nhơn (Tam Quan Bắc)")]
        HuyenHoaiNhonTamQuanBac,
        [Description("Huyện Hoài Nhơn (Tam Quan Nam)")]
        HuyenHoaiNhonTamQuanNam,
        [Description("Huyện Hoài Nhơn (Tam Quan)")]
        HuyenHoaiNhonTamQuan,

        [Description("Huyện Tây Sơn (Thị Trấn Phú Phong)")]
        HuyenTaySonThiTranPhuPhong,
        [Description("Huyện Tây Sơn (Bình Hòa)")]
        HuyenTaySonBinhHoa,
        [Description("Huyện Tây Sơn (Bình Nghi)")]
        HuyenTaySonBinhNghi,
        [Description("Huyện Tây Sơn (Bình Tân)")]
        HuyenTaySonBinhTan,
        [Description("Huyện Tây Sơn (Bình Thành)")]
        HuyenTaySonBinhThanh,
        [Description("Huyện Tây Sơn (Bình Thuận)")]
        HuyenTaySonBinhThuan,
        [Description("Huyện Tây Sơn (Bình Tường)")]
        HuyenTaySonBinhTuong,
        [Description("Huyện Tây Sơn (Tây An)")]
        HuyenTaySonTayAn,
        [Description("Huyện Tây Sơn (Tây Bình)")]
        HuyenTaySonTayBinh,
        [Description("Huyện Tây Sơn (Tây Giang)")]
        HuyenTaySonTayGiang,
        [Description("Huyện Tây Sơn (Tây Phú)")]
        HuyenTaySonTayPhu,
        [Description("Huyện Tây Sơn (Tây Thuận)")]
        HuyenTaySonTayThuan,
        [Description("Huyện Tây Sơn (Tây Vinh)")]
        HuyenTaySonTayVinh,
        [Description("Huyện Tây Sơn (Tây Xuân)")]
        HuyenTaySonTayXuan,
        [Description("Huyện Tây Sơn (Vĩnh An)")]
        HuyenTaySonVinhAn,

        [Description("Huyện  An Lão (Thị Trấn An Lão)")]
        HuyenAnLaoThiTranAnLao,
        [Description("Huyện  An Lão (An Dũng)")]
        HuyenAnLaoAnDung,
        [Description("Huyện  An Lão (An Hòa)")]
        HuyenAnLaoAnHoa,
        [Description("Huyện  An Lão (An Hưng)")]
        HuyenAnLaoAnHung,
        [Description("Huyện  An Lão (An Lão)")]
        HuyenAnLaoAnLao,
        [Description("Huyện  An Lão (An Nghĩa)")]
        HuyenAnLaoAnNghia,
        [Description("Huyện  An Lão (An Quang)")]
        HuyenAnLaoAnQuang,
        [Description("Huyện  An Lão (An Tân)")]
        HuyenAnLaoAnTan,
        [Description("Huyện  An Lão (An Toàn)")]
        HuyenAnLaoAnToan,
        [Description("Huyện  An Lão (An Trung)")]
        HuyenAnLaoAnTrung,
        [Description("Huyện  An Lão (An Vinh)")]
        HuyenAnLaoAnVinh,

        [Description("Huyện Hoài Ân (Thị Trấn Tăng Bạt Hổ)")]
        HuyenHoaiAnThiTranTangBatHo,
        [Description("Huyện Hoài Ân (Ân Đức)")]
        HuyenHoaiAnAnDuc,
        [Description("Huyện Hoài Ân (Ân Hảo Đông)")]
        HuyenHoaiAnAnHaoDong,
        [Description("Huyện Hoài Ân (Ân Hảo Tây)")]
        HuyenHoaiAnAnHaoTay,
        [Description("Huyện Hoài Ân (Ân Hữu)")]
        HuyenHoaiAnAnHuu,
        [Description("Huyện Hoài Ân (Ân Mỹ)")]
        HuyenHoaiAnAnMy,
        [Description("Huyện Hoài Ân (Ân Nghĩa)")]
        HuyenHoaiAnAnNghia,
        [Description("Huyện Hoài Ân (Ân Phong)")]
        HuyenHoaiAnAnPhong,
        [Description("Huyện Hoài Ân (Ân Sơn)")]
        HuyenHoaiAnAnSon,
        [Description("Huyện Hoài Ân (Ân Thạnh)")]
        HuyenHoaiAnAnThanh,
        [Description("Huyện Hoài Ân (Ân Tín)")]
        HuyenHoaiAnAnTin,
        [Description("Huyện Hoài Ân (Ân Tường Đông)")]
        HuyenHoaiAnAnTuongDong,
        [Description("Huyện Hoài Ân (Ân Tường Tây)")]
        HuyenHoaiAnAnTuongTay,
        [Description("Huyện Hoài Ân (Bok Tới)")]
        HuyenHoaiAnBokToi,
        [Description("Huyện Hoài Ân (Dak Mang)")]
        HuyenHoaiAnDakMang,

        [Description("Huyện Vân Canh (Thị Trấn Vân Canh)")]
        HuyenVanCanhThiTranVanCanh,
        [Description("Huyện Vân Canh (Canh Hiển)")]
        HuyenVanCanhCanhHien,
        [Description("Huyện Vân Canh (Canh Hiệp)")]
        HuyenVanCanhCanhHiep,
        [Description("Huyện Vân Canh (Canh Hòa)")]
        HuyenVanCanhCanhHoa,
        [Description("Huyện Vân Canh (Canh Liên)")]
        HuyenVanCanhCanhLien,
        [Description("Huyện Vân Canh (Canh Thuận)")]
        HuyenVanCanhCanhThuan,
        [Description("Huyện Vân Canh (Canh Vinh)")]
        HuyenVanCanhCanhVinh,

        [Description("Huyện Vĩnh Thạnh (Thị Trấn Vĩnh Thạnh)")]
        HuyenVinhThanhThiTranVinhThanh,
    }
}
