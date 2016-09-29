---
title: "sin (&lt;valarray&gt;)"
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
  - "valarray/std::sin"
  - "sin"
  - "std::sin"
  - "std.sin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sin function"
ms.assetid: 121fc5bd-21b8-44cf-b991-5b32c7b71dd0
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sin (&lt;valarray&gt;)
Operates on the elements of an input valarray, returning a valarray whose elements are equal to the sine of the elements of the input valarray.  
  
## Syntax  
  
```  
  
   template<class Type>  
valarray<Type> sin(  
   const valarray<Type>& _Left  
);  
```  
  
#### Parameters  
 `_Left`  
 The input valarray whose elements are to be operated on by the member function.  
  
## Return Value  
 A valarray whose elements are equal to the sine of the elements of the input valarray.  
  
## Example  
  
```  
// valarray_sin.cpp  
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
   for ( i = 0 ; i < 9 ; i++ )   
      va1 [ i ] =  pi * ( 0.25 * i - 1 );  
   valarray<double> va2 ( 9 );  
  
   cout << "The initial valarray is:\n";  
   for ( i = 0 ; i < 9 ; i++ )  
      cout << setw(10) << va1 [ i ]  
      << "   radians, which is   "   
      << setw(5) << ( 180/pi ) * va1 [ i ]  
      << "   degrees" << endl;  
   cout << endl;  
  
   va2 = sin ( va1 );  
   cout << "The sine of the initial valarray is:\n";  
   for ( i = 0 ; i < 9 ; i++ )  
      cout << va2 [ i ] << endl;  
}  
```  
  
 **The initial valarray is:**  
 **-3.14159   radians, which is    -180   degrees**  
 **-2.35619   radians, which is    -135   degrees**  
 **-1.5708   radians, which is     -90   degrees**  
 **-0.785398   radians, which is     -45   degrees**  
 **0   radians, which is       0   degrees**  
 **0.785398   radians, which is      45   degrees**  
 **1.5708   radians, which is      90   degrees**  
 **2.35619   radians, which is     135   degrees**  
 **3.14159   radians, which is     180   degrees**  
**The sine of the initial valarray is:**  
**2.06823e-013**  
**-0.707107**  
**-1**  
**-0.707107**  
**0**  
**0.707107**  
**1**  
**0.707107**  
**-2.06823e-013**   
## Requirements  
 **Header:** <valarray\>  
  
 **Namespace:** std  
  
## See Also  
 [Trigonometry Functions](../vs140/trigonometry-functions.md)