package org.agilept.dojo.java;
import static org.junit.Assert.assertEquals;

import java.util.ArrayList;
import java.util.List;


public class Test {

	@org.junit.Test
	public void testEngineCreation(){
		Engine engine = new Engine();
		int[][] plays = engine.getMatrix();
		for(int[] play : plays)
			for(int x : play)
				assertEquals(-1, x);
	}

}