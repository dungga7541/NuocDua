import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Graphics;
import java.awt.Graphics2D;
import javax.swing.JFrame;
import javax.swing.JPanel;
 
 class Cau2 extends JPanel {
	private void doDrawing(Graphics g) {
		 
        Graphics2D g2d = (Graphics2D) g;
        g2d.setPaint(new Color(51,204,255));
        g2d.fillRect(65, 50, 150, 150);
   } 
	
    @Override
    public void paintComponent(Graphics g) {
        
        super.paintComponent(g);
        doDrawing(g);
    }    
     
	public static void main(String[] args) {
		Cau2 cau2 = new Cau2();
		JFrame app = new JFrame("Hinh Vuong");
		app.add(cau2, BorderLayout.CENTER);
		app.setSize(300,300);
		app.setLocationRelativeTo(null);
		app.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		app.setVisible(true);
	}
}