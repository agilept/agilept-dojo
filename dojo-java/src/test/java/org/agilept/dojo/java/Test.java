package org.agilept.dojo.java;
import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertFalse;
import static org.junit.Assert.assertTrue;


public class Test {

	@org.junit.Test
	public void testEngineCreation(){
		Engine engine = new Engine();
		int[][] plays = engine.getMatrix();
		for(int[] play : plays)
			for(int x : play)
				assertEquals(-1, x);
	}


	@org.junit.Test
	public void testvalidMove(){
		Engine engine = new Engine();
		assertTrue(engine.validMove(0, 0));
		assertFalse(engine.validMove(-1, 0));
		assertFalse(engine.validMove(0, -1));
		assertFalse(engine.validMove(3, 0));
		assertFalse(engine.validMove(0, 3));
		
	}
	
	@org.junit.Test
	public void testDoMove() {
		Engine e = new Engine();
		e.doMove(Engine.X, 1, 1);
		assertEquals(Engine.X, engine.getPlay(1,1))
	}
}