---
title: "log10"
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
  - "std::log10"
  - "std.log10"
  - "log10"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "log10 function"
ms.assetid: f5e86ddf-ab8a-49c7-baa9-8102957942b5
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# log10
Returns the base 10 logarithm of a complex number.  
  
## Syntax  
  
```  
  
   template<class Type>  
complex<Type> log10(  
   const complex<Type>& _ComplexNum  
);  
```  
  
#### Parameters  
 `_ComplexNum`  
 The complex number whose base 10 logarithm is being determined.  
  
## Return Value  
 The complex number that is the base 10 logarithm of the input complex number.  
  
## Remarks  
 The branch cuts are along the negative real axis.  
  
## Example  
  
```  
// complex_log10.cpp  
// compile with: /EHsc  
#include <vector>  
#include <complex>  
#include <iostream>  
  
int main() {  
   using namespace std;  
   double pi = 3.14159265359;  
   complex <double> c1 ( 3.0 , 4.0 );  
   cout << "Complex number c1 = " << c1 << endl;  
  
   // Values of log10 of a complex number c1  
   complex <double> c2 = log10 ( c1 );  
   cout << "Complex number c2 = log10 ( c1 ) = " << c2 << endl;  
   double absc2 = abs ( c2 );  
   double argc2 = arg ( c2 );  
   cout << "The modulus of c2 is: " << absc2 << endl;  
   cout << "The argument of c2 is: "<< argc2 << " radians, which is "   
        << argc2 * 180 / pi << " degrees." << endl << endl;   
  
   // log10 of the standard angles    
   // in the first two quadrants of the complex plane  
   vector <complex <double> > v1;  
   vector <complex <double> >::iterator Iter1;  
   complex <double> vc1  ( polar (1.0, pi / 6) );  
   v1.push_back( log10 ( vc1 ) );  
   complex <double> vc2  ( polar (1.0, pi / 3) );  
   v1.push_back( log10 ( vc2 ) );  
   complex <double> vc3  ( polar (1.0, pi / 2) );  
   v1.push_back( log10 ( vc3) );  
   complex <double> vc4  ( polar (1.0, 2 * pi / 3) );  
   v1.push_back( log10 ( vc4 ) );  
   complex <double> vc5  ( polar (1.0, 5 * pi / 6) );  
   v1.push_back( log10 ( vc5 ) );  
   complex <double> vc6  ( polar (1.0,  pi ) );  
   v1.push_back( log10 ( vc6 ) );  
  
   cout << "The complex components log10 (vci), where abs (vci) = 1"  
        << "\n& arg (vci) = i * pi / 6 of the vector v1 are:\n" ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << endl;  
}  
```  
  
## Sample Output  
  
```  
Complex number c1 = (3,4)  
Complex number c2 = log10 ( c1 ) = (0.69897,0.402719)  
The modulus of c2 is: 0.806686  
The argument of c2 is: 0.522706 radians, which is 29.9489 degrees.  
  
The complex components log10 (vci), where abs (vci) = 1  
& arg (vci) = i * pi / 6 of the vector v1 are:  
(0,0.227396)  
(0,0.454792)  
(0,0.682188)  
(0,0.909584)  
(0,1.13698)  
(0,-1.36438)  
```  
  
## Requirements  
 **Header:** <complex\>  
  
 **Namespace:** std