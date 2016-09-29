---
title: "basic_string::max_size"
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
  - "std::basic_string::max_size"
  - "max_size"
  - "xstring/std::basic_string::max_size"
  - "std.basic_string.max_size"
  - "basic_string::max_size"
  - "basic_string.max_size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "max_size method"
ms.assetid: d93cae80-b5dd-4a4a-8e7d-3e0029f5eadd
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::max_size
Returns the maximum number of characters a string could contain.  
  
## Syntax  
  
```  
size_type max_size( ) const;  
```  
  
## Return Value  
 The maximum number of characters a string could contain.  
  
## Remarks  
 A exception of type [length_error Class](../vs140/length_error-class.md) is thrown when an operation produces a string with a length greater than the maximum size.  
  
## Example  
  
```  
// basic_string_max_size.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   string str1 ("Hello world");  
   cout << "The original string str1 is: " << str1 << endl;  
  
   // The size and length member functions differ in name only  
   basic_string <char>::size_type sizeStr1, lenStr1;  
   sizeStr1 = str1.size ( );  
   lenStr1 = str1.length ( );  
  
   basic_string <char>::size_type capStr1, max_sizeStr1;  
   capStr1 = str1.capacity ( );  
   max_sizeStr1 = str1.max_size ( );  
  
   // Compare size, length, capacity & max_size of a string  
   cout << "The current size of original string str1 is: "   
        << sizeStr1 << "." << endl;  
   cout << "The current length of original string str1 is: "   
        << lenStr1 << "." << endl;  
   cout << "The capacity of original string str1 is: "  
        << capStr1 << "." << endl;  
   cout << "The max_size of original string str1 is: "   
        << max_sizeStr1 << "." << endl << endl;  
  
   str1.erase ( 6, 5 );  
   cout << "The modified string str1 is: " << str1 << endl;  
  
   sizeStr1 = str1.size ( );  
   lenStr1 = str1.length ( );  
   capStr1 = str1.capacity ( );  
   max_sizeStr1 = str1.max_size ( );  
  
   // Compare size, length, capacity & max_size of a string  
   // after erasing part of the original string  
   cout << "The current size of modified string str1 is: "   
        << sizeStr1 << "." << endl;  
   cout << "The current length of modified string str1 is: "   
        << lenStr1 << "." << endl;  
   cout << "The capacity of modified string str1 is: "  
        << capStr1 << "." << endl;  
   cout << "The max_size of modified string str1 is: "   
        << max_sizeStr1 << "." << endl;  
}  
```  
  
## Sample Output  
 The following output is for x86.  
  
```  
The original string str1 is: Hello world  
The current size of original string str1 is: 11.  
The current length of original string str1 is: 11.  
The capacity of original string str1 is: 15.  
The max_size of original string str1 is: 4294967294.  
  
The modified string str1 is: Hello   
The current size of modified string str1 is: 6.  
The current length of modified string str1 is: 6.  
The capacity of modified string str1 is: 15.  
The max_size of modified string str1 is: 4294967294.  
```  
  
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)