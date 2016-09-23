---
title: "locale::combine"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - std::locale::combine
  - locale::combine
  - combine
  - locale.combine
  - xlocale/std::locale::combine
  - std.locale.combine
  - Combine
dev_langs: 
  - C++
helpviewer_keywords: 
  - combine method
ms.assetid: 5665f3c8-4c0d-4c7d-8f8c-f8e9c822eb7e
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# locale::combine
Inserts a facet from a specified locale into a target locale.  
  
## Syntax  
  
```  
template<class Facet>  
    locale combine(  
        const locale& _Loc  
    ) const;  
```  
  
#### Parameters  
 `_Loc`  
 The locale containing the facet to be inserted into the target locale.  
  
## Return Value  
 The member function returns a locale object that replaces in or adds to **\*this** the facet `Facet` listed in `_Loc`.  
  
## Example  
  
```  
// locale_combine.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
#include <tchar.h>  
using namespace std;  
  
int main() {  
   locale loc ( "German_germany" );  
   _TCHAR * s1 = _T("Das ist wei\x00dfzz."); // \x00df is the German sharp-s; it comes before z in the German alphabet  
   _TCHAR * s2 = _T("Das ist weizzz.");  
   int result1 = use_facet<collate<_TCHAR> > ( loc ).  
      compare (s1, &s1[_tcslen( s1 )-1 ],  s2, &s2[_tcslen( s2 )-1 ] );  
   cout << isalpha (_T ( '\x00df' ), loc ) << result1 << endl;  
  
   locale loc2 ( "C" );  
   int result2 = use_facet<collate<_TCHAR> > ( loc2 ).  
      compare (s1, &s1[_tcslen( s1 )-1 ],  s2, &s2[_tcslen( s2 )-1 ] );  
   cout << isalpha (_T ( '\x00df' ), loc2 )  << result2 << endl;  
  
   locale loc3 = loc2.combine<collate<_TCHAR> > (loc);  
   int result3 = use_facet<collate<_TCHAR> > ( loc3 ).  
      compare (s1, &s1[_tcslen( s1 )-1 ],  s2, &s2[_tcslen( s2 )-1 ] );  
   cout << isalpha (_T ( '\x00df' ), loc3 ) << result3 << endl;  
}  
```  
  
## Sample Output  
  
```  
1-1  
01  
0-1  
```  
  
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [locale Class](../vs140/locale-class.md)