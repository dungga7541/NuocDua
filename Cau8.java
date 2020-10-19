import java.io.File;
import java.io.FileInputStream;
import java.io.InputStream;

public class Cau8 {

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
				for(int i=0;i<mangChuoi.length;i++) {
					int min=Integer.parseInt(mangChuoi[0]);
					int max=Integer.parseInt(mangChuoi[0]);
					for(int j=0;j<mangChuoi.length;j++) {
						if(Integer.parseInt(mangChuoi[j])<min) {
							min=Integer.parseInt((mangChuoi[j]));
						}
						if(Integer.parseInt(mangChuoi[j])>max) {
							max=Integer.parseInt((mangChuoi[j]));
						}
					}
				System.out.println("Vậy số nhỏ nhất là:"+min);
				System.out.println("Vậy số lớn nhất là:"+max);
				break;
				}
				
			}else {
				System.out.println("Khong the tim thay file!");
			}
		}catch(Exception e){
			System.out.print(e.getMessage());
		}
	}

}
