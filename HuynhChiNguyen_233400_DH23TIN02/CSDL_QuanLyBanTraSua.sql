-- ======================================
-- TẠO CƠ SỞ DỮ LIỆU
-- ======================================
CREATE DATABASE QUANLYBANTRASUA
GO
USE QUANLYBANTRASUA
GO
ALTER AUTHORIZATION ON DATABASE::QUANLYBANTRASUA TO SA
GO

-- ======================================
-- BẢNG TÀI KHOẢN (ĐĂNG NHẬP)
-- ======================================
CREATE TABLE TAIKHOAN
(
    TENTK VARCHAR(50) NOT NULL,
    MATKHAU VARCHAR(100) NOT NULL,
    VAITRO VARCHAR(20) NOT NULL,
	DANGNHAP BIT NOT NULL DEFAULT 0,
    TRANGTHAI NVARCHAR(20) DEFAULT N'HOAT DONG',

    CONSTRAINT PK_TK PRIMARY KEY(TENTK),
    CONSTRAINT CK_VAITRO CHECK (VAITRO IN ('ADMIN','NHANVIEN')),
    CONSTRAINT CK_TK_TRANGTHAI CHECK (TRANGTHAI IN (N'HOAT DONG',N'KHOA'))
)
GO

-- ======================================
-- BẢNG NHÂN VIÊN
-- ======================================
CREATE TABLE NHANVIEN
(
    MANV VARCHAR(10),
    TENNV NVARCHAR(100) NOT NULL,
    GIOITINH NVARCHAR(10) NOT NULL,
    NGAYSINH DATE,
    SDT VARCHAR(11),
    TENTK VARCHAR(50) NOT NULL,
    TRANGTHAI NVARCHAR(20) DEFAULT N'DANG LAM',

    CONSTRAINT PK_NV PRIMARY KEY(MANV),
	CONSTRAINT UQ_NV_SDT UNIQUE (SDT),
    CONSTRAINT CK_NV_GIOITINH CHECK (GIOITINH IN (N'NAM',N'NU')),
    CONSTRAINT CK_NV_SDT CHECK (LEN(SDT) BETWEEN 10 AND 11),
    CONSTRAINT CK_NV_TRANGTHAI CHECK (TRANGTHAI IN (N'DANG LAM',N'NGHI',N'NGHI VIEC')),
    CONSTRAINT FK_NV_TK FOREIGN KEY(TENTK) REFERENCES TAIKHOAN(TENTK)
)
GO

ALTER TABLE NHANVIEN
ADD CONSTRAINT UQ_NV_TENTK UNIQUE (TENTK)

GO
-- ======================================
-- BẢNG KHÁCH HÀNG
-- ======================================
CREATE TABLE KHACHHANG
(
    MAKH VARCHAR(10),
    TENKH NVARCHAR(100) NOT NULL,
    GIOITINH NVARCHAR(10),
    SDT VARCHAR(11),
    DIACHI NVARCHAR(200),
	TRANGTHAI BIT NOT NULL DEFAULT 1,

    CONSTRAINT PK_KH PRIMARY KEY(MAKH),
	CONSTRAINT UQ_KH_SDT UNIQUE (SDT),
    CONSTRAINT CK_KH_GIOITINH CHECK (GIOITINH IN (N'NAM',N'NU')),
    CONSTRAINT CK_KH_SDT CHECK (LEN(SDT) BETWEEN 10 AND 11)
)
GO


-- ======================================
-- BẢNG LOẠI TRÀ SỮA
-- ======================================
CREATE TABLE LOAITRASUA
(
    MALOAITS VARCHAR(10),
    TENLOAI NVARCHAR(100) NOT NULL,
	TRANGTHAI BIT NOT NULL DEFAULT 1,

    CONSTRAINT PK_LOAITRASUA PRIMARY KEY(MALOAITS)
)
GO

-- ======================================
-- BẢNG TRÀ SỮA
-- ======================================
CREATE TABLE TRASUA
(
    MATS VARCHAR(10),
    TENTS NVARCHAR(100) NOT NULL,
    DONGIA DECIMAL(18,2) NOT NULL,
    MALOAITS VARCHAR(10),
	TRANGTHAI BIT NOT NULL DEFAULT 1,

    CONSTRAINT PK_TS PRIMARY KEY(MATS),
    CONSTRAINT CK_TS_GIA CHECK (DONGIA > 0),
    CONSTRAINT FK_TS_LOAI FOREIGN KEY(MALOAITS) REFERENCES LOAITRASUA(MALOAITS)
)
GO

