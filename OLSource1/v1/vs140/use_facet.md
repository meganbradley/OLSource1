---
title: "use_facet"
ms.custom: na
ms.date: 09/21/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - std.use_facet
  - std::use_facet
  - xlocale/std::use_facet
  - use_facet
dev_langs: 
  - C++
helpviewer_keywords: 
  - use_facet
  - use_facet function
ms.assetid: cacbd60b-6263-45c2-84db-369730f46733
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# use_facet
Returns a reference to a facet of a specified type stored in a locale.  
  
## Syntax  
  
```  
  
   template<class Facet>  
const Facet& use_facet(  
   const locale& _Loc  
);  
```  
  
#### Parameters  
 `_Loc`  
 The const locale containing the type of facet being referenced.  
  
## Return Value  
 A reference to the facet of class `Facet` contained within the argument locale.  
  
## Remarks  
 The reference to the facet returned by the template function remains valid as long as any copy of the containing locale exists. If no such facet object of class `Facet` is listed in the argument locale, the function throws a `bad_cast` exception.  
  
## Example  
  
```  
// locale_use_facet.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
using namespace std;  
  
int main( )     
{  
   locale loc1 ( "German_Germany" ), loc2 ( "English_Australia" );  
   bool result1 = use_facet<ctype<char> > ( loc1 ).is(  
   ctype_base::alpha, 'a'   
);  
   bool result2 = use_facet<ctype<char> > ( loc2 ).is( ctype_base::alpha, '!'  
   );  
  
   if ( result1 )  
      cout << "The character 'a' in locale loc1 is alphabetic."   
           << endl;  
   else  
      cout << "The character 'a' in locale loc1 is not alphabetic."   
           << endl;  
  
   if ( result2 )  
      cout << "The character '!' in locale loc2 is alphabetic."   
           << endl;  
   else  
      cout << "The character '!' in locale loc2 is not alphabetic."   
           << endl;  
}  
```  
  
 **The character 'a' in locale loc1 is alphabetic.**  
**The character '!' in locale loc2 is not alphabetic.**   
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std