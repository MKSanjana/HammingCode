class HammingCode {

	
	static void print(int ar[])
	{
		for (int i = 1; i < ar.length; i++) {
			System.out.print(ar[i]);
		}
		System.out.println();
	}

	
	static int[] calculation(int[] ar, int r)
	{
		for (int i = 0; i < r; i++) {
			int x = (int)Math.pow(2, i);
			for (int j = 1; j < ar.length; j++) {
				if (((j >> i) & 1) == 1) {
					if (x != j)
						ar[x] = ar[x] ^ ar[j];
				}
			}
			System.out.println("r" + x + " = "
							+ ar[x]);
		}

		return ar;
	}

	static int[] generateCode(String str, int M, int r)
	{
		