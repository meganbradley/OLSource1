---
title: "locale::operator()"
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
  - "operator()"
  - "locale::operator()"
  - "std::locale::operator()"
  - "xlocale/std::locale::operator()"
  - "std.locale.operator()"
  - "locale.operator()"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator()"
  - "() operator"
ms.assetid: c6e6065e-10ab-4772-99e4-e7566192d063
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# locale::operator()
Compares two `basic_string` objects.  
  
## Syntax  
  
```  
template<Class CharType, class Traits, class Allocator>  
    bool operator()(  
        const basic_string<CharType, Traits, Allocator >& _Left,  
        const basic_string<CharType, Traits, Allocator >& _Right  
    ) const;  
```  
  
#### Parameters  
 `_Left`  
 The left string.  
  
 `_Right`  
 The right string.  
  
## Return Value  
 The member function returns:  
  
-   –1 if the first sequence compares less than the second sequence.  
  
-   +1 if the second sequence compares less than the first sequence.  
  
-   0 if the sequences are equivalent.  
  
## Remarks  
 The member function effectively executes:  
  
```  
const collate<CharType>& fac = use_fac<collate<CharType> >(*this);  
return (fac.compare(_Left.begin( ),_Left.end( ),_Right.begin( ),_Right.end( )) < 0);  
```  
  
 Thus, you can use a locale object as a function object.  
  
## Example  
  
```  
// locale_op_compare.cpp  
// compile with: /EHsc  
#include <iostream>  
#include <string>  
#include <locale>  
  
int main( )   
{  
   using namespace std;  
   wchar_t *sa = L"ztesting";  
   wchar_t *sb = L"\0x00DFtesting";  
   basic_string<wchar_t> a( sa );  
   basic_string<wchar_t> b( sb );  
  
   locale loc( "German_Germany" );  
   cout << loc( a,b ) << endl;  
  
   const collate<wchar_t>& fac = use_facet<collate<wchar_t> >( loc );  
   cout << ( fac.compare( sa, sa + a.length( ),  
       sb, sb + b.length( ) ) < 0) << endl;  
}  
```  
  
 **0**  
**0**   
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [locale Class](../vs140/locale-class.md)