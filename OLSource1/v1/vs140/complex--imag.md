---
title: "complex::imag"
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
  - "complex::imag"
  - "imag"
  - "std.complex.imag"
  - "std::complex::imag"
  - "complex.imag"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "imag method"
ms.assetid: 702b178e-fcc8-49e9-885d-8730a40e6226
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# complex::imag
Extracts the imaginary component of a complex number.  
  
## Syntax  
  
```  
T imag( ) const;  
T imag(const T& _Right);  
```  
  
#### Parameters  
 `_Right`  
 A complex number whose imaginary value is to be extracted.  
  
## Return Value  
 The imaginary part of the complex number.  
  
## Remarks  
 For a complex number *a + bi*, the imaginary part or component is *Im(a + bi) = b.*  
  
## Example  
  
```  
// complex_imag.cpp  
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
 **Header:** <complex\>  
  
 **Namespace:** std  
  
## See Also  
 [complex Class](../vs140/complex-class.md)