import java.io.*;

public class Cau3 {

	public static void main(String[] args) {
		try {
			String path="D:/187IT20700/taptin.txt";
			byte[] arr=null;
			File f=new File(path);
			if(f.exists()) {
				InputStream in =new FileInputStream(path);
				arr=new byte[in.available()];
				in.read(arr);
				String line =new String(arr);
				System.out.println(line);
				String[] mangChuoi=line.split(",");
				int tong=0;
				for(int i=0;i<mangChuoi.length;i++) {
					tong+=Integer.parseInt(mangChuoi[i].trim());
				}
				System.out.println("Tong cac phan tu trong mang la : "+ tong);
			}else {
				System.out.println("Khong the tim thay file!");
			}
		}catch(Exception e){
			System.out.print(e.getMessage());
		}
	}
}
