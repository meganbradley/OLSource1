---
title: "isxdigit"
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
  - "locale/std::isxdigit"
  - "std::isxdigit"
  - "isxdigit"
  - "std.isxdigit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "isxdigit"
  - "isxdigit function"
ms.assetid: f8e323cd-1b83-40c2-b62a-6af0cbbd0d02
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# isxdigit
Tests whether an element in a locale is a character used to represent a hexadecimal number.  
  
## Syntax  
  
```  
  
   template<Class CharType>  
bool isxdigit(  
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
 **true** if the element tested is a character used to represent a hexadecimal number; **false** if it is not.  
  
## Remarks  
 The template function returns [use_facet](../vs140/use_facet.md)<[ctype](../vs140/ctype-class.md)< **CharType**> >(`_Loc`).[is](../vs140/ctype--is.md)(**ctype**<**CharType**>::**xdigit**, `_Ch`).  
  
 Hexadecimal digits use base 16 to represent numbers, using the numbers 0 through 9 plus case-insensitive letters A through F to represent the decimal numbers 0 through 15.  
  
## Example  
  
```  
// locale_isxdigit.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
  
using namespace std;  
  
int main( )     
{  
   locale loc ( "German_Germany" );  
   bool result1 = isxdigit ( '5', loc );  
   bool result2 = isxdigit ( 'd', loc );  
   bool result3 = isxdigit ( 'q', loc );  
  
   if ( result1 )  
      cout << "The character '5' in the locale is "  
           << "a hexidecimal digit-character." << endl;  
   else  
      cout << "The character '5' in the locale is "  
           << " not a hexidecimal digit-character." << endl;  
  
   if ( result2 )  
      cout << "The character 'd' in the locale is "  
           << "a hexidecimal digit-character." << endl;  
   else  
      cout << "The character 'd' in the locale is "  
           << " not a hexidecimal digit-character." << endl;  
  
   if ( result3 )  
      cout << "The character 'q' in the locale is "  
           << "a hexidecimal digit-character." << endl;  
   else  
      cout << "The character 'q' in the locale is "  
           << " not a hexidecimal digit-character." << endl;  
}  
```  
  
## Output  
  
```  
The character '5' in the locale is a hexidecimal digit-character.  
The character 'd' in the locale is a hexidecimal digit-character.  
The character 'q' in the locale is  not a hexidecimal digit-character.  
```  
  
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std