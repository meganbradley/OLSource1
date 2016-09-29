---
title: "complex::operator="
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
  - "="
  - "operator="
  - "complex::operator="
  - "std.complex.operator="
  - "std::complex::operator="
  - "complex.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator=, complex numbers"
  - "operator =, complex numbers"
  - "operator="
  - "operator ="
  - "= operator, with specific standard C++ library objects"
ms.assetid: e48f1e39-8b76-4fcf-bfce-b1426bdfa5f3
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# complex::operator=
Assigns a number to a target complex number, where the number assigned may be complex or of the same type as are the real and imaginary parts of the complex number to which it is being assigned.  
  
## Syntax  
  
```  
template<class Other>  
   complex<Type>& operator=(  
      const complex<Other>& _Right  
   );  
complex<Type>& operator=(  
   const Type& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 A complex number or a number that is of the same type as the parameter of the target complex number.  
  
## Return Value  
 A complex number that has been assigned the number specified as a parameter.  
  
## Remarks  
 The operation is overloaded so that simple arithmetic operations can be executed without the conversion of the data to a particular format.  
  
## Example  
  
```  
// complex_op_as.cpp  
// compile with: /EHsc  
#include <complex>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   double pi = 3.14159265359;  
  
   // Example of the first member function  
   // type complex<double> assigned to type complex<double>  
   complex <double> cl1 ( 3.0 , 4.0 );  
   complex <double> cr1 ( 2.0 , -1.0 );  
   cout << "The left-side complex number is cl1 = " << cl1 << endl;  
   cout << "The right-side complex number is cr1 = " << cr1 << endl;  
  
   cl1  = cr1;  
   cout << "The complex number cr1 assigned to the complex number cl1 is:"  
        << "\n cl1 = cr1 = " << cl1 << endl;  
  
   // Example of the second member function  
   // type double assigned to type complex<double>  
   complex <double> cl2 ( -2 , 4 );  
   double cr2 =5.0;  
   cout << "The left-side complex number is cl2 = " << cl2 << endl;  
   cout << "The right-side complex number is cr2 = " << cr2 << endl;  
  
   cl2 = cr2;  
   cout << "The complex number cr2 assigned to the complex number cl2 is:"  
        << "\n cl2 = cr2 = " << cl2 << endl;  
  
   cl2 = complex<double>(3.0, 4.0);  
   cout << "The complex number (3, 4) assigned to the complex number cl2 is:"  
        << "\n cl2 = " << cl2 << endl;  
}  
```  
  
 **The left-side complex number is cl1 = (3,4)**  
**The right-side complex number is cr1 = (2,-1)**  
**The complex number cr1 assigned to the complex number cl1 is:**  
 **cl1 = cr1 = (2,-1)**  
**The left-side complex number is cl2 = (-2,4)**  
**The right-side complex number is cr2 = 5**  
**The complex number cr2 assigned to the complex number cl2 is:**  
 **cl2 = cr2 = (5,0)**  
**The complex number (3, 4) assigned to the complex number cl2 is:**  
 **cl2 = (3,4)**   
## Requirements  
 **Header:** <complex\>  
  
 **Namespace:** std  
  
## See Also  
 [complex Class](../vs140/complex-class.md)