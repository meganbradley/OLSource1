---
title: "has_facet"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std::has_facet"
  - "std.has_facet"
  - "locale/std::has_facet"
  - "has_facet"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "has_facet"
  - "has_facet function"
ms.assetid: 13564b12-0ce0-4066-b5b8-7f9895176fde
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# has_facet
Tests if a particular facet is stored in a specified locale.  
  
## Syntax  
  
```  
  
   template<class Facet>  
bool has_facet(  
   const locale& _Loc  
);  
```  
  
#### Parameters  
 `_Loc`  
 The locale to be tested for the presence of a facet.  
  
## Return Value  
 **true** if the locale has the facet tested for; **false** if it does not.  
  
## Remarks  
 The template function is useful for checking whether nonmandatory facets are listed in a locale before `use_facet` is called to avoid the exception that would be thrown if it were not present.  
  
## Example  
  
```  
// locale_has_facet.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
using namespace std;  
  
int main( )  
{  
   locale loc ( "German_Germany" );  
   bool result = has_facet <ctype<char> > ( loc );  
   cout << result << endl;  
}  
```  
  
 **1**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std