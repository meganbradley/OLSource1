---
title: "locale::locale"
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
  - "locale::locale"
  - "std.locale.locale"
  - "locale"
  - "std::locale::locale"
  - "xlocale/std::locale::locale"
  - "locale.locale"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "locale class, constructor"
  - "locale method"
ms.assetid: 3c604e11-4100-43dd-8d2e-eb7dbd93f02c
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# locale::locale
Creates a locale, or a copy of a locale, or a copy of locale where a facet or a category has been replaced by a facet or category from another locale.  
  
## Syntax  
  
```  
locale( );  
explicit locale(  
    const char* _Locname,  
    category _Cat = all  
);  
explicit locale(  
    const string& _Locname  
);  
locale(  
    const locale& _Loc  
);  
locale(  
    const locale& _Loc,   
    const locale& _Other,  
    category _Cat  
);  
locale(  
    const locale& _Loc,   
    const char* _Locname,  
    category _Cat  
);  
template<class Facet>  
    locale(  
        const locale& _Loc,   
        const Facet* _Fac  
    );  
```  
  
#### Parameters  
 `_Locname`  
 Name of a locale.  
  
 `_Loc`  
 A locale that is to be copied in constructing the new locale.  
  
 `_Other`  
 A locale from which to select a category.  
  
 `_Cat`  
 The category to be substituted into the constructed locale.  
  
 `_Fac`  
 The facet to be substituted into the constructed locale.  
  
## Remarks  
 The first constructor initializes the object to match the global locale. The second and third constructors initialize all the locale categories to have behavior consistent with the locale name `_Locname`. The remaining constructors copy `_Loc`, with the exceptions noted:  
  
 `locale(const locale& _Loc, const locale& _Other, category _Cat);`  
  
 replaces from `_Other` those facets corresponding to a category C for which C & `_Cat` is nonzero.  
  
 `locale(const locale& _Loc, const char* _Locname, category _Cat);`  
  
 `locale(const locale& _Loc, const string& _Locname, category _Cat);`  
  
 replaces from `locale(_Locname, _All)` those facets corresponding to a category C for which C & `_Cat`is nonzero.  
  
 `template<class Facet> locale(const locale& _Loc, Facet* _Fac);`  
  
 replaces in (or adds to) `_Loc` the facet `_Fac`, if `_Fac` is not a null pointer.  
  
 If a locale name `_Locname` is a null pointer or otherwise invalid, the function throws [runtime_error](../vs140/runtime_error-class.md).  
  
## Example  
  
```  
// locale_locale.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
#include <tchar.h>  
using namespace std;  
  
int main( ) {  
  
   // Second constructor  
   locale loc ( "German_germany" );  
   _TCHAR * s1 = _T("Das ist wei\x00dfzz."); // \x00df is the German sharp-s, it comes before z in the German alphabet  
   _TCHAR * s2 = _T("Das ist weizzz.");  
   int result1 = use_facet<collate<_TCHAR> > ( loc ).  
      compare (s1, &s1[_tcslen( s1 )-1 ],  s2, &s2[_tcslen( s2 )-1 ] );  
   cout << isalpha (_T ( '\x00df' ), loc ) << result1 << endl;  
  
   // The first (default) constructor  
   locale loc2;  
   int result2 = use_facet<collate<_TCHAR> > ( loc2 ).  
      compare (s1, &s1[_tcslen( s1 )-1 ],  s2, &s2[_tcslen( s2 )-1 ] );  
   cout << isalpha (_T ( '\x00df' ), loc2 )  << result2 << endl;  
  
   // Third constructor  
   locale loc3 (loc2,loc, _M_COLLATE );  
   int result3 = use_facet<collate<_TCHAR> > ( loc3 ).  
      compare (s1, &s1[_tcslen( s1 )-1 ],  s2, &s2[_tcslen( s2 )-1 ] );  
   cout << isalpha (_T ( '\x00df' ), loc3 ) << result3 << endl;  
  
   // Fourth constructor  
   locale loc4 (loc2, "German_Germany", _M_COLLATE );  
   int result4 = use_facet<collate<_TCHAR> > ( loc4 ).  
      compare (s1, &s1[_tcslen( s1 )-1 ],  s2, &s2[_tcslen( s2 )-1 ] );  
   cout << isalpha (_T ( '\x00df' ), loc4 ) << result4 << endl;  
}  
```  
  
## Sample Output  
  
```  
1-1  
01  
0-1  
0-1  
```  
  
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [locale Class](../vs140/locale-class.md)