import java.awt.Color;
import java.awt.Graphics;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;

import javax.swing.JFrame;

public class Cau4 extends JFrame implements KeyListener {
	int x = 200;
	int y = 500;
	int w = 100;

	public static void main(String[] args) {
		Cau4 frame = new Cau4();
		frame.setVisible(true);	
	}
	public Cau4() {
		addKeyListener(this);
		setFocusable(true);
		setTitle("Chuong trinh do hoa");
		setSize(800,600);
		setDefaultCloseOperation(EXIT_ON_CLOSE);
		setLocationRelativeTo(null);
	}
	@Override
	public void paint(Graphics g) {
		super.paint(g);
		g.setColor(Color.GREEN);
		g.fillOval(x, y, w, w);
		//g.drawOval(100, 50, 200, 200);
	}
	@Override
	public void keyPressed(KeyEvent e) {
		if(e.getKeyCode() == KeyEvent.VK_UP) {
			System.out.println("Ban vừa nhấn phím UP");
			y -= 10;
			repaint();
		}
		else if(e.getKeyCode() == KeyEvent.VK_DOWN) {
			System.out.println("Ban vừa nhấn phím DOWN");
			y += 10;
			repaint();
		}
		else if(e.getKeyCode() == KeyEvent.VK_LEFT) {
			System.out.println("Ban vừa nhấn phím LEFT");
			x -= 10;
			repaint();
		}
		else if(e.getKeyCode() == KeyEvent.VK_RIGHT) {
			System.out.println("Ban vừa nhấn phím RIGHT");
			x += 10;
			repaint();
		}
	}
	@Override
	public void keyReleased(KeyEvent e) {
		// TODO Auto-generated method stub
		
	}
	@Override
	public void keyTyped(KeyEvent e) {
		// TODO Auto-generated method stub
		
	}
}