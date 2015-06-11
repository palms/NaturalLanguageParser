// This is test which includes errors, using random-case reserved words and bad integer values, as well as proper, negative integers.

ClAsS Tester {
	BOOL b1;
	bOOl b2;
	iNT i1;
	int i2;
	
	i2 = ~20076;
	i3 = 5;
	
	//bad string, escapes, interprets as two identifiers
	"bad	string"
	
	WHilE (i3 != 0) {
		//value too big, should output Integer.MAX_VALUE
		i2 = 432718597129;
		i3 = i3 - 1;
	}
	
	// value too small, should output Integer.MIN_VALUE
	
	i2 = ~432154235432;
	
	//bad characters
	
	^
	
	%
	
	//error in char literal
	
	char c1 = ''c';
	
	//error in string literal
	
	string s1 = "hi there"";
	
	## this is
	a bad multi-
	line comment #
	
}