-- ======================================
-- BẢNG KHUYẾN MÃI
-- ======================================

CREATE TABLE KHUYENMAI
(
    MAKM VARCHAR(10),
    TENKM NVARCHAR(100) NOT NULL,
    PHANTRAMGIAM INT NOT NULL,
    NGAYBATDAU DATE NOT NULL,
    NGAYKETTHUC DATE NOT NULL,
    TRANGTHAI NVARCHAR(20) DEFAULT N'HOAT DONG',

    CONSTRAINT PK_KM PRIMARY KEY(MAKM),
    CONSTRAINT CK_KM_PHANTRAM CHECK (PHANTRAMGIAM BETWEEN 1 AND 100),
    CONSTRAINT CK_KM_NGAY CHECK (NGAYKETTHUC >= NGAYBATDAU),
    CONSTRAINT CK_KM_TRANGTHAI CHECK (TRANGTHAI IN (N'HOAT DONG',N'HET HAN',N'TAM DUNG'))
)
GO

-- ======================================
-- BẢNG HÓA ĐƠN
-- ======================================
CREATE TABLE HOADON
(
    MAHD INT IDENTITY PRIMARY KEY,
    NGAYLAP DATETIME DEFAULT GETDATE(),
    MANV VARCHAR(10),
    MAKH VARCHAR(10),
	MAKM VARCHAR(10) NULL,
    GIAMGIA DECIMAL(18,2) DEFAULT 0,
    TONGTIEN DECIMAL(18,2) DEFAULT 0,
	THANHTOAN DECIMAL(18,2) DEFAULT 0,
    TRANGTHAI NVARCHAR(30) DEFAULT N'CHUA THANH TOAN',

	CONSTRAINT CK_HD_TONGTIEN CHECK (TONGTIEN >= 0),
    CONSTRAINT CK_HD_GIAMGIA CHECK (GIAMGIA >= 0),
    CONSTRAINT CK_HD_THANHTOAN CHECK (THANHTOAN >= 0),
    CONSTRAINT FK_HD_NV FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV),
    CONSTRAINT FK_HD_KH FOREIGN KEY(MAKH) REFERENCES KHACHHANG(MAKH),
	CONSTRAINT FK_HD_KM FOREIGN KEY(MAKM) REFERENCES KHUYENMAI(MAKM),
    CONSTRAINT CK_HD_TRANGTHAI CHECK (TRANGTHAI IN (N'CHUA THANH TOAN',N'DA THANH TOAN',N'HUY'))
)
GO

-- ======================================
-- BẢNG CHI TIẾT HÓA ĐƠN
-- ======================================
CREATE TABLE CHITIETHOADON
(
    MAHD INT,
    MATS VARCHAR(10),
    SOLUONG INT NOT NULL,
    DONGIA DECIMAL(18,2) NOT NULL DEFAULT 0,
    THANHTIEN DECIMAL(18,2) NOT NULL DEFAULT 0,

    CONSTRAINT PK_CTHD PRIMARY KEY(MAHD,MATS),
	CONSTRAINT CK_CTHD_THANHTIEN CHECK (THANHTIEN >= 0),
    CONSTRAINT FK_CTHD_HD FOREIGN KEY(MAHD) REFERENCES HOADON(MAHD),
    CONSTRAINT FK_CTHD_TS FOREIGN KEY(MATS) REFERENCES TRASUA(MATS),
    CONSTRAINT CK_SOLUONG CHECK (SOLUONG > 0)
)
GO

-- ======================================
-- BẢNG NHẬT KÝ HỆ THỐNG
-- ======================================
CREATE TABLE NHATKY
(
    ID INT IDENTITY PRIMARY KEY,
    THOIGIAN DATETIME DEFAULT GETDATE(),
    TENTK VARCHAR(50),
    HANHDONG NVARCHAR(200),
	PHANLOAI NVARCHAR(50),

	CONSTRAINT FK_NK_TK FOREIGN KEY(TENTK) REFERENCES TAIKHOAN(TENTK) ON DELETE CASCADE
)
GO

-- ======================================
-- TẠO SEQUENCE – BỘ SINH MÃ TỰ ĐỘNG  
-- ======================================

CREATE SEQUENCE SEQ_NV START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE SEQ_KH START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE SEQ_TS START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE SEQ_LTS START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE SEQ_KM START WITH 1 INCREMENT BY 1;
GO

-- ======================================
-- TỰ SINH MÃ NHÂN VIÊN
-- ======================================

