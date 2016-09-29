---
title: "sin"
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
  - "sin"
  - "std::sin"
  - "std.sin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sin function"
ms.assetid: 75ad5daf-822a-4137-8f66-961ae46e7384
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sin
Returns the sine of a complex number.  
  
## Syntax  
  
```  
  
   template<class Type>  
complex<Type> sin(  
   const complex<Type>& _ComplexNum  
);  
```  
  
#### Parameters  
 `_ComplexNum`  
 The complex number whose sine is being determined.  
  
## Return Value  
 The complex number that is the sine of the input complex number.  
  
## Remarks  
 Identities defining the complex sines:  
  
 sin (*z*) = (1/2*i*)\*( exp (*iz*) – exp (-*iz*) )  
  
 sin (*z*) = sin (*a + bi*) = sin (*a*) cosh (*b*) + icos (*a*) sinh (*b*)  
  
## Example  
  
```  
// complex_sin.cpp  
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
   complex <double> c2 = sin ( c1 );  
   cout << "Complex number c2 = sin ( c1 ) = " << c2 << endl;  
   double absc2 = abs ( c2 );  
   double argc2 = arg ( c2 );  
   cout << "The modulus of c2 is: " << absc2 << endl;  
   cout << "The argument of c2 is: "<< argc2 << " radians, which is "   
        << argc2 * 180 / pi << " degrees." << endl << endl;   
  
   // sines of the standard angles in the first   
   // two quadrants of the complex plane  
   vector <complex <double> > v1;  
   vector <complex <double> >::iterator Iter1;  
   complex <double> vc1  ( polar ( 1.0, pi / 6 ) );  
   v1.push_back( sin ( vc1 ) );  
   complex <double> vc2  ( polar ( 1.0, pi / 3 ) );  
   v1.push_back( sin ( vc2 ) );  
   complex <double> vc3  ( polar ( 1.0, pi / 2 ) );  
   v1.push_back( sin ( vc3 ) );  
   complex <double> vc4  ( polar ( 1.0, 2 * pi / 3 ) );  
   v1.push_back( sin ( vc4 ) );  
   complex <double> vc5  ( polar ( 1.0, 5 * pi / 6 ) );  
   v1.push_back( sin ( vc5 ) );  
   complex <double> vc6  ( polar ( 1.0, pi ) );  
   v1.push_back( sin ( vc6 ) );  
  
   cout << "The complex components sin (vci), where abs (vci) = 1"  
        << "\n& arg (vci) = i * pi / 6 of the vector v1 are:\n" ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << endl;  
}  
```  
  
 **Complex number c1 = (3,4)**  
**Complex number c2 = sin ( c1 ) = (3.85374,-27.0168)**  
**The modulus of c2 is: 27.2903**  
**The argument of c2 is: -1.42911 radians, which is -81.882 degrees.**  
**The complex components sin (vci), where abs (vci) = 1**  
**& arg (vci) = i \* pi / 6 of the vector v1 are:**  
**(0.85898,0.337596)**  
**(0.670731,0.858637)**  
**(-1.59572e-013,1.1752)**  
**(-0.670731,0.858637)**  
**(-0.85898,0.337596)**  
**(-0.841471,-1.11747e-013)**   
## Requirements  
 **Header:** \<complex>  
  
 **Namespace:** std