---
title: "complex::operator-=1"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "complex::operator-="
f1_keywords: 
  - "complex.operator-="
  - "operator-="
  - "-="
  - "std::complex::operator-="
  - "std.complex.operator-="
  - "complex::operator-="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator-="
  - "-= operator"
ms.assetid: 62b55c1f-c397-4722-b9a8-1a537f3aebe8
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# complex::operator-=1
Subtracts a number from a target complex number, where the number subtracted may be complex or of the same type as are the real and imaginary parts of the complex number to which it is added.  
  
## Syntax  
  
```  
template<class Other>  
   complex<Type>& operator-=(  
      const complex<Other>& _ComplexNum  
   );  
complex<Type>& operator-=(  
   const Type& _RealPart  
);  
complex<Type>& operator-=(  
   const complex<Type>& _ComplexNum  
);  
```  
  
#### Parameters  
 `_ComplexNum`  
 A complex number to be subtracted from the target complex number.  
  
 `_RealPart`  
 A real number to be subtracted from the target complex number.  
  
## Return Value  
 A complex number that has had the number specified as a parameter subtracted from it.  
  
## Remarks  
 The operation is overloaded so that simple arithmetic operations can be executed without the conversion of the data to a particular format.  
  
## Example  
  
```  
// complex_op_se.cpp  
// compile with: /EHsc  
#include <complex>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   double pi = 3.14159265359;  
  
   // Example of the first member function  
   // type complex<double> subtracted from type complex<double>  
   complex <double> cl1 ( 3.0 , 4.0 );  
   complex <double> cr1 ( 2.0 , -1.0 );  
   cout << "The left-side complex number is cl1 = " << cl1 << endl;  
   cout << "The right-side complex number is cr1 = " << cr1 << endl;  
  
   complex <double> cs1 = cl1 - cr1;  
   cout << "The difference between the two complex numbers is:"  
        << "\n cs1 = cl1 - cr1 = " << cs1 << endl;  
  
   // This is equivalent to the following operation  
   cl1 -= cr1;  
   cout << "Complex number cr1 subtracted from complex number cl1 is:"  
        << "\n cl1 -= cr1 = " << cl1 << endl;  
  
   double abscl1 = abs ( cl1 );  
   double argcl1 = arg ( cl1 );  
   cout << "The modulus of cl1 is: " << abscl1 << endl;  
   cout << "The argument of cl1 is: "<< argcl1 << " radians, which is "   
        << argcl1 * 180 / pi << " degrees." << endl << endl;   
  
   // Example of the second member function  
   // type double subtracted from type complex<double>  
   complex <double> cl2 ( 2.0 , 4.0 );  
   double cr2 = 5.0;  
   cout << "The left-side complex number is cl2 = " << cl2 << endl;  
   cout << "The right-side complex number is cr2 = " << cr2 << endl;  
  
   complex <double> cs2 = cl2 - cr2;  
   cout << "The difference between the two complex numbers is:"  
        << "\n cs2 = cl2 - cr2 = " << cs2 << endl;  
  
   // This is equivalent to the following operation  
   cl2  -= cr2;  
   cout << "Complex number cr2 subtracted from complex number cl2 is:"  
        << "\n cl2 -= cr2 = " << cl2 << endl;  
  
   double abscl2 = abs ( cl2 );  
   double argcl2 = arg ( cl2 );  
   cout << "The modulus of cl2 is: " << abscl2 << endl;  
   cout << "The argument of cl2 is: "<< argcl2 << " radians, which is "   
        << argcl2 * 180 / pi << " degrees." << endl << endl;  
}  
```  
  
 **The left-side complex number is cl1 = (3,4)**  
**The right-side complex number is cr1 = (2,-1)**  
**The difference between the two complex numbers is:**  
 **cs1 = cl1 - cr1 = (1,5)**  
**Complex number cr1 subtracted from complex number cl1 is:**  
 **cl1 -= cr1 = (1,5)**  
**The modulus of cl1 is: 5.09902**  
**The argument of cl1 is: 1.3734 radians, which is 78.6901 degrees.**  
**The left-side complex number is cl2 = (2,4)**  
**The right-side complex number is cr2 = 5**  
**The difference between the two complex numbers is:**  
 **cs2 = cl2 - cr2 = (-3,4)**  
**Complex number cr2 subtracted from complex number cl2 is:**  
 **cl2 -= cr2 = (-3,4)**  
**The modulus of cl2 is: 5**  
**The argument of cl2 is: 2.2143 radians, which is 126.87 degrees.**   
## Requirements  
 **Header:** \<complex>  
  
 **Namespace:** std  
  
## See Also  
 [complex Class](../vs140/complex-class.md)