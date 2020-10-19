import java.io.File;
import java.io.FileInputStream;
import java.io.InputStream;

public class Cau9 {

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
				int tong=0;
				int temp=0;
				boolean ketqua;
				for(int i=0;i<mangChuoi.length;i++) {
					temp=Integer.parseInt(mangChuoi[i]);
					double sq=Math.sqrt(temp);
					ketqua = ((sq - Math.floor(sq))==0);
					if(ketqua==true) {
						System.out.println(temp + " la so chinh phuong");
					}else{
						System.out.println(temp + " Khong phai la so chinh phuong");
					}
				}
				
			}else {
				System.out.println("Khong the tim thay file!");
			}
		}catch(Exception e){
			System.out.print(e.getMessage());
		}
	}

}
