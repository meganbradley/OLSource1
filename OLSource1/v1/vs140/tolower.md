---
title: "tolower"
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
  - "tolower"
  - "std::tolower"
  - "std.tolower"
  - "locale/std::tolower"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tolower"
  - "tolower function"
ms.assetid: 295960e7-8d6d-4631-8b8e-1e3fc4a9fc23
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tolower
Converts a character to lower case.  
  
## Syntax  
  
```  
  
   template<Class CharType>  
CharType tolower(  
   CharType _Ch,   
   const locale& _Loc  
)  
```  
  
#### Parameters  
 `_Ch`  
 The character to be converted to lower case.  
  
 `_Loc`  
 The locale containing the character to be converted.  
  
## Return Value  
 The character converted to lower case.  
  
## Remarks  
 The template function returns [use_facet](../vs140/use_facet.md)<[ctype](../vs140/ctype-class.md)<**CharType**> >(`_Loc`).[tolower](../vs140/ctype--tolower.md)(`_Ch`).  
  
## Example  
  
```  
// locale_tolower.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
using namespace std;  
  
int main( )     
{  
   locale loc ( "German_Germany" );  
   char result1 = tolower ( 'H', loc );  
   cout << "The lower case of 'H' in the locale is: "  
        << result1 << "." << endl;  
   char result2 = tolower ( 'h', loc );  
   cout << "The lower case of 'h' in the locale is: "  
        << result2 << "." << endl;  
   char result3 = tolower ( '$', loc );  
   cout << "The lower case of '$' in the locale is: "  
        << result3 << "." << endl;  
}  
```  
  
## Output  
  
```  
The lower case of 'H' in the locale is: h.  
The lower case of 'h' in the locale is: h.  
The lower case of '$' in the locale is: $.  
```  
  
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std