CREATE TRIGGER TRG_NV_MA ON NHANVIEN
INSTEAD OF INSERT
AS
BEGIN
    INSERT INTO NHANVIEN
    SELECT 
        'NV' + RIGHT('00000000' + CAST(NEXT VALUE FOR SEQ_NV AS VARCHAR), 8),
        TENNV, GIOITINH, NGAYSINH, SDT, TENTK, TRANGTHAI
    FROM INSERTED
END
GO

-- ======================================
-- TỰ SINH MÃ KHÁCH HÀNG
-- ======================================

CREATE TRIGGER TRG_KH_MA ON KHACHHANG
INSTEAD OF INSERT
AS
BEGIN
    INSERT INTO KHACHHANG
    SELECT 
        'KH' + RIGHT('00000000' + CAST(NEXT VALUE FOR SEQ_KH AS VARCHAR), 8),
        TENKH, GIOITINH, SDT, DIACHI,TRANGTHAI
    FROM INSERTED
END
GO


-- ======================================
-- TỰ SINH MÃ TRÀ SỮA
-- ======================================

CREATE TRIGGER TRG_TS_MA ON TRASUA
INSTEAD OF INSERT
AS
BEGIN
    INSERT INTO TRASUA
    SELECT 
        'TS' + RIGHT('00000000' + CAST(NEXT VALUE FOR SEQ_TS AS VARCHAR), 8),
        TENTS, DONGIA, MALOAITS, TRANGTHAI
    FROM INSERTED
END
GO


-- ======================================
-- TỰ SINH MÃ LOẠI TRÀ SỮA
-- ======================================


CREATE TRIGGER TRG_LTS_MA ON LOAITRASUA
INSTEAD OF INSERT
AS
BEGIN
    INSERT INTO LOAITRASUA
    SELECT 
        'LTS' + RIGHT('0000000' + CAST(NEXT VALUE FOR SEQ_LTS AS VARCHAR), 7),
        TENLOAI, TRANGTHAI
    FROM INSERTED
END
GO

-- ======================================
-- TỰ SINH MÃ KHUYẾN MÃI
-- ======================================

CREATE TRIGGER TRG_KM_MA ON KHUYENMAI
INSTEAD OF INSERT
AS
BEGIN
    INSERT INTO KHUYENMAI
    SELECT 
        'KM' + RIGHT('00000000' + CAST(NEXT VALUE FOR SEQ_KM AS VARCHAR), 8),
        TENKM, PHANTRAMGIAM, NGAYBATDAU, NGAYKETTHUC, TRANGTHAI
    FROM INSERTED
END
GO

-- ================================================================
-- TỰ ĐỘNG CẬP NHẬT THÀNH TIỀN TRONG HÓA ĐƠN SAU KHI KHUYẾN MÃI
-- ================================================================

CREATE TRIGGER TRG_HD_TINHTIEN
ON CHITIETHOADON
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @DSHD TABLE (MAHD INT);

    INSERT INTO @DSHD
    SELECT MAHD FROM INSERTED
    UNION
    SELECT MAHD FROM DELETED;

    /* 1. Cập nhật đơn giá & thành tiền (chỉ hóa đơn chưa thanh toán) */
    UPDATE C
    SET 
        C.DONGIA = TS.DONGIA,
        C.THANHTIEN = C.SOLUONG * TS.DONGIA
    FROM CHITIETHOADON C
    JOIN TRASUA TS ON C.MATS = TS.MATS
    JOIN HOADON H ON C.MAHD = H.MAHD
    WHERE C.MAHD IN (SELECT MAHD FROM @DSHD)
      AND H.TRANGTHAI = N'CHUA THANH TOAN';

    /* 2. Cập nhật tổng tiền */
    UPDATE H
    SET H.TONGTIEN = ISNULL((
        SELECT SUM(THANHTIEN)
        FROM CHITIETHOADON
        WHERE MAHD = H.MAHD
    ),0)
    FROM HOADON H
    WHERE H.MAHD IN (SELECT MAHD FROM @DSHD)
      AND H.TRANGTHAI = N'CHUA THANH TOAN';

    /* 3. Tính giảm giá */
    UPDATE H
    SET H.GIAMGIA = ISNULL((
        SELECT H.TONGTIEN * KM.PHANTRAMGIAM / 100
        FROM KHUYENMAI KM
        WHERE KM.MAKM = H.MAKM
          AND KM.TRANGTHAI = N'HOAT DONG'
          AND GETDATE() BETWEEN KM.NGAYBATDAU AND KM.NGAYKETTHUC
    ),0)
    FROM HOADON H
    WHERE H.MAHD IN (SELECT MAHD FROM @DSHD)
      AND H.TRANGTHAI = N'CHUA THANH TOAN';

    /* 4. Tính tiền phải trả */
    UPDATE H
    SET H.THANHTOAN = H.TONGTIEN - H.GIAMGIA
    FROM HOADON H
    WHERE H.MAHD IN (SELECT MAHD FROM @DSHD)
      AND H.TRANGTHAI = N'CHUA THANH TOAN';
