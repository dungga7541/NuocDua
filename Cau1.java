import java.io.*;

public class Cau1 {

	public static void main(String[] args)throws IOException  {
		// TODO Auto-generated method stub
		String tenThuMuc = "D:/187IT20700";
        File f=new File(tenThuMuc);
        if(!f.exists()) {
        	f.mkdirs();
            System.out.print("Da tao file thanh cong!");
        }
        else {
            System.out.print("Tao file that bai");
        }
	}
}
