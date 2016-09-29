---
title: "complex::real"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "real"
  - "complex.real"
  - "std.complex.real"
  - "complex::real"
  - "std::complex::real"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "real method"
ms.assetid: fa5cd11c-f94b-4ebf-a42d-47083a83ed6b
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# complex::real
Gets or sets the real component of a complex number.  
  
## Syntax  
  
```  
constexpr T real( ) const;  
T real(const T& _Right);  
```  
  
#### Parameters  
 `_Right`  
 A complex number whose real value is to be extracted.  
  
## Return Value  
 The real part of the complex number.  
  
## Remarks  
 For a complex number *a + bi*, the real part or component is *Re(a + bi) = a.*  
  
## Example  
  
```  
// complex_class_real.cpp  
// compile with: /EHsc  
#include <complex>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   complex <double> c1 ( 4.0 , 3.0 );  
   cout << "The complex number c1 = " << c1 << endl;  
  
   double dr1 = c1.real ( );  
   cout << "The real part of c1 is c1.real ( ) = "  
        << dr1 << "." << endl;  
  
   double di1 = c1.imag ( );  
   cout << "The imaginary part of c1 is c1.imag ( ) = "  
        << di1 << "." << endl;  
}  
```  
  
 **The complex number c1 = (4,3)**  
**The real part of c1 is c1.real ( ) = 4.**  
**The imaginary part of c1 is c1.imag ( ) = 3.**   
## Requirements  
 **Header:** \<complex>  
  
 **Namespace:** std  
  
## See Also  
 [complex Class](../vs140/complex-class.md)