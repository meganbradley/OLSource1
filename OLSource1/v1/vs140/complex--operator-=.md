---
title: "complex::operator*="
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - complex.operator*=
  - std.complex.operator*=
  - operator*=
  - std::complex::operator*=
  - complex::operator*=
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator *=
  - *= operator
  - operator*=
ms.assetid: 09c85f2d-7576-46e0-b2ed-c496bafb4387
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# complex::operator*=
Multiplies a target complex number by a factor, which may be complex or be the same type as are the real and imaginary parts of the complex number.  
  
## Syntax  
  
```  
template<class Other>  
   complex& operator*=(  
      const complex<Other>& _Right  
   );  
complex<Type>& operator*=(  
   const Type& _Right  
);  
complex<Type>& operator*=(  
   const complex<Type>& _Right  
);  
```  
  
#### Parameters  
 `_Right`  
 A complex number or a number that is of the same type as the parameter of the target complex number.  
  
## Return Value  
 A complex number that has been multiplied by the number specified as a parameter.  
  
## Remarks  
 The operation is overloaded so that simple arithmetic operations can be executed without the conversion of the data to a particular format.  
  
## Example  
  
```  
// complex_op_me.cpp  
// compile with: /EHsc  
#include <complex>  
#include <iostream>  
  
int main() {  
   using namespace std;  
   double pi = 3.14159265359;  
  
   // Example of the first member function  
   // type complex<double> multiplied by type complex<double>  
   complex <double> cl1 ( polar ( 3.0 , pi / 6 ) );  
   complex <double> cr1 ( polar ( 2.0 , pi / 3 ) );  
   cout << "The left-side complex number is cl1 = " << cl1 << endl;  
   cout << "The right-side complex number is cr1 = " << cr1 << endl;  
  
   complex <double> cs1 = cl1 * cr1;  
   cout << "Quotient of two complex numbers is: cs1 = cl1 * cr1 = "  
        << cs1 << endl;  
  
   // This is equivalent to the following operation  
   cl1  *= cr1;  
   cout << "Quotient of two complex numbers is also: cl1 *= cr1 = "  
        << cl1 << endl;  
  
   double abscl1 = abs ( cl1 );  
   double argcl1 = arg ( cl1 );  
   cout << "The modulus of cl1 is: " << abscl1 << endl;  
   cout << "The argument of cl1 is: "<< argcl1 << " radians, which is "   
        << argcl1 * 180 / pi << " degrees." << endl << endl;   
  
   // Example of the second member function  
   // type complex<double> multiplied by type double  
   complex <double> cl2 ( polar ( 3.0 , pi / 6 ) );  
   double cr2 = 5.0;  
   cout << "The left-side complex number is cl2 = " << cl2 << endl;  
   cout << "The right-side complex number is cr2 = " << cr2 << endl;  
  
   complex <double> cs2 = cl2 * cr2;  
   cout << "Quotient of two complex numbers is: cs2 = cl2 * cr2 = "   
        << cs2 << endl;  
  
   // This is equivalent to the following operation  
   cl2  *= cr2;  
   cout << "Quotient of two complex numbers is also: cl2 *= cr2 = "  
        << cl2 << endl;  
  
   double abscl2 = abs ( cl2 );  
   double argcl2 = arg ( cl2 );  
   cout << "The modulus of cl2 is: " << abscl2 << endl;  
   cout << "The argument of cl2 is: "<< argcl2 << " radians, which is "   
        << argcl2 * 180 / pi << " degrees." << endl;  
}  
```  
  
## Sample Output  
  
```  
The left-side complex number is cl1 = (2.59808,1.5)  
The right-side complex number is cr1 = (1,1.73205)  
Quotient of two complex numbers is: cs1 = cl1 * cr1 = (-6.21281e-013,6)  
Quotient of two complex numbers is also: cl1 *= cr1 = (-6.21281e-013,6)  
The modulus of cl1 is: 6  
The argument of cl1 is: 1.5708 radians, which is 90 degrees.  
  
The left-side complex number is cl2 = (2.59808,1.5)  
The right-side complex number is cr2 = 5  
Quotient of two complex numbers is: cs2 = cl2 * cr2 = (12.9904,7.5)  
Quotient of two complex numbers is also: cl2 *= cr2 = (12.9904,7.5)  
The modulus of cl2 is: 15  
The argument of cl2 is: 0.523599 radians, which is 30 degrees.  
```  
  
## Requirements  
 **Header:** <complex\>  
  
 **Namespace:** std  
  
## See Also  
 [complex Class](../vs140/complex-class.md)