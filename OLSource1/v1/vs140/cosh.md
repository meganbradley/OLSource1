---
title: "cosh"
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
  - "cosh"
  - "std::cosh"
  - "std.cosh"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cosh function"
ms.assetid: c55ad8c3-ca2b-442a-9943-76bf5dd8a479
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cosh
Returns the hyperbolic cosine of a complex number.  
  
## Syntax  
  
```  
  
   template<class Type>  
complex<Type> cosh(  
   const complex<Type>& _ComplexNum  
);  
```  
  
#### Parameters  
 `_ComplexNum`  
 The complex number whose hyperbolic cosine is being determined.  
  
## Return Value  
 The complex number that is the hyperbolic cosine of the input complex number.  
  
## Remarks  
 Identities defining the complex hyperbolic cosines:  
  
 cos (*z*) = (1/2)\*( exp (*z*) + exp (-*z*) )  
  
 cos (*z*) = cosh (*a + bi*) = cosh (*a*) cos (*b*) + isinh (*a*) sin (*b*)  
  
## Example  
  
```  
// complex_cosh.cpp  
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
   complex <double> c2 = cosh ( c1 );  
   cout << "Complex number c2 = cosh ( c1 ) = " << c2 << endl;  
   double absc2 = abs ( c2 );  
   double argc2 = arg ( c2 );  
   cout << "The modulus of c2 is: " << absc2 << endl;  
   cout << "The argument of c2 is: "<< argc2 << " radians, which is "   
        << argc2 * 180 / pi << " degrees." << endl << endl;   
  
   // Hyperbolic cosines of the standard angles   
   // in the first two quadrants of the complex plane  
   vector <complex <double> > v1;  
   vector <complex <double> >::iterator Iter1;  
   complex <double> vc1  ( polar (1.0, pi / 6) );  
   v1.push_back( cosh ( vc1 ) );  
   complex <double> vc2  ( polar (1.0, pi / 3) );  
   v1.push_back( cosh ( vc2 ) );  
   complex <double> vc3  ( polar (1.0, pi / 2) );  
   v1.push_back( cosh ( vc3) );  
   complex <double> vc4  ( polar (1.0, 2 * pi / 3) );  
   v1.push_back( cosh ( vc4 ) );  
   complex <double> vc5  ( polar (1.0, 5 * pi / 6) );  
   v1.push_back( cosh ( vc5 ) );  
   complex <double> vc6  ( polar (1.0,  pi ) );  
   v1.push_back( cosh ( vc6 ) );  
  
   cout << "The complex components cosh (vci), where abs (vci) = 1"  
        << "\n& arg (vci) = i * pi / 6 of the vector v1 are:\n" ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << endl;  
}  
```  
  
 **Complex number c1 = (3,4)**  
**Complex number c2 = cosh ( c1 ) = (-6.58066,-7.58155)**  
**The modulus of c2 is: 10.0392**  
**The argument of c2 is: -2.28564 radians, which is -130.957 degrees.**  
**The complex components cosh (vci), where abs (vci) = 1**  
**& arg (vci) = i \* pi / 6 of the vector v1 are:**  
**(1.22777,0.469075)**  
**(0.730543,0.39695)**  
**(0.540302,-8.70178e-014)**  
**(0.730543,-0.39695)**  
**(1.22777,-0.469075)**  
**(1.54308,2.43059e-013)**   
## Requirements  
 **Header:** <complex\>  
  
 **Namespace:** std