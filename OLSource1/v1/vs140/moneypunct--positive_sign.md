---
title: "moneypunct::positive_sign"
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
  - moneypunct::positive_sign
  - std::moneypunct::positive_sign
  - locale/std::moneypunct::positive_sign
  - moneypunct.positive_sign
  - std.moneypunct.positive_sign
  - positive_sign
dev_langs: 
  - C++
helpviewer_keywords: 
  - positive_sign method
ms.assetid: 5d521cb5-f40c-460e-a863-f7e320b06e04
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# moneypunct::positive_sign
Returns a locale-specific sequence of elements to use as a positive sign symbol.  
  
## Syntax  
  
```  
string_type positive_sign( ) const;  
```  
  
## Return Value  
 A locale-specific sequence of elements to use as a positive sign symbol.  
  
## Remarks  
 The member function returns [do_positive_sign](../vs140/moneypunct--do_positive_sign.md).  
  
## Example  
  
```  
// moneypunct_pos_sign.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
#include <sstream>  
  
using namespace std;  
  
int main( )  
{  
   locale loc( "german_germany" );  
  
   const moneypunct <char, true> &mpunct =   
      use_facet <moneypunct <char, true > >(loc);  
   cout << loc.name( ) << " international positive sign:"  
        << mpunct.positive_sign( ) << endl;  
  
   const moneypunct <char, false> &mpunct2 =   
      use_facet <moneypunct <char, false> >(loc);  
   cout << loc.name( ) << " domestic positive sign:"  
        << mpunct2.positive_sign( ) << endl;  
  
   locale loc2( "French" );  
  
   const moneypunct <char, true> &mpunct3 =   
      use_facet <moneypunct <char, true> >(loc2);  
   cout << loc2.name( ) << " international positive sign:"  
        << mpunct3.positive_sign( ) << endl;  
  
   const moneypunct <char, false> &mpunct4 =   
      use_facet <moneypunct <char, false> >(loc2);  
   cout << loc2.name( ) << " domestic positive sign:"  
        << mpunct4.positive_sign( ) << endl;  
};  
```  
  
 **German_Germany.1252 international positive sign:**  
**German_Germany.1252 domestic positive sign:**  
**French_France.1252 international positive sign:**  
**French_France.1252 domestic positive sign:**   
## Requirements  
 **Header:** <locale\>  
  
 **Namespace:** std  
  
## See Also  
 [moneypunct Class](../vs140/moneypunct-class.md)