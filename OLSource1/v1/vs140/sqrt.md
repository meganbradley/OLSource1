---
title: "sqrt"
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
  - "sqrt"
  - "std::sqrt"
  - "std.sqrt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sqrt function"
ms.assetid: 4f518db7-a438-4844-aace-9e192ef4934e
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sqrt
Calculates the square root of a complex number.  
  
## Syntax  
  
```  
  
   template<class Type>  
complex<Type> sqrt(  
   const complex<Type>& _ComplexNum  
);  
```  
  
#### Parameters  
 `_ComplexNum`  
 The complex number whose square root is to be found.  
  
## Return Value  
 The square root of a complex number.  
  
## Remarks  
 The square root will have a phase angle in the half-open interval (-pi/2, pi/2].  
  
 The branch cuts in the complex plane are along the negative real axis.  
  
 The square root of a complex number will have a modulus that is the square root of the input number and an argument that is one-half that of the input number.  
  
## Example  
  
```  
// complex_sqrt.cpp  
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
   complex <double> c1 ( polar ( 25.0 , pi / 2 ) );  
   complex <double> c2 = sqrt ( c1 );  
   cout << "c1 = polar ( 5.0 ) = " << c1 << endl;  
   cout << "c2 = sqrt ( c1 ) = " << c2 << endl;  
  
   // The modulus and argument of a complex number can be recovered  
   double absc2 = abs ( c2 );  
   double argc2 = arg ( c2 );  
   cout << "The modulus of c2 is recovered from c2 using: abs ( c2 ) = "  
        << absc2 << endl;  
   cout << "Argument of c2 is recovered from c2 using:\n arg ( c2 ) = "  
        << argc2 << " radians, which is " << argc2 * 180 / pi  
        << " degrees." << endl;  
  
   // The modulus and argument of c2 can be directly calculated  
   absc2 = sqrt( abs ( c1 ) );  
   argc2 = 0.5 * arg ( c1 );  
   cout << "The modulus of c2 = sqrt( abs ( c1 ) ) =" << absc2 << endl;  
   cout << "The argument of c2 = ( 1 / 2 ) * arg ( c1 ) ="  
        << argc2 << " radians,\n which is " << argc2 * 180 / pi  
        << " degrees." << endl;  
}  
```  
  
 **c1 = polar ( 5.0 ) = (-2.58529e-012,25)**  
**c2 = sqrt ( c1 ) = (3.53553,3.53553)**  
**The modulus of c2 is recovered from c2 using: abs ( c2 ) = 5**  
**Argument of c2 is recovered from c2 using:**  
 **arg ( c2 ) = 0.785398 radians, which is 45 degrees.**  
**The modulus of c2 = sqrt( abs ( c1 ) ) =5**  
**The argument of c2 = ( 1 / 2 ) \* arg ( c1 ) =0.785398 radians,**  
 **which is 45 degrees.**   
## Requirements  
 **Header:** <complex\>  
  
 **Namespace:** std