END
GO

-- =========================================
-- KHÓA CHI TIẾT HÓA ĐƠN KHI ĐÃ THANH TOÁN
-- =========================================

CREATE TRIGGER TRG_KHONG_SUA_CTHD_DATHANHTOAN
ON CHITIETHOADON
INSTEAD OF UPDATE, DELETE
AS
BEGIN
    IF EXISTS (
        SELECT 1 
        FROM HOADON H
        JOIN (
            SELECT MAHD FROM INSERTED
            UNION
            SELECT MAHD FROM DELETED
        ) X ON H.MAHD = X.MAHD
        WHERE H.TRANGTHAI <> N'CHUA THANH TOAN'
    )
    BEGIN
        RAISERROR(N'Hóa đơn đã thanh toán, không thể chỉnh sửa!',16,1)
        RETURN
    END

    -- nếu hợp lệ thì cho phép thao tác
    IF EXISTS(SELECT * FROM INSERTED)
        UPDATE C SET SOLUONG = I.SOLUONG
        FROM CHITIETHOADON C JOIN INSERTED I
        ON C.MAHD = I.MAHD AND C.MATS = I.MATS

    IF EXISTS(SELECT * FROM DELETED)
        DELETE C FROM CHITIETHOADON C
        JOIN DELETED D ON C.MAHD = D.MAHD AND C.MATS = D.MATS
END

GO
-- ===============================================================================================================
-- KHI ĐỔI TRẠNG THÁI LOẠI TRÀ SỮA LÀ NGỪNG BÁN THÌ CÁC MÓN TRÀ SỮA TRONG LOẠI ĐÓ SẼ ĐỔI TRẠNG THÁI VỀ NGỪNG BÁN
-- ===============================================================================================================

CREATE TRIGGER trg_NgungBanLoai
ON LOAITRASUA
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE T
    SET T.TRANGTHAI = 0
    FROM TRASUA T
    JOIN inserted i ON T.MALOAITS = i.MALOAITS
    JOIN deleted d ON i.MALOAITS = d.MALOAITS
    WHERE i.TRANGTHAI = 0      -- trạng thái mới là ngừng bán
      AND d.TRANGTHAI = 1;     -- trạng thái cũ là còn bán
END

GO
-- =============================================
-- KHÔNG BÁN MÓN ĐÃ NGỪNG BÁN
-- =============================================

CREATE TRIGGER TRG_KHONG_BAN_TS_NGUNGBAN
ON CHITIETHOADON
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- 1. Không cho thêm món đã ngừng bán
    IF EXISTS (
        SELECT 1
        FROM INSERTED I
        JOIN TRASUA T ON I.MATS = T.MATS
        WHERE T.TRANGTHAI = 0
    )
    BEGIN
        RAISERROR(N'Món này đã ngừng bán!',16,1)
        RETURN;
    END

    -- 2. Không cho thêm vào hóa đơn đã thanh toán
    IF EXISTS (
        SELECT 1
        FROM INSERTED I
        JOIN HOADON H ON I.MAHD = H.MAHD
        WHERE H.TRANGTHAI <> N'CHUA THANH TOAN'
    )
    BEGIN
        PRINT N'Hóa đơn đã thanh toán — không thể thêm món!';
        RETURN;
    END

    -- 3. Nếu hợp lệ thì cho insert
    INSERT INTO CHITIETHOADON (MAHD, MATS, SOLUONG)
    SELECT MAHD, MATS, SOLUONG
    FROM INSERTED;
END
GO

-- =============================================
-- KHI ĐỔI KHUYẾN MÃI TỰ ĐỘNG CẬP NHẬT GIÁ TIỀN
-- =============================================

