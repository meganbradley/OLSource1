---
title: "operator- (&lt;complex&gt;)1"
ms.custom: na
ms.date: 09/21/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
H1: operator- (&lt;complex&gt;)
f1_keywords: 
  - std.-
  - -
  - operator-
  - std.operator-
  - std::-
  - std::operator-
dev_langs: 
  - C++
helpviewer_keywords: 
  - - operator
  - - operator, additive operators in C++
ms.assetid: 5cec877d-4d53-4ba1-9ab7-98cb02d74d48
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# operator- (&lt;complex&gt;)1
Subtracts two complex numbers, one or both of which may belong to the subset of the type for the real and imaginary parts.  
  
## Syntax  
  
```  
  
      template<class Type>  
   complex<Type> operator-(  
      const complex<Type>& _Left,  
      const complex<Type>& _Right  
   );  
template<class Type>  
   complex<Type> operator-(  
      const complex<Type>& _Left,  
      const Type& _Right  
   );  
template<class Type>  
   complex<Type> operator-(  
      const Type& _Left,  
      const complex<Type>& _Right  
   );  
template<class Type>  
   complex<Type> operator-(  
      const complex<Type>& _Left  
   );  
```  
  
#### Parameters  
 `_Left`  
 The first of two complex numbers or a number that is of the parameter type for a complex number that is to be subtracted by the - operation.  
  
 `_Right`  
 The second of two complex numbers or a number that is of the parameter type for a complex number that is to be subtracted by the - operation.  
  
## Return Value  
 The complex number that results from the subtraction of `_Right` from `_Left`, the two numbers whose values are specified by the parameter inputs.  
  
## Remarks  
 The operation is overloaded so that simple arithmetic operations can be executed without the conversion of the data to a particular format.  
  
 The unary operator changes the sign of a complex number and returns a value whose real part is the negative of the real part of the number input and whose imaginary part is the negative of the imaginary part of the number input.  
  
## Example  
  
```  
// complex_op_sub.cpp  
// compile with: /EHsc  
#include <complex>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   double pi = 3.14159265359;  
  
   // Example of the first member function  
   // type complex<double> minus type complex<double>  
   complex <double> cl1 ( 3.0 , 4.0 );  
   complex <double> cr1 ( 2.0 , 5.0 );  
   complex <double> cs1 = cl1 - cr1;  
  
   cout << "The left-side complex number is cl1 = " << cl1 << endl;  
   cout << "The right-side complex number is cr1 = " << cr1 << endl;  
   cout << "Difference of two complex numbers is: cs1 = " << cs1 << endl;  
   double abscs1 = abs ( cs1 );  
   double argcs1 = arg ( cs1 );  
   cout << "The modulus of cs1 is: " << abscs1 << endl;  
   cout << "The argument of cs1 is: "<< argcs1 << " radians, which is "   
        << argcs1 * 180 / pi << " degrees." << endl << endl;   
  
   // Example of the second member function  
   // type complex<double> minus type double  
   complex <double> cl2 ( 3.0 , 4.0 );  
   double cr2 =5.0;  
   complex <double> cs2 = cl2 - cr2;  
  
   cout << "The left-side complex number is cl2 = " << cl2 << endl;  
   cout << "The right-side complex number is cr2 = " << cr2 << endl;  
   cout << "Difference of two complex numbers is: cs2 = " << cs2 << endl;  
   double abscs2 = abs ( cs2 );  
   double argcs2 = arg ( cs2 );  
   cout << "The modulus of cs2 is: " << abscs2 << endl;  
   cout << "The argument of cs2 is: "<< argcs2 << " radians, which is "   
        << argcs2 * 180 / pi << " degrees." << endl << endl;  
  
   // Example of the third member function  
   // type double minus type complex<double>  
   double cl3 = 5.0;  
   complex <double> cr3 ( 3.0 , 4.0 );  
   complex <double> cs3 = cl3 - cr3;  
  
   cout << "The left-side complex number is cl3 = " << cl3 << endl;  
   cout << "The right-side complex number is cr3 = " << cr3 << endl;  
   cout << "Difference of two complex numbers is: cs3 = " << cs3 << endl;  
   double abscs3 = abs ( cs3 );  
   double argcs3 = arg ( cs3 );  
   cout << "The modulus of cs3 is: " << abscs3 << endl;  
   cout << "The argument of cs3 is: "<< argcs3 << " radians, which is "   
        << argcs3 * 180 / pi << " degrees." << endl << endl;   
  
   // Example of the fourth member function  
   // minus type complex<double>  
   complex <double> cr4 ( 3.0 , 4.0 );  
   complex <double> cs4 = - cr4;  
  
   cout << "The right-side complex number is cr4 = " << cr4 << endl;  
   cout << "The result of the unary application of - to the right-side"  
        << "\n complex number is: cs4 = " << cs4 << endl;  
   double abscs4 = abs ( cs4 );  
   double argcs4 = arg ( cs4 );  
   cout << "The modulus of cs4 is: " << abscs4 << endl;  
   cout << "The argument of cs4 is: "<< argcs4 << " radians, which is "   
        << argcs4 * 180 / pi << " degrees." << endl << endl;    
}  
```  
  
 **The left-side complex number is cl1 = (3,4)**  
**The right-side complex number is cr1 = (2,5)**  
**Difference of two complex numbers is: cs1 = (1,-1)**  
**The modulus of cs1 is: 1.41421**  
**The argument of cs1 is: -0.785398 radians, which is -45 degrees.**  
**The left-side complex number is cl2 = (3,4)**  
**The right-side complex number is cr2 = 5**  
**Difference of two complex numbers is: cs2 = (-2,4)**  
**The modulus of cs2 is: 4.47214**  
**The argument of cs2 is: 2.03444 radians, which is 116.565 degrees.**  
**The left-side complex number is cl3 = 5**  
**The right-side complex number is cr3 = (3,4)**  
**Difference of two complex numbers is: cs3 = (2,-4)**  
**The modulus of cs3 is: 4.47214**  
**The argument of cs3 is: -1.10715 radians, which is -63.4349 degrees.**  
**The right-side complex number is cr4 = (3,4)**  
**The result of the unary application of - to the right-side**  
 **complex number is: cs4 = (-3,-4)**  
**The modulus of cs4 is: 5**  
**The argument of cs4 is: -2.2143 radians, which is -126.87 degrees.**   
## Requirements  
 **Header:** <complex\>  
  
 **Namespace:** std