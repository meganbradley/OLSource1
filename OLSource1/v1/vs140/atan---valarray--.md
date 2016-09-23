---
title: "atan (&lt;valarray&gt;)"
ms.custom: na
ms.date: 09/21/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - atan
  - valarray/std::atan
  - std.atan
  - std::atan
dev_langs: 
  - C++
helpviewer_keywords: 
  - atan function
ms.assetid: 100989a8-edd0-462f-992f-e167f85f3b29
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# atan (&lt;valarray&gt;)
Operates on the elements of an input valarray, returning a valarray whose elements are equal to the principal value of the arctangent of the elements of the input valarray.  
  
## Syntax  
  
```  
  
   template<class Type>  
valarray<Type> atan(  
   const valarray<Type>& _Left  
);  
```  
  
#### Parameters  
 `_Left`  
 The input valarray whose elements are to be operated on by the member function.  
  
## Return Value  
 A valarray whose elements are equal to the arctangent of the elements of the input valarray.  
  
## Remarks  
 The units of the returned elements are in radians.  
  
 The return value is a principal value between +pi/2 and –pi/2 that is consistent with the tangent value input.  
  
## Example  
  
```  
// valarray_atan.cpp  
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
   va1 [ 0 ] = -100;  
   for ( i = 1 ; i < 8 ; i++ )  
      va1 [ i ] =  5 * ( 0.25 * i - 1 );  
   va1 [ 8 ] = 100;  
   valarray<double> va2 ( 9 );  
  
   cout << "The initial valarray is: ";  
   for ( i = 0 ; i < 9 ; i++ )  
      cout << va1 [ i ] << " ";  
   cout << "." << endl;  
  
   va2 = atan ( va1 );  
   cout << "The arcsine of the initial valarray is:\n";  
   for ( i = 0 ; i < 9 ; i++ )  
      cout << setw(10) << va2 [ i ]  
           << "  radians, which is  "  
           << setw(11) << (180/pi) * va2 [ i ]  
           << "  degrees" << endl;  
   cout << endl;  
}  
```  
  
 **The initial valarray is: -100 -3.75 -2.5 -1.25 0 1.25 2.5 3.75 100 .**  
**The arcsine of the initial valarray is:**  
 **-1.5608  radians, which is     -89.4271  degrees**  
 **-1.31019  radians, which is     -75.0686  degrees**  
 **-1.19029  radians, which is     -68.1986  degrees**  
 **-0.896055  radians, which is     -51.3402  degrees**  
 **0  radians, which is            0  degrees**  
 **0.896055  radians, which is      51.3402  degrees**  
 **1.19029  radians, which is      68.1986  degrees**  
 **1.31019  radians, which is      75.0686  degrees**  
 **1.5608  radians, which is      89.4271  degrees**   
## Requirements  
 **Header:** <valarray\>  
  
 **Namespace:** std