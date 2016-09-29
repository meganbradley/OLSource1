---
title: "basic_string::replace"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "replace"
  - "std::basic_string::replace"
  - "basic_string::replace"
  - "xstring/std::basic_string::replace"
  - "std.basic_string.replace"
  - "basic_string.replace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "replace method"
ms.assetid: 16d81b9d-9724-458a-9179-556748034507
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::replace
Replaces elements in a string at a specified position with specified characters or characters copied from other ranges or strings or C-strings.  
  
## Syntax  
  
```  
basic_string<CharType, Traits, Allocator>& replace(  
   size_type _Pos1,   
   size_type _Num1,  
   const value_type* _Ptr  
);  
basic_string<CharType, Traits, Allocator>& replace(  
   size_type _Pos1,   
   size_type _Num1,  
   const basic_string<CharType, Traits, Allocator>& _Str  
);  
basic_string<CharType, Traits, Allocator>& replace(  
   size_type _Pos1,   
   size_type _Num1,  
   const value_type* _Ptr,   
   size_type _Num2  
);  
basic_string<CharType, Traits, Allocator>& replace(  
   size_type _Pos1,   
   size_type _Num1,  
   const basic_string<CharType, Traits, Allocator>& _Str,   
   size_type _Pos2,   
   size_type _Num2  
);  
basic_string<CharType, Traits, Allocator>& replace(  
   size_type _Pos1,   
   size_type _Num1,  
   size_type _Count,   
   value_type _Ch  
);  
basic_string<CharType, Traits, Allocator>& replace(  
   iterator _First0,   
   iterator _Last0,  
   const value_type* _Ptr  
);  
basic_string<CharType, Traits, Allocator>& replace(  
   iterator _First0,   
   iterator _Last0,  
   const basic_string<CharType, Traits, Allocator>& _Str  
);  
basic_string<CharType, Traits, Allocator>& replace(  
   iterator _First0,  
   iterator _Last0,  
   const value_type* _Ptr,   
   size_type _Num2  
);  
basic_string<CharType, Traits, Allocator>& replace(  
   iterator _First0,   
   iterator _Last0,  
   size_type _Num2,   
   value_type _Ch  
);  
template<class InputIterator>  
   basic_string<CharType, Traits, Allocator>& replace(  
      iterator _First0,   
      iterator _Last0,  
      InputIterator _First,   
      InputIterator _Last  
   );  
basic_string<CharType, Traits, Allocator>& replace(  
    iterator _First0,  
    iterator _Last0,  
    const_pointer _First,  
    const_pointer _Last  
);  
basic_string<CharType, Traits, Allocator>& replace(  
    iterator _First0,  
    iterator _Last0,  
    const_iterator _First,  
    const_iterator _Last  
);  
```  
  
#### Parameters  
 `_Str`  
 The string that is to be a source of characters for the operand string.  
  
 `_Pos1`  
 The index of the operand string at which the replacement begins.  
  
 `_Num1`  
 The maximum number of characters to be replaced in the operand string.  
  
 *_Pos2*  
 The index of the parameter string at which the copying begins.  
  
 `_Num2`  
 The maximum number of characters to be used from the parameter C-string.  
  
 `_Ptr`  
 The C-string that is to be a source of characters for the operand string.  
  
 `_Ch`  
 The character to be copied into the operand string.  
  
 *_First0*  
 An iterator addressing the first character to be removed in the operand string.  
  
 *_Last0*  
 An iterator addressing the last character to be removed in the operand string.  
  
 `_First`  
 An iterator, const_pointer, or const_iterator addressing the first character to be copied in the parameter string.  
  
 `_Last`  
 An iterator, const_pointer, or const_iterator addressing the last character to be copied in the parameter string.  
  
 `_Count`  
 The number of times `_Ch` is copied into the operand string.  
  
## Return Value  
 The operand string with the replacement made.  
  
## Example  
  
