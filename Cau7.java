import java.io.File;
import java.io.FileInputStream;
import java.io.InputStream;

public class Cau7 {

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
				double temp=0;
				double bien;
				int dem=0;
				for(int i=0;i<mangChuoi.length;i++) {
					System.out.print(Integer.parseInt(mangChuoi[i].trim()));
					if(Integer.parseInt(mangChuoi[i].trim())==1) {
						System.out.println(Integer.parseInt(mangChuoi[i].trim())+ "là số nguyên tố");
					}else {
						System.out.println(temp);
						
						for(i=1;i<=temp;i++) {
							if(temp%i==0) {
								dem++;
							}
						}
						if(dem==2) {
							System.out.println(temp +"Là số nguyên tố");
						}
						else {
							System.out.println(temp +"Không phải là số nguyên tố");
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

