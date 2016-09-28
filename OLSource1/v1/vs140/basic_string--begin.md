---
title: "basic_string::begin"
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
  - "std.basic_string.begin"
  - "std::basic_string::begin"
  - "basic_string.begin"
  - "begin"
  - "xstring/std::basic_string::begin"
  - "basic_string::begin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "begin method, with specific classes"
ms.assetid: 60d2a15c-e299-4335-ac2c-299d9c51e7fe
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# basic_string::begin
Returns an iterator addressing the first element in the string.  
  
## Syntax  
  
```  
const_iterator begin( ) const;  
iterator begin( );  
```  
  
## Return Value  
 A random-access iterator that addresses the first element of the sequence or just beyond the end of an empty sequence.  
  
## Remark  
 If the return value of **begin** is assigned to a `const_iterator`, the string object cannot be modified. If the return value of **begin** is assigned to an **iterator**, the string object can be modified.  
  
## Example  
  
```  
// basic_string_begin.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( ) {  
   using namespace std;  
   string str1 ( "No way out." ), str2;  
   basic_string <char>::iterator strp_Iter, str1_Iter, str2_Iter;  
   basic_string <char>::const_iterator str1_cIter;  
  
   str1_Iter = str1.begin ( );  
   cout << "The first character of the string str1 is: "   
        << *str1_Iter << endl;  
   cout << "The full original string str1 is: " << str1 << endl;  
  
   // The dereferenced iterator can be used to modify a character  
   *str1_Iter = 'G';  
   cout << "The first character of the modified str1 is now: "   
        << *str1_Iter << endl;  
   cout << "The full modified string str1 is now: " << str1 << endl;  
  
   // The following line would be an error because iterator is const  
   // *str1_cIter = 'g';  
  
   // For an empty string, begin is equivalent to end  
   if (  str2.begin ( ) == str2.end ( ) )  
      cout << "The string str2 is empty." << endl;  
   else  
      cout << "The string str2 is not empty." << endl;  
}  
```  
  
## Output  
  
```  
The first character of the string str1 is: N  
The full original string str1 is: No way out.  
The first character of the modified str1 is now: G  
The full modified string str1 is now: Go way out.  
The string str2 is empty.  
```  
  
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)