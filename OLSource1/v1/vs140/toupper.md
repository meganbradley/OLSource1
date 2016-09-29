---
title: "toupper"
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
  - "std.toupper"
  - "std::toupper"
  - "locale/std::toupper"
  - "toupper"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "toupper"
  - "toupper function"
ms.assetid: 5f3abe73-736b-4d86-add5-016d1ad222ce
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# toupper
Converts a character to upper case.  
  
## Syntax  
  
```  
  
   template<Class CharType>  
CharType toupper(  
   CharType _Ch,   
   const locale& _Loc  
)  
```  
  
#### Parameters  
 `_Ch`  
 The character to be converted to upper case.  
  
 `_Loc`  
 The locale containing the character to be converted.  
  
## Return Value  
 The character converted to upper case.  
  
## Remarks  
 The template function returns [use_facet](../vs140/use_facet.md)<[ctype](../vs140/ctype-class.md)<**CharType**> >(`_Loc`).[toupper](../vs140/ctype--toupper.md)(`_Ch`).  
  
## Example  
  
```  
// locale_toupper.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
using namespace std;  
  
int main( )     
{  
   locale loc ( "German_Germany" );  
   char result1 = toupper ( 'h', loc );  
   cout << "The upper case of 'h' in the locale is: "  
        << result1 << "." << endl;  
   char result2 = toupper ( 'H', loc );  
   cout << "The upper case of 'H' in the locale is: "  
        << result2 << "." << endl;  
   char result3 = toupper ( '$', loc );  
   cout << "The upper case of '$' in the locale is: "  
        << result3 << "." << endl;  
}  
```  
  
## Output  
  
```  
The upper case of 'h' in the locale is: H.  
The upper case of 'H' in the locale is: H.  
The upper case of '$' in the locale is: $.  
```  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std