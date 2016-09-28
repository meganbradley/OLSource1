---
title: "ispunct"
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
  - "std::ispunct"
  - "locale/std::ispunct"
  - "std.ispunct"
  - "ispunct"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ispunct function"
  - "ispunct"
ms.assetid: 4239da1d-1dee-4f8a-b845-8d04f8c5445d
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ispunct
Tests whether an element in a locale is a punctuation character.  
  
## Syntax  
  
```  
  
   template<Class CharType>  
bool ispunct(  
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
 **true** if the element tested is a punctuation character; **false** if it is not.  
  
## Remarks  
 The template function returns [use_facet](../vs140/use_facet.md)`<`[ctype](../vs140/ctype-class.md)<**CharType**> >(`_Loc`).[is](../vs140/ctype--is.md)(**ctype**<**CharType**>::**punct**, `_Ch`).  
  
## Example  
  
```  
// locale_ispunct.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
  
using namespace std;  
  
int main( )     
{  
   locale loc ( "German_Germany" );  
   bool result1 = ispunct ( 'L', loc );  
   bool result2 = ispunct ( ';', loc );  
   bool result3 = ispunct ( '*', loc );  
  
   if ( result1 )  
      cout << "The character 'L' in the locale is "  
           << "a punctuation character." << endl;  
   else  
      cout << "The character 'L' in the locale is "  
           << " not a punctuation character." << endl;  
  
   if ( result2 )  
      cout << "The character ';' in the locale is "  
           << "a punctuation character." << endl;  
   else  
      cout << "The character ';' in the locale is "  
           << " not a punctuation character." << endl;  
  
   if ( result3 )  
      cout << "The character '*' in the locale is "  
           << "a punctuation character." << endl;  
   else  
      cout << "The character '*' in the locale is "  
           << " not a punctuation character." << endl;  
}  
```  
  
## Output  
  
```  
The character 'L' in the locale is  not a punctuation character.  
The character ';' in the locale is a punctuation character.  
The character '*' in the locale is a punctuation character.  
```  
  
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std