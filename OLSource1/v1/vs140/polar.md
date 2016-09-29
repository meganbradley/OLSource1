---
title: "polar"
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
  - "std.polar"
  - "std::polar"
  - "polar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "polar function"
ms.assetid: 36d5b8d1-c60c-49d2-9653-91425d89d2f7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# polar
Returns the complex number, which corresponds to a specified modulus and argument, in Cartesian form.  
  
## Syntax  
  
```  
  
   template<class Type>  
complex<Type> polar(  
   const Type& _Modulus,  
   const Type& _Argument = 0  
);  
```  
  
#### Parameters  
 *_Modulus*  
 The modulus of the complex number being input.  
  
 *_Argument*  
 The argument of the complex number being input.  
  
## Return Value  
 Cartesian form of the complex number specified in polar form.  
  
## Remarks  
 The polar form of a complex number provides the modulus *r* and the argument , where these parameters are related to the real and imaginary Cartesian components *a* and *b* by the equations *a* = r \* cos (  ) and b = *r* \* sin ()*.*  
  
## Example  
  
```  
// complex_polar.cpp  
// compile with: /EHsc  
#include <complex>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   double pi = 3.14159265359;  
  
   // Complex numbers can be entered in polar form with  
   // modulus and argument parameter inputs but are  
   // stored in Cartesian form as real & imag coordinates  
   complex <double> c1 ( polar ( 5.0 ) );   // Default argument = 0  
   complex <double> c2 ( polar ( 5.0 , pi / 6 ) );  
   complex <double> c3 ( polar ( 5.0 , 13 * pi / 6 ) );  
   cout << "c1 = polar ( 5.0 ) = " << c1 << endl;  
   cout << "c2 = polar ( 5.0 , pi / 6 ) = " << c2 << endl;  
   cout << "c3 = polar ( 5.0 , 13 * pi / 6 ) = " << c3 << endl;  
  
   if ( (arg ( c2 ) <= ( arg ( c3 ) + .00000001) ) ||   
        (arg ( c2 ) >= ( arg ( c3 ) - .00000001) ) )  
      cout << "The complex numbers c2 & c3 have the "  
           << "same principal arguments."<< endl;  
   else  
      cout << "The complex numbers c2 & c3 don't have the "  
           << "same principal arguments." << endl;  
  
   // the modulus and argument of a complex number can be rcovered  
   double absc2 = abs ( c2 );  
   double argc2 = arg ( c2 );  
   cout << "The modulus of c2 is recovered from c2 using: abs ( c2 ) = "  
        << absc2 << endl;  
   cout << "Argument of c2 is recovered from c2 using:\n arg ( c2 ) = "  
        << argc2 << " radians, which is " << argc2 * 180 / pi  
        << " degrees." << endl;   
}  
```  
  
 **c1 = polar ( 5.0 ) = (5,0)**  
**c2 = polar ( 5.0 , pi / 6 ) = (4.33013,2.5)**  
**c3 = polar ( 5.0 , 13 \* pi / 6 ) = (4.33013,2.5)**  
**The complex numbers c2 & c3 have the same principal arguments.**  
**The modulus of c2 is recovered from c2 using: abs ( c2 ) = 5**  
**Argument of c2 is recovered from c2 using:**  
 **arg ( c2 ) = 0.523599 radians, which is 30 degrees.**   
## Requirements  
 **Header:** <complex\>  
  
 **Namespace:** std