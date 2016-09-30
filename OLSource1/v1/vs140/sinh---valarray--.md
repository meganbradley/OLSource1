---
title: "sinh (&lt;valarray&gt;)"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std.sinh"
  - "sinh"
  - "std::sinh"
  - "valarray/std::sinh"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sinh function"
ms.assetid: ac9a68e9-396a-4a95-a266-216a3d1333e6
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sinh (&lt;valarray&gt;)
Operates on the elements of an input valarray, returning a valarray whose elements are equal to the hyperbolic sine of the elements of the input valarray.  
  
## Syntax  
  
```  
  
   template<class Type>  
valarray<Type> sinh(  
   const valarray<Type>& _Left  
);  
```  
  
#### Parameters  
 `_Left`  
 The input valarray whose elements are to be operated on by the member function.  
  
## Return Value  
 A valarray whose elements are equal to the hyperbolic sine of the elements of the input valarray.  
  
## Remarks  
 Identities defining the hyperbolic sine in terms of exponential function:  
  
 sinh ( *z* ) = ( exp ( *z* ) – exp ( -*z* ) ) / 2  
  
## Example  
  
```  
// valarray_sinh.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
#include <iomanip>  
  
int main( )  
{  
   using namespace std;  
   double pi = 3.14159265359;  
   int i;  
  
   valarray<double> va1 ( 9 );  
   for (i = 0 ; i < 9 ; i++ )   
      va1 [ i ] =  pi * ( 0.25 * i - 1 );  
   valarray<double> va2 ( 9 );  
  
   cout << "The initial valarray is:\n";  
   for (i = 0 ; i < 9 ; i++ )  
      cout << setw( 10 ) << va1 [ i ]  
      << "   radians, which is   "  
      << setw( 5 ) << ( 180/pi ) * va1 [ i ]  
      << "  degrees" << endl;  
   cout << endl;  
  
   va2 = sinh ( va1 );  
   cout << "The hyperbolic sine of the initial valarray is:\n";  
   for ( i = 0 ; i < 9 ; i++ )  
      cout << va2 [ i ] << endl;  
}  
```  
  
 **The initial valarray is:**  
 **-3.14159   radians, which is    -180  degrees**  
 **-2.35619   radians, which is    -135  degrees**  
 **-1.5708   radians, which is     -90  degrees**  
 **-0.785398   radians, which is     -45  degrees**  
 **0   radians, which is       0  degrees**  
 **0.785398   radians, which is      45  degrees**  
 **1.5708   radians, which is      90  degrees**  
 **2.35619   radians, which is     135  degrees**  
 **3.14159   radians, which is     180  degrees**  
**The hyperbolic sine of the initial valarray is:**  
**-11.5487**  
**-5.22797**  
**-2.3013**  
**-0.868671**  
**0**  
**0.868671**  
**2.3013**  
**5.22797**  
**11.5487**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std