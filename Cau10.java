import java.io.File;
import java.io.FileInputStream;
import java.io.InputStream;
import java.util.Arrays;

public class Cau10 {

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
				 int mau=0;
				 int temp=0,temp1=0;
				for(int i=0;i<=mangChuoi.length-1;i++) {
					for(int j=i+1;j<mangChuoi.length;j++) {
						temp=Integer.parseInt(mangChuoi[i]);
						temp1=Integer.parseInt(mangChuoi[j]);
						if(Integer.parseInt(mangChuoi[i])>Integer.parseInt(mangChuoi[j])) {
							mau=temp1;
							temp1=temp;
							temp=mau;
						}
						System.out.print(mangChuoi[i]);
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
