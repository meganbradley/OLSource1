---
title: "isalpha"
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
  - "isalpha"
  - "std.isalpha"
  - "std::isalpha"
  - "locale/std::isalpha"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "isalpha"
  - "isalpha function"
ms.assetid: 86cecb0a-7bd0-4925-bba1-43ddfe9321d8
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# isalpha
Tests whether an element in a locale is an alphabetic character.  
  
## Syntax  
  
```  
  
   template<Class CharType>  
bool isalpha(  
   CharType _Ch,   
   const locale& _Loc  
)  
```  
  
#### Parameters  
 `_Ch`  
 The element to be tested.  
  
 `_Loc`  
 The locale containing the alphabetic element to be tested.  
  
## Return Value  
 **true** if the element tested is alphabetic; **false** if it is not.  
  
## Remarks  
 The template function returns [use_facet](../vs140/use_facet.md)<[ctype](../vs140/ctype-class.md)<**CharType**> >(`_Loc`).[is](../vs140/ctype--is.md)(**ctype**<**CharType**>::**alpha**, `_Ch`).  
  
## Example  
  
```  
// locale_isalpha.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
  
using namespace std;  
  
int main( )     
{  
   locale loc ( "German_Germany" );  
   bool result1 = isalpha ( 'L', loc);  
   bool result2 = isalpha ( '@', loc);  
   bool result3 = isalpha ( '3', loc);  
  
   if ( result1 )  
      cout << "The character 'L' in the locale is "  
           << "alphabetic." << endl;  
   else  
      cout << "The character 'L' in the locale is "  
           << " not alphabetic." << endl;  
  
   if ( result2 )  
      cout << "The character '@' in the locale is "  
           << "alphabetic." << endl;  
   else  
      cout << "The character '@' in the locale is "  
           << " not alphabetic." << endl;  
  
   if ( result3 )  
      cout << "The character '3' in the locale is "  
           << "alphabetic." << endl;  
   else  
      cout << "The character '3' in the locale is "  
           << " not alphabetic." << endl;  
}  
```  
  
## Output  
  
```  
The character 'L' in the locale is alphabetic.  
The character '@' in the locale is  not alphabetic.  
The character '3' in the locale is  not alphabetic.  
```  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std