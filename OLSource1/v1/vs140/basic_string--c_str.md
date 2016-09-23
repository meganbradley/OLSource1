---
title: "basic_string::c_str"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - xstring/std::basic_string::c_str
  - basic_string.c_str
  - std::basic_string::c_str
  - basic_string::c_str
  - std.basic_string.c_str
  - c_str
dev_langs: 
  - C++
helpviewer_keywords: 
  - c_str method
ms.assetid: 5af7677b-a410-4a48-bd17-dd4898146aef
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# basic_string::c_str
Converts the contents of a string as a C-style, null-terminated string.  
  
## Syntax  
  
```  
const value_type *c_str( ) const;  
```  
  
## Return Value  
 A pointer to the C-style version of the invoking string.  The pointer value is not valid after calling a non-const function, including the destructor, in the basic_string class on the object.  
  
## Remarks  
 Objects of type string belonging to the C++ template class basic_string<char\> are not necessarily null terminated. The null character ' \0 ' is used as a special character in a C-string to mark the end of the string but has no special meaning in an object of type string and may be a part of the string just like any other character. There is an automatic conversion from const **char\*** into strings, but the string class does not provide for automatic conversions from C-style strings to objects of type **basic_string<char\>**.  
  
 The returned C-style string should not be modified, as this could invalidate the pointer to the string, or deleted, as the string has a limited lifetime and is owned by the class string.  
  
## Example  
  
```  
// basic_string_c_str.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
  
   string  str1 ( "Hello world" );  
   cout << "The original string object str1 is: "   
        << str1 << endl;  
   cout << "The length of the string object str1 = "   
        << str1.length ( ) << endl << endl;  
  
   // Converting a string to an array of characters  
   const char *ptr1 = 0;  
   ptr1= str1.data ( );  
   cout << "The modified string object ptr1 is: " << ptr1   
        << endl;  
   cout << "The length of character array str1 = "   
        << strlen ( ptr1) << endl << endl;  
  
   // Converting a string to a C-style string  
   const char *c_str1 = str1.c_str ( );  
   cout << "The C-style string c_str1 is: " << c_str1   
        << endl;  
   cout << "The length of C-style string str1 = "   
        << strlen ( c_str1) << endl << endl;  
}  
```  
  
 **The original string object str1 is: Hello world**  
**The length of the string object str1 = 11**  
**The modified string object ptr1 is: Hello world**  
**The length of character array str1 = 11**  
**The C-style string c_str1 is: Hello world**  
**The length of C-style string str1 = 11**   
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)