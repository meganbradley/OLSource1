---
title: "isupper"
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
  - "isupper"
  - "locale/std::isupper"
  - "std::isupper"
  - "std.isupper"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "isupper"
  - "isupper function"
ms.assetid: 7194895f-5a72-4282-b836-a5f59d86a5dc
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# isupper
Tests whether an element in a locale is in upper case.  
  
## Syntax  
  
```  
  
   template<Class CharType>  
bool isupper(  
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
 **true** if the element tested is an uppercase character; **false** if it is not.  
  
## Remarks  
 The template function returns [use_facet](../vs140/use_facet.md)<[ctype](../vs140/ctype-class.md)\<**CharType**> >(`_Loc`).[is](../vs140/ctype--is.md)(**ctype**\<**CharType**>::**upper**, `_Ch`).  
  
## Example  
  
```  
// locale_isupper.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
  
using namespace std;  
  
int main( )     
{  
   locale loc ( "German_Germany" );  
   bool result1 = isupper ( 'L', loc );  
   bool result2 = isupper ( 'n', loc );  
   bool result3 = isupper ( '3', loc );  
  
   if ( result1 )  
      cout << "The character 'L' in the locale is "  
           << "a uppercase character." << endl;  
   else  
      cout << "The character 'L' in the locale is "  
           << " not a uppercase character." << endl;  
  
   if ( result2 )  
      cout << "The character 'n' in the locale is "  
           << "a uppercase character." << endl;  
   else  
      cout << "The character 'n' in the locale is "  
           << " not a uppercase character." << endl;  
  
   if ( result3 )  
      cout << "The character '3' in the locale is "  
           << "a uppercase character." << endl;  
   else  
      cout << "The character '3' in the locale is "  
           << " not a uppercase character." << endl;  
}  
```  
  
## Output  
  
```  
The character 'L' in the locale is a uppercase character.  
The character 'n' in the locale is  not a uppercase character.  
The character '3' in the locale is  not a uppercase character.  
```  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std