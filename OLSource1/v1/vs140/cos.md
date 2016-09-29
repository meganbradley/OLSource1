---
title: "cos"
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
  - "cos"
  - "std.cos"
  - "std::cos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cos function"
ms.assetid: 9972ddd9-17e1-4a75-b0de-f79863699898
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cos
Returns the cosine of a complex number.  
  
## Syntax  
  
```  
  
   template<class Type>  
complex<Type> cos(  
   const complex<Type>& _ComplexNum  
);  
```  
  
#### Parameters  
 `_ComplexNum`  
 The complex number whose cosine is being determined.  
  
## Return Value  
 The complex number that is the cosine of the input complex number.  
  
## Remarks  
 Identities defining the complex cosines:  
  
 cos (*z*) = (1/2)\*( exp (*iz*) + exp (-*iz*) )  
  
 cos (*z*) = cos (*a* + *bi*) = cos (*a*) cosh (*b*) - isin (*a*) sinh (*b*)  
  
## Example  
  
```  
// complex_cos.cpp  
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
   complex <double> c2 = cos ( c1 );  
   cout << "Complex number c2 = cos ( c1 ) = " << c2 << endl;  
   double absc2 = abs ( c2 );  
   double argc2 = arg ( c2 );  
   cout << "The modulus of c2 is: " << absc2 << endl;  
   cout << "The argument of c2 is: "<< argc2 << " radians, which is "   
        << argc2 * 180 / pi << " degrees." << endl << endl;   
  
   // Cosines of the standard angles in the first   
   // two quadrants of the complex plane  
   vector <complex <double> > v1;  
   vector <complex <double> >::iterator Iter1;  
   complex <double> vc1  ( polar (1.0, pi / 6) );  
   v1.push_back( cos ( vc1 ) );  
   complex <double> vc2  ( polar (1.0, pi / 3) );  
   v1.push_back( cos ( vc2 ) );  
   complex <double> vc3  ( polar (1.0, pi / 2) );  
   v1.push_back( cos ( vc3) );  
   complex <double> vc4  ( polar (1.0, 2 * pi / 3) );  
   v1.push_back( cos ( vc4 ) );  
   complex <double> vc5  ( polar (1.0, 5 * pi / 6) );  
   v1.push_back( cos ( vc5 ) );  
   complex <double> vc6  ( polar (1.0,  pi ) );  
   v1.push_back( cos ( vc6 ) );  
  
   cout << "The complex components cos (vci), where abs (vci) = 1"  
        << "\n& arg (vci) = i * pi / 6 of the vector v1 are:\n" ;  
   for ( Iter1 = v1.begin( ) ; Iter1 != v1.end( ) ; Iter1++ )  
      cout << *Iter1 << endl;  
}  
```  
  
 **Complex number c1 = (3,4)**  
**Complex number c2 = cos ( c1 ) = (-27.0349,-3.85115)**  
**The modulus of c2 is: 27.3079**  
**The argument of c2 is: -3.00009 radians, which is -171.893 degrees.**  
**The complex components cos (vci), where abs (vci) = 1**  
**& arg (vci) = i \* pi / 6 of the vector v1 are:**  
**(0.730543,-0.39695)**  
**(1.22777,-0.469075)**  
**(1.54308,1.21529e-013)**  
**(1.22777,0.469075)**  
**(0.730543,0.39695)**  
**(0.540302,-1.74036e-013)**   
## Requirements  
 **Header:** \<complex>  
  
 **Namespace:** std