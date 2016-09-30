---
title: "moneypunct::decimal_point"
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
  - "std::moneypunct::decimal_point"
  - "moneypunct.decimal_point"
  - "std.moneypunct.decimal_point"
  - "moneypunct::decimal_point"
  - "decimal_point"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "decimal_point method"
ms.assetid: 76f6d42f-a58e-4f9b-8ff5-67525055e874
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# moneypunct::decimal_point
Returns a locale-specific sequence of elements to use as a decimal point symbol.  
  
## Syntax  
  
```  
CharType decimal_point( ) const;  
```  
  
## Return Value  
 A locale-specific sequence of elements to use as a decimal point symbol.  
  
## Remarks  
 The member function returns [do_decimal_point](../vs140/moneypunct--do_decimal_point.md).  
  
## Example  
  
```  
// moneypunct_decimal_pt.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
#include <sstream>  
using namespace std;  
int main( )  
{  
   locale loc("german_germany");  
  
   const moneypunct < char, true > &mpunct = use_facet   
      < moneypunct < char, true > >(loc);  
   cout << loc.name( ) << " international decimal point "  
        << mpunct.decimal_point( ) << endl;  
  
   const moneypunct < char, false> &mpunct2 = use_facet   
      < moneypunct < char, false> >(loc);  
   cout << loc.name( ) << " domestic decimal point "  
        << mpunct2.decimal_point( ) << endl;  
}  
```  
  
 **German_Germany.1252 international decimal point ,**  
**German_Germany.1252 domestic decimal point ,**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [moneypunct Class](../vs140/moneypunct-class.md)