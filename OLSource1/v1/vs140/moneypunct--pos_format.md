---
title: "moneypunct::pos_format"
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
  - "locale/std::moneypunct::pos_format"
  - "moneypunct::pos_format"
  - "pos_format"
  - "std::moneypunct::pos_format"
  - "std.moneypunct.pos_format"
  - "moneypunct.pos_format"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pos_format method"
ms.assetid: 4717f240-fb65-4e66-b92a-b52b99915ce1
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# moneypunct::pos_format
Returns a locale-specific rule for formatting outputs with positive amounts.  
  
## Syntax  
  
```  
pattern pos_format( ) const;  
```  
  
## Return Value  
 A locale-specific rule for formatting outputs with positive amounts.  
  
## Remarks  
 The member function returns [do_pos_format](../vs140/moneypunct--do_pos_format.md).  
  
## Example  
  
```  
// moneypunct_pos_format.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
#include <sstream>  
  
using namespace std;  
  
int main() {  
   locale loc( "german_germany" );  
  
   const moneypunct <char, true> &mpunct =   
      use_facet <moneypunct <char, true> >(loc);  
   cout << loc.name( ) << " international positive number format: "  
        << mpunct.pos_format( ).field[0]   
        << mpunct.pos_format( ).field[1]   
        << mpunct.pos_format( ).field[2]   
        << mpunct.pos_format( ).field[3] << endl;  
  
   const moneypunct <char, false> &mpunct2 =   
      use_facet <moneypunct <char, false> >(loc);  
   cout << loc.name( ) << " domestic positive number format: "  
        << mpunct2.pos_format( ).field[0]   
        << mpunct2.pos_format( ).field[1]   
        << mpunct2.pos_format( ).field[2]   
        << mpunct2.pos_format( ).field[3] << endl;  
}  
```  
  
## Sample Output  
  
```  
German_Germany.1252 international positive number format: $+vx  
German_Germany.1252 domestic positive number format: +v $  
```  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [moneypunct Class](../vs140/moneypunct-class.md)