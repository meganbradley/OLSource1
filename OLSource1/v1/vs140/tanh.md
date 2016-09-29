---
title: "tanh"
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
  - "tanh"
  - "std.tanh"
  - "std::tanh"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tanh function"
ms.assetid: 19215cdd-f857-473e-b9c0-1933f0335196
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tanh
Returns the hyperbolic tangent of a complex number.  
  
## Syntax  
  
```  
  
   template<class Type>  
complex<Type> tanh(  
   const complex<Type>& _ComplexNum  
);  
```  
  
#### Parameters  
 `_ComplexNum`  
 The complex number whose hyperbolic tangent is being determined.  
  
## Return Value  
 The complex number that is the hyperbolic tangent of the input complex number.  
  
## Remarks  
 Identities defining the complex hyperbolic cotangent:  
  
 tanh (*z*) = sinh (*z*) / cosh (*z*) = ( exp (*z*) – exp (-*z*) ) / ( exp (*z*) + exp (-*z*) )  
  
## Example  
  
```  
// complex_tanh.cpp  
// compile with: /EHsc  
#include <vector>  
#include <complex>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   double pi = 3.14159265359;  
   complex <double> c1 ( 3.0 , 4.0 );  
   cout << "Complex number c1 = " << c1 << endl;  
  
   // Values of cosine of a complex number c1  
   complex <double> c2 = tanh ( c1 );  
   cout << "Complex number c2 = tanh ( c1 ) = " << c2 << endl;  
   double absc2 = abs ( c2 );  
   double argc2 = arg ( c2 );  
   cout << "The modulus of c2 is: " << absc2 << endl;  
   cout << "The argument of c2 is: "<< argc2 << " radians, which is "   
        << argc2 * 180 / pi << " degrees." << endl << endl;   
  
   // Hyperbolic tangents of the standard angles   
   // in the first two quadrants of the complex plane  
   vector <complex <double> > v1;  
   vector <complex <double> >::iterator Iter1;  
   complex <double> vc1  ( polar ( 1.0, pi / 6 ) );  
   v1.push_back( tanh ( vc1 ) );  
   complex <double> vc2  ( polar ( 1.0, pi / 3 ) );  
   v1.push_back( tanh ( vc2 ) );  
   complex <double> vc3  ( polar ( 1.0, pi / 2 ) );  
   v1.push_back( tanh ( vc3 ) );  
   complex <double> vc4  ( polar ( 1.0, 2 * pi / 3 ) );  
   v1.push_back( tanh ( vc4 ) );  
   complex <double> vc5  ( polar ( 1.0, 5 * pi / 6 ) );  
   v1.push_back( tanh ( vc5 ) );  
   complex <double> vc6  ( polar ( 1.0, pi ) );  
   v1.push_back( tanh ( vc6 ) );  
  
   cout << "The complex components tanh (vci), where abs (vci) = 1"  
        << "\n& arg (vci) = i * pi / 6 of the vector v1 are:\n" ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << endl;  
}  
```  
  
 **Complex number c1 = (3,4)**  
**Complex number c2 = tanh ( c1 ) = (1.00071,0.00490826)**  
**The modulus of c2 is: 1.00072**  
**The argument of c2 is: 0.00490474 radians, which is 0.281021 degrees.**  
**The complex components tanh (vci), where abs (vci) = 1**  
**& arg (vci) = i \* pi / 6 of the vector v1 are:**  
**(0.792403,0.24356)**  
**(0.85004,0.713931)**  
**(-3.54238e-013,1.55741)**  
**(-0.85004,0.713931)**  
**(-0.792403,0.24356)**  
**(-0.761594,-8.68604e-014)**   
## Requirements  
 **Header:** <complex\>  
  
 **Namespace:** std