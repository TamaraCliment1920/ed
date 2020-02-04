package serpis.ed;

import java.util.List;

public class Vector {

	public static void main(String[] args) {

	}

	/**
	 * Devuelve el valor mayor del vector
	 * @throws java.lang.IllegalArgumentException si el vector está vacío
	 * @param v
	 * @return el valor mayor
	 */	
	//public static int max(int[] v) {
//		int max = v[0];
//		for (int index = 1; index < v.length; index++)
//			if (v[index] > max)
//				max = v[index];
//		
//		return max;
//		if (v.length == 0)
//			throw new IllegalArgumentException();
//		int max = v[0];
//		for (int item : v)
//			if (item > max)
//				max = item;
//		return max;
//		
		
//	}
	
	public static int max1(int[] v) {
		if (v.length == 0)
			throw new IllegalArgumentException();
		int max1 = v[0];
		for (int index = 1; index < v.length; index++)
			if (v[index] > max1)
				max1 = v[index];
		return max1;
		
		
	}
	
	
	public static void selectionSort(int[] v) {
		for (int position = 0; position < v.length - 1; position++) {
			int indexOfMin = position;
			for (int index = position + 1; index < v.length; index++)
				if (v[index] < v[indexOfMin])
					indexOfMin = index;
			//swap position y indexOfMin
			int aux = v[position];
			v[position] = v[indexOfMin];
			v[indexOfMin] = aux;
		}
	}
	
	public static void selectionSort2(int[] v) {
		for (int position = 0; position < v.length - 1; position++) 
			swap(v, position, indexOfMin(v, position));
	}
	
	private static int indexOfMin(int[] v, int initialIndex) {
		int indexOfMin = initialIndex;
		for (int index = initialIndex + 1; index < v.length; index++)
			if (v[index] < v[indexOfMin])
				indexOfMin = index;
		return indexOfMin;
	}
	
	private static void swap(int[] v, int oneIndex, int otherIndex) {
		int aux = v[oneIndex];
		v[oneIndex] = v[otherIndex];
		v[otherIndex] = aux;
	}
	
	

}