CREATE TRIGGER TRG_HD_DOIKM
ON HOADON
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF UPDATE(MAKM)
    BEGIN
        UPDATE H
        SET 
            H.GIAMGIA = 
                CASE 
                    WHEN KM.TRANGTHAI = N'HOAT DONG'
                     AND GETDATE() BETWEEN KM.NGAYBATDAU AND KM.NGAYKETTHUC
                    THEN H.TONGTIEN * KM.PHANTRAMGIAM / 100
                    ELSE 0
                END,

            H.THANHTOAN = 
                H.TONGTIEN - 
                CASE 
                    WHEN KM.TRANGTHAI = N'HOAT DONG'
                     AND GETDATE() BETWEEN KM.NGAYBATDAU AND KM.NGAYKETTHUC
                    THEN H.TONGTIEN * KM.PHANTRAMGIAM / 100
                    ELSE 0
                END
        FROM HOADON H
        JOIN INSERTED I ON H.MAHD = I.MAHD
        LEFT JOIN KHUYENMAI KM ON I.MAKM = KM.MAKM
        WHERE H.TRANGTHAI = N'CHUA THANH TOAN';
    END
END
GO
-- ========================================================================================================================
-- TỰ ĐỘNG CẬP NHẬT THÀNH TIỀN TRONG HÓA ĐƠN SAU KHI GIÁ KHUYẾN MÃI ĐƯỢC CHỈNH SỬA LẠI CHO CÁC HÓA ĐƠN CHƯA ĐƯỢC THANH TOÁN
-- ========================================================================================================================

CREATE TRIGGER TRG_KM_UPDATE_RECALC
ON KHUYENMAI
AFTER UPDATE
AS
BEGIN
    IF UPDATE(PHANTRAMGIAM) OR UPDATE(NGAYBATDAU) OR UPDATE(NGAYKETTHUC) OR UPDATE(TRANGTHAI)
    BEGIN
        UPDATE H
        SET 
            H.GIAMGIA = 
                CASE 
                    WHEN KM.TRANGTHAI = N'HOAT DONG'
                     AND GETDATE() BETWEEN KM.NGAYBATDAU AND KM.NGAYKETTHUC
                    THEN H.TONGTIEN * KM.PHANTRAMGIAM / 100
                    ELSE 0
                END,
            H.THANHTOAN = 
                H.TONGTIEN - 
                CASE 
                    WHEN KM.TRANGTHAI = N'HOAT DONG'
                     AND GETDATE() BETWEEN KM.NGAYBATDAU AND KM.NGAYKETTHUC
                    THEN H.TONGTIEN * KM.PHANTRAMGIAM / 100
                    ELSE 0
                END
        FROM HOADON H
        JOIN INSERTED KM ON H.MAKM = KM.MAKM
        WHERE H.TRANGTHAI = N'CHUA THANH TOAN';
    END
END
GO

-- ======================================
-- TỰ ĐỘNG CẬP NHẬT NHẬT KÝ
-- ======================================

/* ================================
   LOG KHI TÀI KHOẢN ĐĂNG NHẬP
   PHANLOAI = LOGIN
================================ */
CREATE TRIGGER TRG_TK_LOGIN_LOG
ON TAIKHOAN
AFTER UPDATE
AS
BEGIN
    IF UPDATE(DANGNHAP)
    BEGIN
        INSERT INTO NHATKY(TENTK, PHANLOAI, HANHDONG)
        SELECT I.TENTK, N'LOGIN', N'Đăng nhập hệ thống'
        FROM INSERTED I
        JOIN DELETED D ON I.TENTK = D.TENTK
        WHERE D.DANGNHAP = 0 AND I.DANGNHAP = 1
    END
END
GO


/* ================================
   LOG KHI TÀI KHOẢN ĐĂNG XUẤT
   PHANLOAI = LOGIN
================================ */

CREATE TRIGGER TRG_TK_LOGOUT_LOG
ON TAIKHOAN
AFTER UPDATE
AS
BEGIN
    IF UPDATE(DANGNHAP)
    BEGIN
        INSERT INTO NHATKY(TENTK, PHANLOAI, HANHDONG)
        SELECT I.TENTK, N'LOGIN', N'Đăng xuất hệ thống'
        FROM INSERTED I
        JOIN DELETED D ON I.TENTK = D.TENTK
        WHERE D.DANGNHAP = 1 AND I.DANGNHAP = 0
    END
END
GO

/* ================================
   LOG KHI TẠO TÀI KHOẢN
   PHANLOAI = TAIKKHOAN
================================ */

CREATE TRIGGER TRG_TK_INSERT_LOG
ON TAIKHOAN
AFTER INSERT
AS
BEGIN
    DECLARE @UserThucHien VARCHAR(50) = CAST(SESSION_CONTEXT(N'USER') AS VARCHAR(50));

    INSERT INTO NHATKY(TENTK, PHANLOAI, HANHDONG)
    SELECT 
        @UserThucHien,
        N'TAIKHOAN',
        N'Tạo tài khoản mới (' + I.VAITRO + N')'
    FROM INSERTED I;
