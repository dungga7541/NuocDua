import java.io.File;
import java.io.FileInputStream;
import java.io.InputStream;

public class Cau6 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		try {
			String path="E:/187IT20700/taptin.txt";
			byte[] arr=null;
			File f=new File(path);
			if(f.exists()) {
				InputStream in =new FileInputStream(path);
				arr=new byte[in.available()];
				in.read(arr);
				String line =new String(arr);
				System.out.println(line);
				String[] mangChuoi=line.split(",");
				int tongle=0;
				for(int i=0;i<mangChuoi.length;i++) {
					if(Integer.parseInt(mangChuoi[i].trim())%2!=0) {
						tongle+=Integer.parseInt(mangChuoi[i].trim());						
					};
				}
				System.out.println("Tong cac phan tu le trong mang la : "+tongle);
			}else {
				System.out.println("Khong the tim thay file!");
			}
		}catch(Exception e){
			System.out.print(e.getMessage());
		}
	}

}
