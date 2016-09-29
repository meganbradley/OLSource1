---
title: "basic_string::value_type"
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
  - "std.basic_string.value_type"
  - "basic_string.value_type"
  - "xstring/std::basic_string::value_type"
  - "std::basic_string::value_type"
  - "basic_string::value_type"
  - "value_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_type typedef"
ms.assetid: a5299aa9-069b-41ce-8710-967714df4b1e
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::value_type
A type that represents the type of characters stored in a string.  
  
## Syntax  
  
```  
typedef typename allocator_type::value_type value_type;  
```  
  
## Remarks  
 It is equivalent to **traits_type::char_type** and is equivalent to `char` for objects of type **string**.  
  
## Example  
  
```  
// basic_string_value_type.cpp  
// compile with: /EHsc  
#include <string>  
#include <iostream>  
  
int main( )   
{  
   using namespace std;  
  
   basic_string<char>::value_type ch1 = 'G';  
  
   char ch2 = 'H';  
  
   cout << "The character ch1 is: " << ch1 << "." << endl;  
   cout << "The character ch2 is: " << ch2 << "." << endl;  
}  
```  
  
 **The character ch1 is: G.**  
**The character ch2 is: H.**   
## Requirements  
 **Header:** <string\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)