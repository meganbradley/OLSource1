---
title: "basic_string::size_type"
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
  - basic_string.size_type
  - std.basic_string.size_type
  - basic_string::size_type
  - size_type
  - xstring/std::basic_string::size_type
  - std::basic_string::size_type
dev_langs: 
  - C++
helpviewer_keywords: 
  - size_type typedef
ms.assetid: 6ed51e5f-00ec-4657-b25f-d4e9501c472c
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# basic_string::size_type
An unsigned integer type that can represent the number of elements and indices in a string.  
  
## Syntax  
  
```  
typedef typename allocator_type::size_type size_type;  
```  
  
## Remarks  
 It is equivalent to **allocator_type::size_type**.  
  
 For type **string**, it is equivalent to **size_t**.  
  
## Example  
  
```  
// basic_string_size_type.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   string str1 ( "Hello world" );  
  
   basic_string <char>::size_type sizeStr1, capStr1;  
   sizeStr1 = str1.size (  );  
   capStr1 = str1.capacity (  );  
  
   cout << "The current size of string str1 is: "   
        << sizeStr1 << "." << endl;  
   cout << "The capacity of string str1 is: " << capStr1   
         << "." << endl;  
}  
```  
  
 **The current size of string str1 is: 11.**  
**The capacity of string str1 is: 15.**   
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)