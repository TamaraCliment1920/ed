package serpis.ed;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;
import org.junit.platform.suite.api.ExcludePackages;

class VectorTest {

	@Test
	void max1() {
		assertEquals(21, Vector.max1(new int[] {14, 21, 12, 9, 7}));
		assertEquals(31, Vector.max1(new int[] {31, 21, 12, 9, 7}));
		assertEquals(41, Vector.max1(new int[] {31, 21, 12, 9, 41}));
		
		//caso de vector vacío
		Assertions.assertThrows(IllegalArgumentException.class, 
			() -> Vector.max1(new int[] {}) 
		);
	}
	
	@Test
	void selectionSort( ) {
		int[] v1 = {14, 21, 12, 7, 9};
		Vector.selectionSort(v1);
		assertArrayEquals(new int[] {7, 9, 12, 14, 21}, v1);
	}

}
