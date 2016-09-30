---
title: "isprint"
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
  - "std::isprint"
  - "std.isprint"
  - "locale/std::isprint"
  - "isprint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "isprint"
  - "isprint function"
ms.assetid: fd29c672-f1fe-427c-9f94-4d7784c5a6f2
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# isprint
Tests whether an element in a locale is a printable character.  
  
## Syntax  
  
```  
  
   template<Class CharType>  
bool isprint(  
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
 **true** if the element tested is a printable; **false** if it is not.  
  
## Remarks  
 The template function returns [use_facet](../vs140/use_facet.md)<[ctype](../vs140/ctype-class.md)\<**CharType**> >(`_Loc`).[is](../vs140/ctype--is.md)(**ctype**\<**CharType**>::**print**, `_Ch`).  
  
## Example  
  
```  
// locale_isprint.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
using namespace std;  
  
int main( )     
{  
   locale loc ( "German_Germany" );  
  
   bool result1 = isprint ( 'L', loc );  
   if ( result1 )  
      cout << "The character 'L' in the locale is "  
           << "a printable character." << endl;  
   else  
      cout << "The character 'L' in the locale is "  
           << " not a printable character." << endl;  
  
   bool result2 = isprint( '\t', loc );  
   if ( result2 )  
      cout << "The character 'backslash-t' in the locale is "  
           << "a printable character." << endl;  
   else  
      cout << "The character 'backslash-t' in the locale is "  
           << " not a printable character." << endl;  
  
   bool result3 = isprint( '\n', loc );  
   if ( result3 )  
      cout << "The character 'backslash-n' in the locale is "  
           << "a printable character." << endl;  
   else  
      cout << "The character 'backslash-n' in the locale is "  
           << " not a printable character." << endl;  
}  
```  
  
## Output  
  
```  
The character 'L' in the locale is a printable character.  
The character 'backslash-t' in the locale is a printable character.  
The character 'backslash-n' in the locale is  not a printable character.  
```  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std