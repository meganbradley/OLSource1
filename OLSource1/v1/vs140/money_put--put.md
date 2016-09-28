---
title: "money_put::put"
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
  - "std::money_put::put"
  - "money_put::put"
  - "xlocmon/std::money_put::put"
  - "money_put.put"
  - "put"
  - "std.money_put.put"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put method"
ms.assetid: 7d12b948-c3a5-48b9-b1ee-70bdb7e5f5bd
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# money_put::put
Converts either number or a string to a character sequence that represents a monetary value.  
  
## Syntax  
  
```  
iter_type put(  
    iter_type _Next,   
    bool _Intl,   
    ios_base& _Iosbase,  
    CharType _Fill,   
    const string_type& _Val  
) const;  
iter_type put(  
    iter_type _Next,   
    bool _Intl,   
    ios_base& _Iosbase,  
    CharType _Fill,  
    long double _Val   
) const;  
```  
  
#### Parameters  
 `_Next`  
 An iterator addressing the first element of the inserted string.  
  
 `_Intl`  
 A Boolean value indicating the type of currency symbol expected in the sequence: **true** if international, **false** if domestic.  
  
 `_Iosbase`  
 A format flag which when set indicates that the currency symbol is optional; otherwise, it is required  
  
 `_Fill`  
 A character which is used for spacing.  
  
 `_Val`  
 A string object to be converted.  
  
## Return Value  
 An output iterator the addresses the position one beyond the last element produced.  
  
## Remarks  
 Both member functions return [do_put](../vs140/money_put--do_put.md)(`_Next`, `_Intl`, `_Iosbase`, `_Fill`, `_Val`).  
  
## Example  
  
```  
// money_put_put.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
#include <sstream>  
using namespace std;  
int main( )  
{  
//   locale loc( "german_germany" );  
   locale loc( "english_canada" );  
   basic_stringstream<char> psz, psz2;  
   ios_base::iostate st = 0;  
  
   psz2.imbue( loc );  
   psz2.flags( psz2.flags( )|ios_base::showbase ); // force the printing of the currency symbol  
   use_facet < money_put < char > >(loc).put(basic_ostream<char>::_Iter( psz2.rdbuf( ) ), true, psz2, st, 100012);  
   if (st & ios_base::failbit)  
      cout << "money_put( ) FAILED" << endl;  
   else  
      cout << "money_put( ) = \"" << psz2.rdbuf( )->str( ) <<"\""<< endl;     
  
   st = 0;  
};  
```  
  
 **money_put( ) = "CAD1,000.12"**   
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [money_put Class](../vs140/money_put-class.md)