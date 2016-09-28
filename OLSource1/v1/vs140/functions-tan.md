---
title: "Functions tan"
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
  - "tan"
  - "std::tan"
  - "std.tan"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tan function"
  - "calculating tangents"
ms.assetid: 3ed884cb-c670-4a56-9952-e709949598d0
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Functions tan
Returns the tangent of a complex number.  
  
## Syntax  
  
```  
  
   template<class Type>  
complex<Type> tan(  
   const complex<Type>& _ComplexNum  
);  
```  
  
#### Parameters  
 `_ComplexNum`  
 The complex number whose tangent is being determined.  
  
## Return Value  
 The complex number that is the tangent of the input complex number.  
  
## Remarks  
 Identities defining the complex cotangent:  
  
 tan (*z*) = sin (*z*) / cos (*z*) = ( exp (*iz*) – exp (-*iz*) ) / *i*( exp (*iz*) + exp (-*iz*) )  
  
## Example  
  
```  
// complex_tan.cpp  
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
   complex <double> c2 = tan ( c1 );  
   cout << "Complex number c2 = tan ( c1 ) = " << c2 << endl;  
   double absc2 = abs ( c2 );  
   double argc2 = arg ( c2 );  
   cout << "The modulus of c2 is: " << absc2 << endl;  
   cout << "The argument of c2 is: "<< argc2 << " radians, which is "   
        << argc2 * 180 / pi << " degrees." << endl << endl;   
  
   // Hyperbolic tangent of the standard angles   
   // in the first two quadrants of the complex plane  
   vector <complex <double> > v1;  
   vector <complex <double> >::iterator Iter1;  
   complex <double> vc1  ( polar ( 1.0, pi / 6 ) );  
   v1.push_back( tan ( vc1 ) );  
   complex <double> vc2  ( polar ( 1.0, pi / 3 ) );  
   v1.push_back( tan ( vc2 ) );  
   complex <double> vc3  ( polar ( 1.0, pi / 2 ) );  
   v1.push_back( tan ( vc3) );  
   complex <double> vc4  ( polar ( 1.0, 2 * pi / 3 ) );  
   v1.push_back( tan ( vc4 ) );  
   complex <double> vc5  ( polar ( 1.0, 5 * pi / 6 ) );  
   v1.push_back( tan ( vc5 ) );  
   complex <double> vc6  ( polar ( 1.0,  pi ) );  
   v1.push_back( tan ( vc6 ) );  
  
   cout << "The complex components tan (vci), where abs (vci) = 1"  
        << "\n& arg (vci) = i * pi / 6 of the vector v1 are:\n" ;  
   for ( Iter1 = v1.begin() ; Iter1 != v1.end() ; Iter1++ )  
      cout << *Iter1 << endl;  
}  
```  
  
 **Complex number c1 = (3,4)**  
**Complex number c2 = tan ( c1 ) = (-0.000187346,0.999356)**  
**The modulus of c2 is: 0.999356**  
**The argument of c2 is: 1.57098 radians, which is 90.0107 degrees.**  
**The complex components tan (vci), where abs (vci) = 1**  
**& arg (vci) = i \* pi / 6 of the vector v1 are:**  
**(0.713931,0.85004)**  
**(0.24356,0.792403)**  
**(-4.34302e-014,0.761594)**  
**(-0.24356,0.792403)**  
**(-0.713931,0.85004)**  
**(-1.55741,-7.08476e-013)**   
## Requirements  
 **Header:** <complex\>  
  
 **Namespace:** std