END
GO


/* ================================
   KHÓA / MỞ KHÓA TÀI KHOẢN
   PHANLOAI = TAIKHOAN
================================ */
CREATE TRIGGER TRG_TK_UPDATE_STATUS_LOG
ON TAIKHOAN
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF UPDATE(TRANGTHAI)
    BEGIN
        INSERT INTO NHATKY(TENTK, PHANLOAI, HANHDONG)
        SELECT TK.TENTK, N'TAIKHOAN',
               N'Tài khoản ' + I.TENTK + N' → ' + I.TRANGTHAI
        FROM INSERTED I
        JOIN TAIKHOAN TK ON TK.VAITRO = 'ADMIN'
        WHERE TK.DANGNHAP = 1;
    END
END
GO

/* ================================
   NGỪNG BÁN LOẠI TRÀ SỮA
   PHANLOAI = SANPHAM
================================ */
CREATE TRIGGER TRG_LTS_UPDATE_LOG
ON LOAITRASUA
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF UPDATE(TRANGTHAI)
    BEGIN
        INSERT INTO NHATKY(TENTK, PHANLOAI, HANHDONG)
        SELECT TK.TENTK, N'SANPHAM',
               N'Loại trà sữa ' + I.TENLOAI + N' → Ngừng bán'
        FROM INSERTED I
        JOIN TAIKHOAN TK ON TK.VAITRO = 'ADMIN'
        WHERE TK.DANGNHAP = 1 AND I.TRANGTHAI = 0;
    END
END
GO

/* ================================
   NHÂN VIÊN TẠO HÓA ĐƠN
   PHANLOAI = HOADON
================================ */

CREATE TRIGGER TRG_HD_INSERT_LOG
ON HOADON
AFTER INSERT
AS
BEGIN
    INSERT INTO NHATKY(TENTK, PHANLOAI, HANHDONG)
    SELECT NV.TENTK, N'HOADON',
           N'Tạo hóa đơn #' + CAST(I.MAHD AS NVARCHAR)
    FROM INSERTED I
    JOIN NHANVIEN NV ON I.MANV = NV.MANV
END
GO


/* ================================
   CẬP NHẬT TRẠNG THÁI HÓA ĐƠN
   PHANLOAI = HOADON
================================ */

CREATE TRIGGER TRG_HD_UPDATE_LOG
ON HOADON
AFTER UPDATE
AS
BEGIN
    IF UPDATE(TRANGTHAI)
    BEGIN
        INSERT INTO NHATKY(TENTK, PHANLOAI, HANHDONG)
        SELECT NV.TENTK, N'HOADON',
               N'Cập nhật hóa đơn #' + CAST(I.MAHD AS NVARCHAR)
               + N' → ' + I.TRANGTHAI
        FROM INSERTED I
        JOIN NHANVIEN NV ON I.MANV = NV.MANV
    END
END
GO

/* ================================
   CẬP NHẬT TRẠNG THÁI HÓA ĐƠN
   PHANLOAI = HOADON
   (HỦY / THANH TOÁN / THAY ĐỔI TRẠNG THÁI)
================================ */
ALTER TRIGGER TRG_HD_UPDATE_LOG
ON HOADON
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF UPDATE(TRANGTHAI)
    BEGIN
        INSERT INTO NHATKY(TENTK, PHANLOAI, HANHDONG)
        SELECT NV.TENTK, N'HOADON',
               N'Hóa đơn #' + CAST(I.MAHD AS NVARCHAR)
               + CASE 
                    WHEN I.TRANGTHAI = N'HUY' THEN N' đã bị HỦY'
                    WHEN I.TRANGTHAI = N'DA THANH TOAN' THEN N' đã THANH TOÁN'
                    ELSE N' cập nhật trạng thái → ' + I.TRANGTHAI
                 END
        FROM INSERTED I
        JOIN NHANVIEN NV ON I.MANV = NV.MANV;
    END
END
GO


/* ================================
   THÊM MÓN VÀO HÓA ĐƠN
   PHANLOAI = BANHANG
================================ */

