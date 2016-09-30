---
title: "conj"
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
  - "std::conj"
  - "std.conj"
  - "conj"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "conj function"
ms.assetid: 2852df59-6f2c-4ba2-8ab5-c878d72af192
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# conj
Returns the complex conjugate of a complex number.  
  
## Syntax  
  
```  
  
   template<class Type>  
complex<Type> conj(  
   const complex<Type>& _ComplexNum  
);  
```  
  
#### Parameters  
 `_ComplexNum`  
 The complex number whose complex conjugate is being returned.  
  
## Return Value  
 The complex conjugate of the input complex number.  
  
## Remarks  
 The complex conjugate of a complex number *a + bi* is *a – bi*. The product of a complex number and its conjugate is the norm of the number *a*2 + *b*2.  
  
## Example  
  
```  
// complex_conj.cpp  
// compile with: /EHsc  
#include <complex>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
  
   complex <double> c1 ( 4.0 , 3.0 );  
   cout << "The complex number c1 = " << c1 << endl;  
  
   double dr1 = real ( c1 );  
   cout << "The real part of c1 is real ( c1 ) = "  
        << dr1 << "." << endl;  
  
   double di1 = imag ( c1 );  
   cout << "The imaginary part of c1 is imag ( c1 ) = "  
        << di1 << "." << endl;  
  
   complex <double> c2 = conj ( c1 );  
   cout << "The complex conjugate of c1 is c2 = conj ( c1 )= "  
        << c2 << endl;  
  
   double dr2 = real ( c2 );  
   cout << "The real part of c2 is real ( c2 ) = "  
        << dr2 << "." << endl;  
  
   double di2 = imag ( c2 );  
   cout << "The imaginary part of c2 is imag ( c2 ) = "  
        << di2 << "." << endl;  
  
   // The real part of the product of a complex number  
   // and its conjugate is the norm of the number  
   complex <double> c3 = c1 * c2;  
   cout << "The norm of (c1 * conj (c1) ) is c1 * c2 = "  
        << real( c3 ) << endl;  
}  
```  
  
 **The complex number c1 = (4,3)**  
**The real part of c1 is real ( c1 ) = 4.**  
**The imaginary part of c1 is imag ( c1 ) = 3.**  
**The complex conjugate of c1 is c2 = conj ( c1 )= (4,-3)**  
**The real part of c2 is real ( c2 ) = 4.**  
**The imaginary part of c2 is imag ( c2 ) = -3.**  
**The norm of (c1 \* conj (c1) ) is c1 \* c2 = 25**   
## Requirements  
 **Header:** \<complex>  
  
 **Namespace:** std