---
title: "char_traits::not_eof"
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
  - "char_traits::not_eof"
  - "iosfwd/std::char_traits::not_eof"
  - "std::char_traits::not_eof"
  - "std.char_traits.not_eof"
  - "char_traits.not_eof"
  - "not_eof"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "not_eof method"
ms.assetid: cd1bacdf-004e-401d-91ed-c736cfd20131
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# char_traits::not_eof
Tests whether a character is not the end-of-file (EOF) character or is the EOF.  
  
## Syntax  
  
```  
  
      static int  
      _  
      type not  
      _  
      eof(  
   const int_type& _Ch  
);  
```  
  
#### Parameters  
 `_Ch`  
 The character represented as an `int_type` to be tested for whether it is the EOF character or not.  
  
## Return Value  
 The `int_type` representation of the character tested, if the **int_type** of the character is not equal to that of the EOF character.  
  
 If the character `int_type` value is equal to the EOF `int_type` value, then **false**.  
  
## Example  
  
```  
// char_traits_not_eof.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( ) {  
   using namespace std;  
  
   char_traits<char>::char_type ch1 =  'x';  
   char_traits<char>::int_type int1;  
   int1 = char_traits<char>:: to_int_type ( ch1 );  
   cout << "The char_type ch1 is " << ch1  
        << " corresponding to int_type: "   
        << int1 << "." << endl;  
  
   // EOF member function  
   char_traits <char>::int_type int2 = char_traits<char>::eof ( );  
   cout << "The eofReturn is: " << int2 << endl;  
  
   // Testing for EOF or another character  
   char_traits <char>::int_type eofTest1, eofTest2;  
   eofTest1 = char_traits<char>::not_eof ( int1 );  
   if ( !eofTest1 )  
      cout << "The eofTest1 indicates ch1 is an EOF character."  
              << endl;  
   else  
      cout << "The eofTest1 returns: " << eofTest1   
           << ", which is the character: "   
           <<  char_traits<char>::to_char_type ( eofTest1 )  
           << "." << endl;  
  
   eofTest2 = char_traits<char>::not_eof ( int2 );  
   if ( !eofTest2 )  
      cout << "The eofTest2 indicates int2 is an EOF character."   
           << endl;  
   else  
      cout << "The eofTest1 returns: " << eofTest2   
           << ", which is the character: "   
           <<  char_traits<char>::to_char_type ( eofTest2 )   
           << "." << endl;  
}  
```  
  
 **The char_type ch1 is x corresponding to int_type: 120.**  
**The eofReturn is: -1**  
**The eofTest1 returns: 120, which is the character: x.**  
**The eofTest2 indicates int2 is an EOF character.**   
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [char_traits Struct](../vs140/char_traits-struct.md)