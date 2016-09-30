---
title: "basic_istream::gcount"
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
  - "gcount"
  - "std::basic_istream::gcount"
  - "istream/std::basic_istream::gcount"
  - "basic_istream.gcount"
  - "basic_istream::gcount"
  - "std.basic_istream.gcount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "gcount method"
ms.assetid: b86e6205-250c-4ea6-beb3-42277dd51db7
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_istream::gcount
Returns the number of characters read during the last unformatted input.  
  
## Syntax  
  
```  
  
streamsize gcount( ) const;  
  
```  
  
## Return Value  
 The extraction count.  
  
## Remarks  
 Use [basic_istream::get](../vs140/basic_istream--get.md) to read unformatted characters.  
  
## Example  
  
```  
// basic_istream_gcount.cpp  
// compile with: /EHsc  
#include <iostream>  
using namespace std;  
  
int main( )   
{  
   cout << "Type the letter 'a': ";  
  
   ws( cin );  
   char c[10];  
  
   cin.get( &c[0],9 );  
   cout << c << endl;  
  
   cout << cin.gcount( ) << endl;  
}  
```  
  
  **`a` `a`Type the letter 'a':**  
**a**  
**1**   
## Requirements  
 **Header:** \<istream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istream Class](../vs140/basic_istream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)