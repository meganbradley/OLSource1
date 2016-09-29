---
title: "basic_string::difference_type"
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
  - "xstring/std::basic_string::difference_type"
  - "basic_string::difference_type"
  - "std.basic_string.difference_type"
  - "difference_type"
  - "basic_string.difference_type"
  - "std::basic_string::difference_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "difference_type typedef"
ms.assetid: b50124a2-5323-44a1-a833-3649af45ac24
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::difference_type
A type that provides the difference between two iterators that refer to elements within the same string.  
  
## Syntax  
  
```  
typedef typename allocator_type::difference_type difference_type;  
```  
  
## Remarks  
 The signed integer type describes an object that can represent the difference between the addresses of any two elements in the controlled sequence.  
  
 For type **string**, it is equivalent to **ptrdiff_t**.  
  
## Example  
  
```  
// basic_string_diff_type.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
   string str1 ( "quintillion" );  
   cout << "The original string str1 is: " << str1 << endl;  
   basic_string <char>::size_type indexChFi, indexChLi;  
  
   indexChFi = str1.find_first_of ( "i" );  
   indexChLi = str1.find_last_of ( "i" );  
   basic_string<char>::difference_type diffi = indexChLi - indexChFi;  
  
   cout << "The first character i is at position: "  
        << indexChFi << "." << endl;  
   cout << "The last character i is at position: "  
        << indexChLi << "." << endl;  
   cout << "The difference is: " << diffi << "." << endl;  
}  
```  
  
 **The original string str1 is: quintillion**  
**The first character i is at position: 2.**  
**The last character i is at position: 8.**  
**The difference is: 6.**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)