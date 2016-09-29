---
title: "num_put::put"
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
  - "std::num_put::put"
  - "xlocnum/std::num_put::put"
  - "std.num_put.put"
  - "num_put.put"
  - "num_put::put"
  - "put"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put method"
ms.assetid: f8168dc4-dcff-41d4-af02-3e2d36bd7029
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# num_put::put
Converts a number into a sequence of **CharType**s that represents the number formatted for a given locale.  
  
## Syntax  
  
```  
iter_type put(  
    iter_type _Dest,  
    ios_base& _Iosbase,  
    _Elem _Fill,  
    bool _Val  
) const;  
iter_type put(  
    iter_type _Dest,  
    ios_base& _Iosbase,  
    _Elem _Fill,  
    long _Val  
) const;  
iter_type put(  
    iter_type _Dest,  
    ios_base& _Iosbase,  
    _Elem _Fill,  
    unsigned long _Val  
) const;  
iter_type put(  
    iter_type _Dest,  
    ios_base& _Iosbase,  
    _Elem _Fill,  
    Long long _Val  
) const;  
iter_type put(  
    iter_type _Dest,  
    ios_base& _Iosbase,  
    _Elem _Fill,  
    Unsigned long long _Val  
) const;  
  
iter_type put(  
    iter_type _Dest,  
    ios_base& _Iosbase,  
    _Elem _Fill,  
    double _Val  
) const;  
iter_type put(  
    iter_type _Dest,  
    ios_base& _Iosbase,  
    _Elem _Fill,  
    long double _Val  
) const;  
iter_type put(  
    iter_type _Dest,  
    ios_base& _Iosbase,  
    _Elem _Fill,  
    const void * _Val  
) const;  
```  
  
#### Parameters  
 `_Dest`  
 An iterator addressing the first element of the inserted string.  
  
 `_Iosbase`  
 Specified the stream that contains locale with the numpunct facet used to punctuate the output and flags for formatting the output.  
  
 `_Fill`  
 A character that is used for spacing.  
  
 `_Val`  
 The number or Boolean type that is to be output.  
  
## Return Value  
 An output iterator the addresses the position one beyond the last element produced.  
  
## Remarks  
 All member functions return [do_put](../vs140/num_put--do_put.md)(`_Next`, `_Iosbase`, `_Fill`, `_Val`).  
  
## Example  
  
```  
// num_put_put.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
#include <sstream>  
using namespace std;  
int main( )  
{  
   locale loc( "german_germany" );  
   basic_stringstream<char> psz2;  
   ios_base::iostate st = 0;  
   long double fVal;  
   cout << "The thousands separator is: "   
        << use_facet < numpunct <char> >(loc).thousands_sep( )   
        << endl;  
  
   psz2.imbue( loc );  
   use_facet < num_put < char > >  
      ( loc ).put(basic_ostream<char>::_Iter(psz2.rdbuf( ) ),  
                    psz2, ' ', fVal=1000.67);  
  
   if ( st & ios_base::failbit )  
      cout << "num_put( ) FAILED" << endl;  
   else  
      cout << "num_put( ) = " << psz2.rdbuf( )->str( ) << endl;  
}  
```  
  
 **The thousands separator is: .**  
**num_put( ) = 1.000,67**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [num_put Class](../vs140/num_put-class.md)