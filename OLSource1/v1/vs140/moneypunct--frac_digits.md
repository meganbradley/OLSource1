---
title: "moneypunct::frac_digits"
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
  - "frac_digits"
  - "moneypunct.frac_digits"
  - "moneypunct::frac_digits"
  - "std::moneypunct::frac_digits"
  - "std.moneypunct.frac_digits"
  - "locale/std::moneypunct::frac_digits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "frac_digits method"
ms.assetid: d051ee7a-93e6-4b4d-847b-cee234e71401
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# moneypunct::frac_digits
Returns a locale-specific count of the number of digits to display to the right of any decimal point.  
  
## Syntax  
  
```  
int frac_digits( ) const;  
```  
  
## Return Value  
 A locale-specific count of the number of digits to display to the right of any decimal point.  
  
## Remarks  
 The member function returns [do_frac_digits](../vs140/moneypunct--do_frac_digits.md).  
  
## Example  
  
```  
// moneypunct_frac_digits.cpp  
// compile with: /EHsc  
#include <locale>  
#include <iostream>  
#include <sstream>  
using namespace std;  
int main( )  
{  
   locale loc( "german_germany" );  
  
   const moneypunct <char, true> &mpunct =   
       use_facet <moneypunct <char, true> >(loc);  
   for (unsigned int i = 0; i <mpunct.grouping( ).length( ); i++ )  
   {  
      cout << loc.name( ) << " international grouping:\n the "  
           << i <<"th group to the left of the radix character "  
           << "is of size " << (int)(mpunct.grouping ( )[i])   
           << endl;  
   }  
   cout << loc.name( ) << " international frac_digits\n to the right"  
        << " of the radix character: "  
        << mpunct.frac_digits ( ) << endl << endl;  
  
   const moneypunct <char, false> &mpunct2 =   
       use_facet <moneypunct <char, false> >(loc);  
   for (unsigned int i = 0; i <mpunct2.grouping( ).length( ); i++ )  
   {  
      cout << loc.name( ) << " domestic grouping:\n the "  
           << i <<"th group to the left of the radix character "  
           << "is of size " << (int)(mpunct2.grouping ( )[i])   
           << endl;  
   }  
   cout << loc.name( ) << " domestic frac_digits\n to the right"  
        << " of the radix character: "  
        << mpunct2.frac_digits ( ) << endl << endl;  
}  
```  
  
 **German_Germany.1252 international grouping:**  
 **the 0th group to the left of the radix character is of size 3**  
**German_Germany.1252 international frac_digits**  
 **to the right of the radix character: 2**  
**German_Germany.1252 domestic grouping:**  
 **the 0th group to the left of the radix character is of size 3**  
**German_Germany.1252 domestic frac_digits**  
 **to the right of the radix character: 2**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [moneypunct Class](../vs140/moneypunct-class.md)