CREATE TRIGGER TRG_CTHD_INSERT_LOG
ON CHITIETHOADON
AFTER INSERT
AS
BEGIN
    INSERT INTO NHATKY(TENTK, PHANLOAI, HANHDONG)
    SELECT NV.TENTK, N'BANHANG',
           N'Thêm ' + TS.TENTS + N' x' + CAST(I.SOLUONG AS NVARCHAR)
           + N' vào hóa đơn #' + CAST(I.MAHD AS NVARCHAR)
    FROM INSERTED I
    JOIN HOADON H ON I.MAHD = H.MAHD
    JOIN NHANVIEN NV ON H.MANV = NV.MANV
    JOIN TRASUA TS ON I.MATS = TS.MATS
END
GO


/* ================================
   ADMIN THÊM NHÂN VIÊN
   PHANLOAI = NHANVIEN
================================ */

CREATE TRIGGER TRG_NV_INSERT_LOG
ON NHANVIEN
AFTER INSERT
AS
BEGIN
    INSERT INTO NHATKY(TENTK, PHANLOAI, HANHDONG)
    SELECT TK.TENTK, N'NHANVIEN',
           N'Thêm nhân viên ' + I.TENNV + N' (' + I.MANV + N')'
    FROM INSERTED I
    JOIN TAIKHOAN TK ON TK.VAITRO = 'ADMIN'
    WHERE TK.DANGNHAP = 1
END
GO


/* ================================
   ADMIN CẬP NHẬT TRẠNG THÁI NHÂN VIÊN
   PHANLOAI = NHANVIEN
================================ */

CREATE TRIGGER TRG_NV_UPDATE_LOG
ON NHANVIEN
AFTER UPDATE
AS
BEGIN
    IF UPDATE(TRANGTHAI)
    BEGIN
        INSERT INTO NHATKY(TENTK, PHANLOAI, HANHDONG)
        SELECT TK.TENTK, N'NHANVIEN',
               N'Cập nhật ' + I.TENNV + N' → ' + I.TRANGTHAI
        FROM INSERTED I
        JOIN TAIKHOAN TK ON TK.VAITRO = 'ADMIN'
        WHERE TK.DANGNHAP = 1
    END
END
GO


/* ================================
   ADMIN CẬP NHẬT GIÁ TRÀ SỮA
   PHANLOAI = SANPHAM
================================ */

CREATE TRIGGER TRG_TS_UPDATE_LOG
ON TRASUA
AFTER UPDATE
AS
BEGIN
    IF UPDATE(DONGIA)
    BEGIN
        INSERT INTO NHATKY(TENTK, PHANLOAI, HANHDONG)
        SELECT TK.TENTK, N'SANPHAM',
               N'Đổi giá ' + D.TENTS + N': ' 
               + CAST(D.DONGIA AS NVARCHAR) + N' → ' + CAST(I.DONGIA AS NVARCHAR)
        FROM INSERTED I
        JOIN DELETED D ON I.MATS = D.MATS
        JOIN TAIKHOAN TK ON TK.VAITRO = 'ADMIN'
        WHERE TK.DANGNHAP = 1
    END
END
GO


/* ================================
   ADMIN TẠO KHUYẾN MÃI
   PHANLOAI = KHUYENMAI
================================ */

CREATE TRIGGER TRG_KM_INSERT_LOG
ON KHUYENMAI
AFTER INSERT
AS
BEGIN
    INSERT INTO NHATKY(TENTK, PHANLOAI, HANHDONG)
    SELECT TK.TENTK, N'KHUYENMAI',
           N'Tạo KM ' + I.TENKM + N' (-' + CAST(I.PHANTRAMGIAM AS NVARCHAR) + N'%)'
    FROM INSERTED I
    JOIN TAIKHOAN TK ON TK.VAITRO = 'ADMIN'
    WHERE TK.DANGNHAP = 1
END
GO


/* ================================
   NHÂN VIÊN THÊM KHÁCH HÀNG
   PHANLOAI = KHACHHANG
================================ */

CREATE TRIGGER TRG_KH_INSERT_LOG
ON KHACHHANG
AFTER INSERT
AS
BEGIN
    INSERT INTO NHATKY(TENTK, PHANLOAI, HANHDONG)
    SELECT TK.TENTK, N'KHACHHANG',
           N'Thêm khách hàng ' + I.TENKH
    FROM INSERTED I
    JOIN TAIKHOAN TK ON TK.VAITRO = 'NHANVIEN'
    WHERE TK.DANGNHAP = 1
END
GO

/* ================================
   NHÂN VIÊN XÓA KHÁCH HÀNG (XÓA MỀM)
   PHANLOAI = KHACHHANG
================================ */

