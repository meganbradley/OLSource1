---
title: "basic_string::at"
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
  - "basic_string.at"
  - "std.basic_string.at"
  - "basic_string::at"
  - "xstring/std::basic_string::at"
  - "at"
  - "std::basic_string::at"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "at method"
ms.assetid: 2fccc713-656b-49c7-93da-5c1352b6362b
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::at
Provides a reference to the character with a specified index in a string.  
  
## Syntax  
  
```  
const_reference at(  
    size_type _Off  
) const;  
reference at(  
    size_type _Off  
);  
```  
  
#### Parameters  
 `_Off`  
 The index of the position of the element to be referenced.  
  
## Return Value  
 A reference to the character of the string at the position specified by the parameter index.  
  
## Remarks  
 The first element of the string has an index of zero and the following elements are indexed consecutively by the positive integers, so that a string of length *n* has an *n*th element indexed by the number *n –* 1.  
  
 The member [operator&#91;&#93;](../vs140/basic_string--operator.md) is faster than the member function **at** for providing read and write access to the elements of a string.  
  
 The member `operator[]` does not check whether the index passed as a parameter is valid but the member function **at** does and so should be used if the validity is not certain. An invalid index, which is an index less that zero or greater than or equal to the size of the string, passed to the member function **at** throws an [out_of_range Class](../vs140/out_of_range-class.md) exception. An invalid index passed to the `operator[]` results in undefined behavior, but the index equal to the length of the string is a valid index for const strings and the operator returns the null-character when passed this index.  
  
 The reference returned may be invalidated by string reallocations or modifications for the non-**const** strings.  
  
## Example  
  
```  
// basic_string_at.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   string str1 ( "Hello world" ), str2 ( "Goodbye world" );  
   const string  cstr1 ( "Hello there" ), cstr2 ( "Goodbye now" );  
   cout << "The original string str1 is: " << str1 << endl;  
   cout << "The original string str2 is: " << str2 << endl;  
  
   // Element access to the non const strings  
   basic_string <char>::reference refStr1 = str1 [6];  
   basic_string <char>::reference refStr2 = str2.at ( 3 );  
  
   cout << "The character with an index of 6 in string str1 is: "  
        << refStr1 << "." << endl;  
   cout << "The character with an index of 3 in string str2 is: "  
        << refStr2 << "." << endl;  
  
   // Element access to the const strings  
   basic_string <char>::const_reference crefStr1 = cstr1 [ cstr1.length ( ) ];  
   basic_string <char>::const_reference crefStr2 = cstr2.at ( 8 );  
  
   if ( crefStr1 == '\0' )  
      cout << "The null character is returned as a valid reference."  
           << endl;  
   else  
      cout << "The null character is not returned." << endl;  
   cout << "The character with index 8 in the const string cstr2 is: "  
        << crefStr2 << "." << endl;  
}  
```  
  
## Output  
  
```  
The original string str1 is: Hello world  
The original string str2 is: Goodbye world  
The character with an index of 6 in string str1 is: w.  
The character with an index of 3 in string str2 is: d.  
The null character is returned as a valid reference.  
The character with index 8 in the const string cstr2 is: n.  
```  
  
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)