package org.agilept.dojo.java;

import java.util.ArrayList;
import java.util.List;

public class Engine {
	
	int[][] plays;
	public static final int X = 1;
	public static final int Y = 2;
	
	public Engine(){
		plays = new int[][]{{-1,-1,-1},{-1,-1,-1},{-1,-1,-1}};
			
	}

	public int[][] getMatrix() {
		return plays;
	}
	
	public boolean validMove(int i, int j) {
		if(i < 0 || i > 2)
			return false;
		if(j < 0 || j > 2)
			return false;
		
		return true;
	}  

}
