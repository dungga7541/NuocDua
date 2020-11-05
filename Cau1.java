package btSwing;

import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JCheckBoxMenuItem;
import javax.swing.JColorChooser;
import javax.swing.JFileChooser;
import javax.swing.JFrame;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JOptionPane;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;

public class Cau1 extends JFrame {

	public static void main(String[] args) {
		JMenu mnuBar;
		JMenu mnuFile, mnuFormat;
		JCheckBoxMenuItem mnuOpen, mnuExit, muBgColor, mnuFontColor;
		
		JTextArea txtContent;
		JScrollPane scroll;
		
		Cau1 obj = new Cau1();
		obj.setVisible(true);
	}
	public Cau1() {
		setTitle("Chuong trình Notepad");
		setSize(800,500);
		setDefaultCloseOperation(EXIT_ON_CLOSE);
		setLocationRelativeTo(null);
		JMenuBar mnuBar = new JMenuBar();
		JMenu mnuFile = new JMenu("File");
		JMenu mnuFormat = new JMenu("Format");
		JMenuItem mnuOpen = new JMenuItem("Open");
		JMenuItem mnuExit = new JMenuItem("Exit");
		JMenuItem mnuBgColor = new JMenuItem("Change BG Color");
		JMenuItem mnuFontColor = new JMenuItem("Change Font Color");
		//Thêm menu Open và Exit vào menu File
		mnuFile.add(mnuOpen);
		mnuFile.addSeparator();
		mnuFile.add(mnuExit);
		//Thêm menu Chang BG Color và font color vào menu format
		mnuFormat.add(mnuBgColor);
		mnuFormat.add(mnuFontColor);
		//Thêm menu File và Format vào menu chính
		mnuBar.add(mnuFile);
		mnuBar.add(mnuFormat);
		
		setJMenuBar(mnuBar);//Đưa menu bar vào CT
		
		JTextArea txtContent = new JTextArea();
		JScrollPane scroll = new JScrollPane(txtContent);
		
		getContentPane().add(scroll);
		
		ActionListener listener = new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				if(e.getSource() == mnuOpen) {
					//JOptionPane.showMessageDialog(null, "Bạn vừa nhấn vào Open", "Thông báo", 1);
					JFileChooser openFile = new JFileChooser();
					int result = openFile.showOpenDialog(null);
					if(result == JFileChooser.APPROVE_OPTION) {
						JOptionPane.showMessageDialog(null, openFile.getSelectedFile().getAbsolutePath());
					}
				}
				else if(e.getSource() == mnuExit) {
					int result = JOptionPane.showConfirmDialog(null, "Bạn có muốn thoát không ?", "Thông báo", JOptionPane.OK_CANCEL_OPTION);
					if(result == JOptionPane.OK_OPTION) {
						System.exit(0);
					}
				}
				else if(e.getSource() == mnuBgColor) {
					Color color = JColorChooser.showDialog(null, "Bạn vừa nhấn vào Change BG Color", txtContent.getBackground());
					txtContent.setBackground(color);
					
				}
				else if(e.getSource() == mnuFontColor) {
					JOptionPane.showMessageDialog(null, "Bạn vừa nhấn vào Change Font Color", "Thông báo", 1);
				}
			}
			
		};
		mnuOpen.addActionListener(listener);
		mnuExit.addActionListener(listener);
		mnuBgColor.addActionListener(listener);
		mnuFontColor.addActionListener(listener);
	}
}
