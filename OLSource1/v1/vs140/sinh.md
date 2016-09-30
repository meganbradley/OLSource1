---
title: "sinh"
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
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sinh function"
ms.assetid: 2188cb75-07c3-4bab-978c-a9e24f4c5cb9
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sinh
Returns the hyperbolic sine of a complex number.  
  
## Syntax  
  
```  
  
   template<class Type>  
complex<Type> sinh(  
   const complex<Type>& _ComplexNum  
);  
```  
  
#### Parameters  
 `_ComplexNum`  
 The complex number whose hyperbolic sine is being determined.  
  
## Return Value  
 The complex number that is the hyperbolic sine of the input complex number.  
  
## Remarks  
 Identities defining the complex hyperbolic sines:  
  
 sinh (*z*) = (1/2)\*( exp (*z*) – exp (-*z*) )  
  
 sinh (*z*) = sinh (*a + bi*) = sinh (*a*) cos (*b*) + *i*cosh (*a*) sin (*b*)  
  
## Example  
  
```  
// complex_sinh.cpp  
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
  
   // Values of sine of a complex number c1  
   complex <double> c2 = sinh ( c1 );  
   cout << "Complex number c2 = sinh ( c1 ) = " << c2 << endl;  
   double absc2 = abs ( c2 );  
   double argc2 = arg ( c2 );  
   cout << "The modulus of c2 is: " << absc2 << endl;  
   cout << "The argument of c2 is: "<< argc2 << " radians, which is "   
        << argc2 * 180 / pi << " degrees." << endl << endl;   
  
   // Hyperbolic sines of the standard angles in   
   // the first two quadrants of the complex plane  
   vector <complex <double> > v1;  
   vector <complex <double> >::iterator Iter1;  
   complex <double> vc1  ( polar ( 1.0, pi / 6 ) );  
   v1.push_back( sinh ( vc1 ) );  
   complex <double> vc2  ( polar ( 1.0, pi / 3 ) );  
   v1.push_back( sinh ( vc2 ) );  
   complex <double> vc3  ( polar ( 1.0, pi / 2 ) );  
   v1.push_back( sinh ( vc3) );  
   complex <double> vc4  ( polar ( 1.0, 2 * pi / 3 ) );  
   v1.push_back( sinh ( vc4 ) );  
   complex <double> vc5  ( polar ( 1.0, 5 * pi / 6 ) );  
   v1.push_back( sinh ( vc5 ) );  
   complex <double> vc6  ( polar ( 1.0, pi ) );  
   v1.push_back( sinh ( vc6 ) );  
  
   cout << "The complex components sinh (vci), where abs (vci) = 1"  
        << "\n& arg (vci) = i * pi / 6 of the vector v1 are:\n" ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << endl;  
}  
```  
  
 **Complex number c1 = (3,4)**  
**Complex number c2 = sinh ( c1 ) = (-6.54812,-7.61923)**  
**The modulus of c2 is: 10.0464**  
**The argument of c2 is: -2.28073 radians, which is -130.676 degrees.**  
**The complex components sinh (vci), where abs (vci) = 1**  
**& arg (vci) = i \* pi / 6 of the vector v1 are:**  
**(0.858637,0.670731)**  
**(0.337596,0.85898)**  
**(-5.58735e-014,0.841471)**  
**(-0.337596,0.85898)**  
**(-0.858637,0.670731)**  
**(-1.1752,-3.19145e-013)**   
## Requirements  
 **Header:** \<complex>  
  
 **Namespace:** std