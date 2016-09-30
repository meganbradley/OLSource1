---
title: "complex::complex"
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
  - "complex"
  - "std::complex::complex"
  - "complex.complex"
  - "std.complex.complex"
  - "complex::complex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "complex method"
  - "complex class, constructor"
ms.assetid: b6371cf8-6f79-4dfa-8746-171140430214
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# complex::complex
Constructs a complex number with specified real and imaginary parts or as a copy of some other complex number.  
  
## Syntax  
  
```  
constexpr complex(  
    const T& _RealVal = 0,   
    const T& _ImagVal = 0  
);  
  
template<class Other>  
constexpr complex(  
      const complex<Other>& _ComplexNum  
   );  
```  
  
#### Parameters  
 `_RealVal`  
 The value of the real part used to initialize the complex number being constructed.  
  
 `_ImagVal`  
 The value of the imaginary part used to initialize the complex number being constructed.  
  
 `_ComplexNum`  
 The complex number whose real and imaginary parts are used to initialize the complex number being constructed.  
  
## Remarks  
 The first constructor initializes the stored real part to _*RealVal* and the stored imaginary part to \_*Imagval*. The second constructor initializes the stored real part to `_ComplexNum`**.real**() and the stored imaginary part to `_ComplexNum`**.imag**().  
  
 In this implementation, if a translator does not support member template functions, the template:  
  
```  
template<class Other>  
   complex(const complex<Other>& right);  
```  
  
 is replaced with:  
  
```  
  
complex(const complex& right);  
```  
  
 which is the copy constructor.  
  
## Example  
  
```  
// complex_complex.cpp  
// compile with: /EHsc  
#include <complex>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   double pi = 3.14159265359;   
  
   // The first constructor specifies real & imaginary parts  
   complex <double> c1 ( 4.0 , 5.0 );  
   cout << "Specifying initial real & imaginary parts,"  
        << "c1 = " << c1 << endl;   
  
   // The second constructor initializes values of the real &  
   // imaginary parts using those of another complex number  
   complex <double> c2 ( c1 );  
   cout << "Initializing with the real and imaginary parts of c1,"  
        << " c2 = " << c2 << endl;   
  
   // Complex numbers can be initialized in polar form  
   // but will be stored in Cartesian form  
   complex <double> c3 ( polar ( sqrt( (double)8 ) , pi / 4 ) );  
   cout << "c3 = polar ( sqrt ( 8 ) , pi / 4 ) = " << c3 << endl;   
  
   // The modulus and argument of a complex number can be recovered  
   double absc3 = abs ( c3 );  
   double argc3 = arg ( c3 );  
   cout << "The modulus of c3 is recovered from c3 using: abs ( c3 ) = "  
        << absc3 << endl;  
   cout << "Argument of c3 is recovered from c3 using:\n arg ( c3 ) = "  
        << argc3 << " radians, which is " << argc3 * 180 / pi  
        << " degrees." << endl;  
}  
```  
  
## Output  
  
```  
Specifying initial real & imaginary parts,c1 = (4,5)  
Initializing with the real and imaginary parts of c1, c2 = (4,5)  
c3 = polar ( sqrt ( 8 ) , pi / 4 ) = (2,2)  
The modulus of c3 is recovered from c3 using: abs ( c3 ) = 2.82843  
Argument of c3 is recovered from c3 using:  
 arg ( c3 ) = 0.785398 radians, which is 45 degrees.  
```  
  
## Requirements  
 **Header:** \<complex>  
  
 **Namespace:** std  
  
## See Also  
 [complex Class](../vs140/complex-class.md)