```  
// basic_string_replace.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
  
   // The first two member functions replace  
   // part of the operand string with  
   // characters from a parameter string or C-string  
   string result1a, result1b;  
   string s1o ( "AAAAAAAA" );  
   string s1p ( "BBB" );  
   const char* cs1p = "CCC";  
   cout << "The operand string s1o is: " << s1o << endl;  
   cout << "The parameter string s1p is: " << s1p << endl;  
   cout << "The parameter C-string cs1p is: " << cs1p << endl;  
   result1a = s1o.replace ( 1 , 3 , s1p );  
   cout << "The result of s1o.replace ( 1 , 3 , s1p )\n is "   
        << "the string: " << result1a << "." << endl;  
   result1b = s1o.replace ( 5 , 3 , cs1p );  
   cout << "The result of s1o.replace ( 5 , 3 , cs1p )\n is "   
        << "the string: " << result1b << "." << endl;  
   cout << endl;  
  
   // The third & fourth member function replace  
   // part of the operand string with characters  
   // form part of a parameter string or C-string  
   string result2a, result2b;  
   string s2o ( "AAAAAAAA" );  
   string s2p ( "BBB" );  
   const char* cs2p = "CCC";  
   cout << "The operand string s2o is: " << s2o << endl;  
   cout << "The parameter string s1p is: " << s2p << endl;  
   cout << "The parameter C-string cs2p is: " << cs2p << endl;  
   result2a = s2o.replace ( 1 , 3 , s2p , 1 , 2 );  
   cout << "The result of s2o.replace (1, 3, s2p, 1, 2)\n is "   
        << "the string: " << result2a << "." << endl;  
   result2b = s2o.replace ( 4 , 3 , cs2p , 1 );  
   cout << "The result of s2o.replace (4 ,3 ,cs2p)\n is "   
        << "the string: " << result2b << "." << endl;  
   cout << endl;  
  
   // The fifth member function replaces  
   // part of the operand string with characters  
   string result3a;  
   string s3o ( "AAAAAAAA" );  
   char ch3p = 'C';  
   cout << "The operand string s3o is: " << s3o << endl;  
   cout << "The parameter character c1p is: " << ch3p << endl;  
   result3a = s3o.replace ( 1 , 3 , 4 , ch3p );  
   cout << "The result of s3o.replace(1, 3, 4, ch3p)\n is "   
        << "the string: " << result3a << "." << endl;  
   cout << endl;  
  
   // The sixth & seventh member functions replace  
   // part of the operand string, delineated with iterators,  
   // with a parameter string or C-string  
   string s4o ( "AAAAAAAA" );  
   string s4p ( "BBB" );  
   const char* cs4p = "CCC";  
   cout << "The operand string s4o is: " << s4o << endl;  
   cout << "The parameter string s4p is: " << s4p << endl;  
   cout << "The parameter C-string cs4p is: " << cs4p << endl;  
   basic_string<char>::iterator IterF0, IterL0;  
   IterF0 = s4o.begin ( );  
   IterL0 = s4o.begin ( ) + 3;  
   string result4a, result4b;  
   result4a = s4o.replace ( IterF0 , IterL0 , s4p );  
   cout << "The result of s1o.replace (IterF0, IterL0, s4p)\n is "   
        << "the string: " << result4a << "." << endl;  
   result4b = s4o.replace ( IterF0 , IterL0 , cs4p );  
   cout << "The result of s4o.replace (IterF0, IterL0, cs4p)\n is "   
        << "the string: " << result4b << "." << endl;  
   cout << endl;  
  
   // The 8th member function replaces  
   // part of the operand string delineated with iterators  
   // with a number of characters from a parameter C-string  
   string s5o ( "AAAAAAAF" );  
   const char* cs5p = "CCCBB";  
   cout << "The operand string s5o is: " << s5o << endl;  
   cout << "The parameter C-string cs5p is: " << cs5p << endl;  
   basic_string<char>::iterator IterF1, IterL1;  
   IterF1 = s5o.begin ( );  
   IterL1 = s5o.begin ( ) + 4;  
   string result5a;  
   result5a = s5o.replace ( IterF1 , IterL1 , cs5p , 4 );  
   cout << "The result of s5o.replace (IterF1, IterL1, cs4p ,4)\n is "   
        << "the string: " << result5a << "." << endl;  
   cout << endl;  
  
   // The 9th member function replaces  
   // part of the operand string delineated with iterators  
   // with specified characters  
   string s6o ( "AAAAAAAG" );  
   char ch6p = 'q';  
   cout << "The operand string s6o is: " << s6o << endl;  
   cout << "The parameter character ch6p is: " << ch6p << endl;  
   basic_string<char>::iterator IterF2, IterL2;  
   IterF2 = s6o.begin ( );  
   IterL2 = s6o.begin ( ) + 3;  
   string result6a;  
   result6a = s6o.replace ( IterF2 , IterL2 , 4 , ch6p );  
   cout << "The result of s6o.replace (IterF1, IterL1, 4, ch6p)\n is "   
        << "the string: " << result6a << "." << endl;  
   cout << endl;  
  
   // The 10th member function replaces  
   // part of the operand string delineated with iterators  
   // with part of a parameter string delineated with iterators  
   string s7o ( "OOOOOOO" );  
   string s7p ( "PPPP" );  
   cout << "The operand string s7o is: " << s7o << endl;  
   cout << "The parameter string s7p is: " << s7p << endl;  
   basic_string<char>::iterator IterF3, IterL3, IterF4, IterL4;  
   IterF3 = s7o.begin ( ) + 1;  
   IterL3 = s7o.begin ( ) + 3;  
   IterF4 = s7p.begin ( );  
   IterL4 = s7p.begin ( ) + 2;  
   string result7a;  
   result7a = s7o.replace ( IterF3 , IterL3 , IterF4 , IterL4 );  
   cout << "The result of s7o.replace (IterF3 ,IterL3 ,IterF4 ,IterL4)\n is "   
        << "the string: " << result7a << "." << endl;  
   cout << endl;  
}  
```  
  
 **The operand string s1o is: AAAAAAAA**  
