---
title: "isgraph"
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
  - "isgraph"
  - "std.isgraph"
  - "Isgraph"
  - "locale/std::isgraph"
  - "std::isgraph"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "isgraph function"
  - "isgraph"
ms.assetid: 4955187b-4fcb-43cf-bd9e-7055c26e0ec9
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# isgraph
Tests whether an element in a locale is an alphanumeric or punctuation character.  
  
## Syntax  
  
```  
  
   template<Class CharType>  
bool isgraph(  
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
 **true** if the element tested is an alphanumeric or a punctuation character; **false** if it is not.  
  
## Remarks  
 The template function returns [use_facet](../vs140/use_facet.md)<[ctype](../vs140/ctype-class.md)<**CharType**> >(`_Loc`).[is](../vs140/ctype--is.md)(**ctype**<**CharType**>::**graph**, `_Ch`).  
  
## Example  
  
```  
// locale_is_graph.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
  
using namespace std;  
  
int main( )  
{  
   locale loc ( "German_Germany" );  
   bool result1 = isgraph ( 'L', loc );  
   bool result2 = isgraph ( '\t', loc );  
   bool result3 = isgraph ( '.', loc );  
  
   if ( result1 )  
      cout << "The character 'L' in the locale is\n "  
           << "an alphanumeric or punctuation character." << endl;  
   else  
      cout << "The character 'L' in the locale is\n "  
           << " not an alphanumeric or punctuation character." << endl;  
  
   if ( result2 )  
      cout << "The character 'backslash-t' in the locale is\n "  
           << "an alphanumeric or punctuation character." << endl;  
   else  
      cout << "The character 'backslash-t' in the locale is\n "  
           << "not an alphanumeric or punctuation character." << endl;  
  
   if ( result3 )  
      cout << "The character '.' in the locale is\n "  
           << "an alphanumeric or punctuation character." << endl;  
   else  
      cout << "The character '.' in the locale is\n "  
           << " not an alphanumeric or punctuation character." << endl;  
}  
```  
  
## Output  
  
```  
The character 'L' in the locale is  
 an alphanumeric or punctuation character.  
The character 'backslash-t' in the locale is  
 not an alphanumeric or punctuation character.  
The character '.' in the locale is  
 an alphanumeric or punctuation character.  
```  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std