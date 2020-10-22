import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Graphics;
import java.awt.Graphics2D;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JFrame;

public class Cau4a extends JPanel {

	private void doDrawing(Graphics g) {
		 
        Graphics2D g2d = (Graphics2D) g;
 
        g2d.setPaint(new Color(255, 102, 0));
 
        g2d.fillRoundRect(50, 60, 100, 60, 25, 25);
        } 
 
	@Override
    public void paintComponent(Graphics g) {
        
        super.paintComponent(g);
        doDrawing(g);
    }    
     
	public static void main(String[] args) {
		Cau4a cau4a = new Cau4a();
		JFrame app = new JFrame("Hinh Chu Nhat Bo Goc");
		app.add(cau4a, BorderLayout.CENTER);
		app.setSize(300,300);
		app.setLocationRelativeTo(null);
		app.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		app.setVisible(true);
	}
}


