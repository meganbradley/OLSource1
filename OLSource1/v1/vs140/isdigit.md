---
title: "isdigit"
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
  - "std::isdigit"
  - "std.isdigit"
  - "locale/std::isdigit"
  - "isdigit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "isdigit function"
  - "isdigit"
ms.assetid: d17ec575-1cfe-48b5-99e0-33babd0ea68c
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# isdigit
Tests whether an element in a locale is a numeric character.  
  
## Syntax  
  
```  
  
   template<Class CharType>  
bool isdigit(  
   CharType _Ch,   
   const locale& _Loc  
)  
```  
  
#### Parameters  
 `_Ch`  
 The element to be tested.  
  
 `_Loc`  
 The locale containing the element to be tested.  
  
## Return Value  
 **true** if the element tested is a numeric character; **false** if it is not.  
  
## Remarks  
 The template function returns [use_facet](../vs140/use_facet.md)<[ctype](../vs140/ctype-class.md)<**CharType**> >(`_Loc`).[is](../vs140/ctype--is.md)(**ctype**<**CharType**>::**digit**, `_Ch`).  
  
## Example  
  
```  
// locale_is_digit.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
  
using namespace std;  
  
int main( )     
{  
   locale loc ( "German_Germany" );  
   bool result1 = isdigit ( 'L', loc );  
   bool result2 = isdigit ( '@', loc );  
   bool result3 = isdigit ( '3', loc );  
  
   if ( result1 )  
      cout << "The character 'L' in the locale is "  
           << "a numeric character." << endl;  
   else  
      cout << "The character 'L' in the locale is "  
           << " not a numeric character." << endl;  
  
   if ( result2 )  
      cout << "The character '@' in the locale is "  
           << "a numeric character." << endl;  
   else  
      cout << "The character '@' in the locale is "  
           << " not a numeric character." << endl;  
  
   if ( result3 )  
      cout << "The character '3' in the locale is "  
           << "a numeric character." << endl;  
   else  
      cout << "The character '3' in the locale is "  
           << " not a numeric character." << endl;  
}  
```  
  
## Output  
  
```  
The character 'L' in the locale is  not a numeric character.  
The character '@' in the locale is  not a numeric character.  
The character '3' in the locale is a numeric character.  
```  
  
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std