**The parameter string s1p is: BBB**  
**The parameter C-string cs1p is: CCC**  
**The result of s1o.replace ( 1 , 3 , s1p )**  
 **is the string: ABBBAAAA.**  
**The result of s1o.replace ( 5 , 3 , cs1p )**  
 **is the string: ABBBACCC.**  
**The operand string s2o is: AAAAAAAA**  
**The parameter string s1p is: BBB**  
**The parameter C-string cs2p is: CCC**  
**The result of s2o.replace (1, 3, s2p, 1, 2)**  
 **is the string: ABBAAAA.**  
**The result of s2o.replace (4 ,3 ,cs2p)**  
 **is the string: ABBAC.**  
**The operand string s3o is: AAAAAAAA**  
**The parameter character c1p is: C**  
**The result of s3o.replace(1, 3, 4, ch3p)**  
 **is the string: ACCCCAAAA.**  
**The operand string s4o is: AAAAAAAA**  
**The parameter string s4p is: BBB**  
**The parameter C-string cs4p is: CCC**  
**The result of s1o.replace (IterF0, IterL0, s4p)**  
 **is the string: BBBAAAAA.**  
**The result of s4o.replace (IterF0, IterL0, cs4p)**  
 **is the string: CCCAAAAA.**  
**The operand string s5o is: AAAAAAAF**  
**The parameter C-string cs5p is: CCCBB**  
**The result of s5o.replace (IterF1, IterL1, cs4p ,4)**  
 **is the string: CCCBAAAF.**  
**The operand string s6o is: AAAAAAAG**  
**The parameter character ch6p is: q**  
**The result of s6o.replace (IterF1, IterL1, 4, ch6p)**  
 **is the string: qqqqAAAAG.**  
**The operand string s7o is: OOOOOOO**  
**The parameter string s7p is: PPPP**  
**The result of s7o.replace (IterF3 ,IterL3 ,IterF4 ,IterL4)**  
 **is the string: OPPOOOO.**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)