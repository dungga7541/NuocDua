import java.io.File;
import java.io.IOException;

public class Cau2 {

	    public static void main(String[] args) throws IOException {
	        File file = null;
	        boolean isCreat = false;
	        try{
	            file = new File("D:/187IT20700/taptin.txt");
	            //Ở đây mình tạo file trong ổ D
	            isCreat = file.createNewFile();
	            if (isCreat)
	                System.out.print("Da tao file thanh cong!");
	            else
	                System.out.print("Tao file that bai");
	            //file.delete();
	        }
	        catch (Exception e){
	            System.out.print(e);
	        }
	    }
	}

