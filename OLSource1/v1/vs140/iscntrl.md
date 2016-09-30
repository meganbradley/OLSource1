---
title: "iscntrl"
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
  - "std.iscntrl"
  - "locale/std::iscntrl"
  - "std::iscntrl"
  - "iscntrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "iscntrl function"
  - "iscntrl"
ms.assetid: 34f33027-0129-42d7-a3a1-b63500ecae62
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# iscntrl
Tests whether an element in a locale is a control character.  
  
## Syntax  
  
```  
  
   template<Class CharType>  
bool iscntrl(  
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
 **true** if the element tested is a control character; **false** if it is not.  
  
## Remarks  
 The template function returns [use_facet](../vs140/use_facet.md)<[ctype](../vs140/ctype-class.md)\<**CharType**> >(`_Loc`).[is](../vs140/ctype--is.md)(**ctype**\<**CharType**>::**cntrl**, `_Ch`).  
  
## Example  
  
```  
// locale_iscntrl.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
  
using namespace std;  
  
int main( )     
{  
   locale loc ( "German_Germany" );  
   bool result1 = iscntrl ( 'L', loc );  
   bool result2 = iscntrl ( '\n', loc );  
   bool result3 = iscntrl ( '\t', loc );  
  
   if ( result1 )  
      cout << "The character 'L' in the locale is "  
           << "a control character." << endl;  
   else  
      cout << "The character 'L' in the locale is "  
           << " not a control character." << endl;  
  
   if ( result2 )  
      cout << "The character-set 'backslash-n' in the locale\n is "  
           << "a control character." << endl;  
   else  
      cout << "The character-set 'backslash-n' in the locale\n is "  
           << " not a control character." << endl;  
  
   if ( result3 )  
      cout << "The character-set 'backslash-t' in the locale\n is "  
           << "a control character." << endl;  
   else  
      cout << "The character-set 'backslash-n' in the locale \n is "  
           << " not a control character." << endl;  
}  
```  
  
## Output  
  
```  
The character 'L' in the locale is  not a control character.  
The character-set 'backslash-n' in the locale  
 is a control character.  
The character-set 'backslash-t' in the locale  
 is a control character.  
```  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std