---
title: "char_traits::compare"
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
  - "iosfwd/std::char_traits::compare"
  - "Compare"
  - "char_traits::compare"
  - "std.char_traits.compare"
  - "char_traits.compare"
  - "std::char_traits::compare"
  - "compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "compare method"
ms.assetid: ba7b0d89-7d15-499e-ba26-743b68d11520
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits::compare
Compares up to a specified number of characters in two strings.  
  
## Syntax  
  
```  
  
      static int compare(  
   const char_type* _Str1,   
   const char_type* _Str2,   
   size_t _Num   
);  
```  
  
#### Parameters  
 *_Str1*  
 The first of two strings to be compared to each other.  
  
 *_Str2*  
 The second of two strings to be compared to each other.  
  
 `_Num`  
 The number of elements in the strings to be compared.  
  
## Return Value  
 A negative value if the first string is less than the second string, 0 if the two strings are equal, or a positive value if the first string is greater than the second string.  
  
## Remarks  
 The comparison between the strings is made element by element, first testing for equality and then, if a pair of elements in the sequence tests not equal, they are tested for less than.  
  
 If two strings compare equal over a range but one is longer than the other, then the shorter of the two is less than the longer one.  
  
## Example  
  
```  
// char_traits_compare.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main() {  
   using namespace std;  
  
   char_traits<char>::char_type* s1 = "CAB";  
   char_traits<char>::char_type* s2 = "ABC";  
   char_traits<char>::char_type* s3 = "ABC";  
   char_traits<char>::char_type* s4 = "ABCD";  
  
   cout << "The string s1 is: " << s1 << endl;  
   cout << "The string s2 is: " << s2 << endl;  
   cout << "The string s3 is: " << s3 << endl;  
   cout << "The string s4 is: " << s4 << endl;  
  
   int comp1, comp2, comp3, comp4;  
   comp1 = char_traits<char>::compare ( s1 , s2 , 2 );  
   comp2 = char_traits<char>::compare ( s2 , s3 , 3 );  
   comp3 = char_traits<char>::compare ( s3 , s4 , 4 );  
   comp4 = char_traits<char>::compare ( s4 , s3 , 4 );  
   cout << "compare ( s1 , s2 , 2 ) = " << comp1 << endl;  
   cout << "compare ( s2 , s3 , 3 ) = " << comp2 << endl;  
   cout << "compare ( s3 , s4 , 4 ) = " << comp3 << endl;  
   cout << "compare ( s4 , s3 , 4 ) = " << comp4 << endl;  
}  
```  
  
## Sample Output  
  
```  
The string s1 is: CAB  
The string s2 is: ABC  
The string s3 is: ABC  
The string s4 is: ABCD  
compare ( s1 , s2 , 2 ) = 1  
compare ( s2 , s3 , 3 ) = 0  
compare ( s3 , s4 , 4 ) = -1  
compare ( s4 , s3 , 4 ) = 1  
```  
  
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [char_traits Struct](../vs140/char_traits-struct.md)