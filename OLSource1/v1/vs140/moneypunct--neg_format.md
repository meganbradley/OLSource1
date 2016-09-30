---
title: "moneypunct::neg_format"
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
  - "std::moneypunct::neg_format"
  - "std.moneypunct.neg_format"
  - "neg_format"
  - "moneypunct::neg_format"
  - "moneypunct.neg_format"
  - "locale/std::moneypunct::neg_format"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "neg_format method"
ms.assetid: 2ed6d96a-da50-4dd9-918f-ce00bef41454
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# moneypunct::neg_format
Returns a locale-specific rule for formatting outputs with negative amounts.  
  
## Syntax  
  
```  
pattern neg_format( ) const;  
```  
  
## Return Value  
 A locale-specific rule for formatting outputs with negative amounts.  
  
## Remarks  
 The member function returns [do_neg_format](../vs140/moneypunct--do_neg_format.md).  
  
## Example  
  
```  
// moneypunct_neg_format.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
#include <sstream>  
  
using namespace std;  
  
int main( ) {  
   locale loc( "german_germany" );  
  
   const moneypunct <char, true> &mpunct =   
      use_facet <moneypunct <char, true > >(loc);  
   cout << loc.name( ) << " international negative number format: "  
        << mpunct.neg_format( ).field[0]   
        << mpunct.neg_format( ).field[1]   
        << mpunct.neg_format( ).field[2]   
        << mpunct.neg_format( ).field[3] << endl;  
  
   const moneypunct <char, false> &mpunct2 =   
      use_facet <moneypunct <char, false> >(loc);  
   cout << loc.name( ) << " domestic negative number format: "  
        << mpunct2.neg_format( ).field[0]   
        << mpunct2.neg_format( ).field[1]   
        << mpunct2.neg_format( ).field[2]   
        << mpunct2.neg_format( ).field[3] << endl;  
}  
```  
  
## Sample Output  
  
```  
German_Germany.1252 international negative number format: $+vx  
German_Germany.1252 domestic negative number format: +v $  
```  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [moneypunct Class](../vs140/moneypunct-class.md)