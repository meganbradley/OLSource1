---
title: "exp"
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
  - std::exp
  - std.exp
  - exp
dev_langs: 
  - C++
helpviewer_keywords: 
  - exp function
ms.assetid: 024e6a32-0c0d-4953-9c3a-cea7d391e33d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# exp
Returns the exponential function of a complex number.  
  
## Syntax  
  
```  
  
   template<class Type>  
complex<Type> exp(  
   const complex<Type>& _ComplexNum  
);  
```  
  
#### Parameters  
 `_ComplexNum`  
 The complex number whose exponential is being determined.  
  
## Return Value  
 The complex number that is the exponential of the input complex number.  
  
## Example  
  
```  
// complex_exp.cpp  
// compile with: /EHsc  
#include <vector>  
#include <complex>  
#include <iostream>  
  
int main() {  
   using namespace std;  
   double pi = 3.14159265359;  
   complex <double> c1 ( 1 , pi/6 );  
   cout << "Complex number c1 = " << c1 << endl;  
  
   // Value of exponential of a complex number c1:  
   // note the argument of c2 is determined by the  
   // imaginary part of c1 & the modulus by the real part  
   complex <double> c2 = exp ( c1 );  
   cout << "Complex number c2 = exp ( c1 ) = " << c2 << endl;  
   double absc2 = abs ( c2 );  
   double argc2 = arg ( c2 );  
   cout << "The modulus of c2 is: " << absc2 << endl;  
   cout << "The argument of c2 is: "<< argc2 << " radians, which is "   
        << argc2 * 180 / pi << " degrees." << endl << endl;   
  
   // Exponentials of the standard angles   
   // in the first two quadrants of the complex plane  
   vector <complex <double> > v1;  
   vector <complex <double> >::iterator Iter1;  
   complex <double> vc1  ( 0.0 , -pi );  
   v1.push_back( exp ( vc1 ) );  
   complex <double> vc2  ( 0.0, -2 * pi / 3 );  
   v1.push_back( exp ( vc2 ) );  
   complex <double> vc3  ( 0.0, 0.0 );  
   v1.push_back( exp ( vc3 ) );  
   complex <double> vc4  ( 0.0, pi / 3 );  
   v1.push_back( exp ( vc4 ) );  
   complex <double> vc5  ( 0.0 , 2 * pi / 3 );  
   v1.push_back( exp ( vc5 ) );  
   complex <double> vc6  ( 0.0, pi );  
   v1.push_back( exp ( vc6 ) );  
  
   cout << "The complex components exp (vci), where abs (vci) = 1"  
        << "\n& arg (vci) = i * pi / 3 of the vector v1 are:\n" ;  
   for ( Iter1 = v1.begin() ; Iter1 != v1.end() ; Iter1++ )  
      cout <<  ( * Iter1 ) << "\n     with argument = "   
           << ( 180/pi ) * arg ( *Iter1 )   
           << " degrees\n     modulus = "  
           << abs ( * Iter1 ) << endl;  
}  
```  
  
## Output  
  
```  
Complex number c1 = (1,0.523599)  
Complex number c2 = exp ( c1 ) = (2.3541,1.35914)  
The modulus of c2 is: 2.71828  
The argument of c2 is: 0.523599 radians, which is 30 degrees.  
  
The complex components exp (vci), where abs (vci) = 1  
& arg (vci) = i * pi / 3 of the vector v1 are:  
(-1,2.06823e-013)  
     with argument = 180 degrees  
     modulus = 1  
(-0.5,-0.866025)  
     with argument = -120 degrees  
     modulus = 1  
(1,0)  
     with argument = 0 degrees  
     modulus = 1  
(0.5,0.866025)  
     with argument = 60 degrees  
     modulus = 1  
(-0.5,0.866025)  
     with argument = 120 degrees  
     modulus = 1  
(-1,-2.06823e-013)  
     with argument = -180 degrees  
     modulus = 1  
```  
  
## Requirements  
 **Header:** <complex\>  
  
 **Namespace:** std