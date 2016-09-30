---
title: "basic_ios::fill"
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
  - "fill"
  - "std.basic_ios.fill"
  - "ios/std::basic_ios::fill"
  - "std::basic_ios::fill"
  - "basic_ios.fill"
  - "basic_ios::fill"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "fill method"
ms.assetid: fb583694-72b0-4a92-945d-27a3f8afd185
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ios::fill
Specifies or returns the character that will be used when the text is not as wide as the stream.  
  
## Syntax  
  
```  
  
      char  
      _  
      type fill( ) const;  
char_type fill(  
   char_type _Char  
);  
```  
  
#### Parameters  
 `_Char`  
 The character you want as the fill character.  
  
## Return Value  
 The current fill character.  
  
## Remarks  
 The first member function returns the stored fill character. The second member function stores `_Char` in the fill character and returns its previous stored value.  
  
## Example  
  
```  
// basic_ios_fill.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <iomanip>  
  
int main( )   
{  
   using namespace std;  
  
   cout << setw( 5 ) << 'a' << endl;  
  
   cout.fill( 'x' );  
   cout << setw( 5 ) << 'a' << endl;  
  
   cout << cout.fill( ) << endl;  
}  
```  
  
  **a**  
**xxxxa**  
**x**   
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ios Class](../vs140/basic_ios-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)