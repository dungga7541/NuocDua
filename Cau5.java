import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Graphics;
import java.awt.Graphics2D;
import javax.swing.JFrame;
import javax.swing.JPanel;
 
 class Cau5 extends JPanel {
	private void doDrawing(Graphics g) {
		//hinh Chu T
		Graphics2D g1d = (Graphics2D) g;
        Graphics2D g2d = (Graphics2D) g;
        g1d.fillRect( 10, 30, 125, 25);
        g2d.fillRect( 60, 30, 25, 125);
        //hinh Chu T
      	Graphics2D g3d = (Graphics2D) g;
        Graphics2D g4d = (Graphics2D) g;
        g4d.fillRect( 150, 30, 25, 125);
        //Hinh Vuong
        Graphics2D g5d = (Graphics2D) g;
        g2d.setPaint(new Color(51,204,255));
        g2d.fillRect(195, 30, 125, 125);
		//Hinh Chu L
        Graphics2D g7d = (Graphics2D) g;
        Graphics2D g8d = (Graphics2D) g;
        g7d.setPaint(new Color(51,204,255));
        g7d.fillRect( 340, 30, 25, 105);
        g8d.fillRect( 340, 130, 105, 25);
   } 
	
    @Override
    public void paintComponent(Graphics g) {
        
        super.paintComponent(g);
        doDrawing(g);
    }    
     
	public static void main(String[] args) {
		Cau5 cau5 = new Cau5();
		JFrame app = new JFrame("Hinh Vuong");
		app.add(cau5, BorderLayout.CENTER);
		app.setSize(300,300);
		app.setLocationRelativeTo(null);
		app.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		app.setVisible(true);
	}
}