CREATE TRIGGER TRG_KH_UPDATE_LOG
ON KHACHHANG
AFTER UPDATE
AS
BEGIN
    IF UPDATE(TRANGTHAI)
    BEGIN
        INSERT INTO NHATKY(TENTK, PHANLOAI, HANHDONG)
        SELECT TK.TENTK, N'KHACHHANG',
               N'Khóa khách hàng ' + I.TENKH
        FROM INSERTED I
        JOIN DELETED D ON I.MAKH = D.MAKH
        JOIN TAIKHOAN TK ON TK.DANGNHAP = 1
        WHERE D.TRANGTHAI = 1 AND I.TRANGTHAI = 0;
    END
END

GO
-- ======================================
-- THÊM THÔNG TIN TAIKHOAN
-- ======================================

INSERT INTO TAIKHOAN (TENTK, MATKHAU, VAITRO, DANGNHAP, TRANGTHAI)
VALUES
('admin','123','ADMIN',0,N'HOAT DONG'),
('nv01','123','NHANVIEN',0,N'HOAT DONG'),
('nv02','123','NHANVIEN',0,N'HOAT DONG'),
('nv03','123','NHANVIEN',0,N'HOAT DONG'),
('nv04','123','NHANVIEN',0,N'HOAT DONG');
GO

-- ======================================
-- THÊM THÔNG TIN NHÂN VIÊN
-- ======================================

INSERT INTO NHANVIEN(TENNV, GIOITINH, NGAYSINH, SDT, TENTK)
VALUES
(N'Trần Thị Bích Ngọc', N'NU', '2001-08-15', '0913456789', 'nv01'),
(N'Nguyễn Văn Phúc', N'NAM', '2000-03-10', '0914567890', 'nv02'),
(N'Lê Thị Mỹ Duyên', N'NU', '2002-11-22', '0915678901', 'nv03'),
(N'Phạm Hoàng Long', N'NAM', '1999-06-30', '0916789012', 'nv04'),
(N'Huỳnh Chí Nguyện', N'NAM', '2005-06-01', '0794307378', 'admin');
GO

-- ======================================
-- THÊM THÔNG TIN KHÁCH HÀNG
-- ======================================

INSERT INTO KHACHHANG(TENKH, GIOITINH, SDT, DIACHI,TRANGTHAI)
VALUES
(N'Nguyễn Minh Khoa', N'NAM', '0931111111', N'Cà Mau',1),
(N'Lâm Thị Tuyết Mai', N'NU', '0932222222', N'Bạc Liêu',1),
(N'Trần Hoàng Duy', N'NAM', '0933333333', N'Cần Thơ',1),
(N'Phan Ngọc Ánh', N'NU', '0934444444', N'Sóc Trăng',1),
(N'Võ Thanh Tùng', N'NAM', '0935555555', N'Hậu Giang',1);
GO

-- ======================================
-- THÊM THÔNG TIN LOẠI TRÀ SỮA
-- ======================================

INSERT INTO LOAITRASUA(TENLOAI,TRANGTHAI)
VALUES
(N'Trà sữa truyền thống',1),
(N'Trà sữa trái cây',1),
(N'Trà sữa kem cheese',1),
(N'Trà sữa matcha',1),
(N'Trà sữa socola',1);
GO

-- ======================================
-- THÊM THÔNG TIN TRÀ SỮA
-- ======================================

INSERT INTO TRASUA(TENTS, DONGIA, MALOAITS, TRANGTHAI)
VALUES
(N'Trà sữa trân châu đường đen', 32000, 'LTS0000001',1),
(N'Trà sữa xoài kem cheese', 35000, 'LTS0000002',1),
(N'Trà sữa matcha Nhật Bản', 36000, 'LTS0000004',1),
(N'Trà sữa socola Oreo', 34000, 'LTS0000005',1),
(N'Trà sữa dâu tây macchiato', 37000, 'LTS0000002',1);
GO

-- ======================================
-- THÊM THÔNG TIN KHUYẾN MÃI
-- ======================================

INSERT INTO KHUYENMAI(TENKM,PHANTRAMGIAM,NGAYBATDAU,NGAYKETTHUC)
VALUES
(N'Giảm 10%',10,GETDATE(),DATEADD(DAY,10,GETDATE())),
(N'Giảm 15%',15,GETDATE(),DATEADD(DAY,10,GETDATE())),
(N'Giảm 20%',20,GETDATE(),DATEADD(DAY,10,GETDATE())),
(N'Giảm 25%',25,GETDATE(),DATEADD(DAY,10,GETDATE())),
(N'Giảm 30%',30,GETDATE(),DATEADD(DAY,10,GETDATE()));
GO
