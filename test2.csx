//This test utilizes all correct CSX tokens without errors. Tabs are used, so spaces at beginning of lines are considered one space.
class Tester {
// This is a single-line comment
	int i1;
	int i2;
	bool b1;
	bool b2;
	const char c1 = 'C';
	const "this is a string"

	il = 4 + 10
	i2 = 50 / 5

	if (i2 != 50) {
		int i3 = i1 - i2;
		i2 = i2 * 12;
		b1 = true;
	}
	
	b1 = false;
	
	while (!b1) {
		b2 = false;
		bool b3 = b1 || b2;
		
		if (i2 >= i1) {
			if (i2 == i1) {
				break;
			}
		}
			
		else {
			[b1] = b2 && b3;
			<i1>;
		}
	
		if (i1 <= i3) {
			b1:b2;
		}
	}
	
	## This is
	a multi-
	line comment##
	
	continue
	
	write read
	
	void
	
	return 0;
}