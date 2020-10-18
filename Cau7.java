import java.io.File;
import java.io.FileInputStream;
import java.io.InputStream;

public class Cau7 {
	public static void main(String[] args) {
		// TODO Auto-generated method stub				int dem=0;
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
				int temp=0;
				double bien;
				int dem=0;
				for(int i=0;i<mangChuoi.length;i++) {
					temp=Integer.parseInt(mangChuoi[i]);
					if(Integer.parseInt(mangChuoi[i])==1) {
						System.out.println(Integer.parseInt(mangChuoi[i].trim())+ "là số nguyên tố");
					}else {
						for(int j=1;j<=temp;j++) {
							if(temp%j==0) {
								dem=dem+1;
							}
						}
						if(dem==2) {
							System.out.println(temp +"Là số nguyên tố");
						}
						else {
							System.out.println(temp +"Không phải là số nguyên tố");
						}if(dem!=0) {
							dem=0;
						}
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

