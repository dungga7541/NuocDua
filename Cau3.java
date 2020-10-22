import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.geom.Ellipse2D;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JFrame;

public class Cau3 extends JPanel {

	private void doDrawing(Graphics g) {
		 
        Graphics2D g2d = (Graphics2D) g;
 
        g2d.setPaint(new Color(255, 102, 0));
 
        g2d.fillOval(70, 30, 150, 150);
   } 
 
	@Override
    public void paintComponent(Graphics g) {
        
        super.paintComponent(g);
        doDrawing(g);
    }    
     
	public static void main(String[] args) {
		Cau3 cau3 = new Cau3();
		JFrame app = new JFrame("Hinh Tron");
		app.add(cau3, BorderLayout.CENTER);
		app.setSize(300,300);
		app.setLocationRelativeTo(null);
		app.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		app.setVisible(true);
	}
}


