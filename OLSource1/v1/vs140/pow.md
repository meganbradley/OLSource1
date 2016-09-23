---
title: "pow"
ms.custom: na
ms.date: 09/21/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - std.pow
  - std::pow
  - pow
dev_langs: 
  - C++
helpviewer_keywords: 
  - pow function
ms.assetid: 973fc346-96d7-4b98-a931-6cdb3e40130b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# pow
Evaluates the complex number obtained by raising a base that is a complex number to the power of another complex number.  
  
## Syntax  
  
```  
  
      template<class Type>  
   complex<Type> pow(  
      const complex<Type>& _Base,   
      int _Power  
   );  
template<class Type>  
   complex<Type> pow(  
      const complex<Type>& _Base,  
      const Type& _Power  
   );  
template<class Type>  
   complex<Type> pow(  
      const complex<Type>& _Base,  
      const complex<Type>& _Power  
   );  
template<class Type>  
   complex<Type> pow(  
      const Type& _Base,  
      const complex<Type>& _Power  
   );  
```  
  
#### Parameters  
 `_Base`  
 The complex number or number that is of the parameter type for the complex number that is the base to be raised to a power by the member function.  
  
 *_Power*  
 The integer or complex number or number that is of the parameter type for the complex number that is the power that the base is to be raised to by the member function.  
  
## Return Value  
 The complex number obtained by raising the specified base to the specified power.  
  
## Remarks  
 The functions each effectively convert both operands to the return type, and then return the converted **left** to the power **right**.  
  
 The branch cut is along the negative real axis.  
  
## Example  
  
```  
// complex_pow.cpp  
// compile with: /EHsc  
#include <complex>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   double pi = 3.14159265359;  
  
   // First member function  
   // type complex<double> base & type integer power  
   complex <double> cb1 ( 3 , 4);  
   int cp1 = 2;  
   complex <double> ce1 = pow ( cb1 ,cp1 );  
  
   cout << "Complex number for base cb1 = " << cb1 << endl;  
   cout << "Integer for power = " << cp1 << endl;  
   cout << "Complex number returned from complex base and integer power:"  
        << "\n ce1 = cb1 ^ cp1 = " << ce1 << endl;  
   double absce1 = abs ( ce1 );  
   double argce1 = arg ( ce1 );  
   cout << "The modulus of ce1 is: " << absce1 << endl;  
   cout << "The argument of ce1 is: "<< argce1 << " radians, which is "   
        << argce1 * 180 / pi << " degrees." << endl << endl;   
  
   // Second member function  
   // type complex<double> base & type double power  
   complex <double> cb2 ( 3 , 4 );  
   double cp2 = pi;  
   complex <double> ce2 = pow ( cb2 ,cp2 );  
  
   cout << "Complex number for base cb2 = " << cb2 << endl;  
   cout << "Type double for power cp2 = pi = " << cp2 << endl;  
   cout << "Complex number returned from complex base and double power:"  
        << "\n ce2 = cb2 ^ cp2 = " << ce2 << endl;  
   double absce2 = abs ( ce2 );  
   double argce2 = arg ( ce2 );  
   cout << "The modulus of ce2 is: " << absce2 << endl;  
   cout << "The argument of ce2 is: "<< argce2 << " radians, which is "   
        << argce2 * 180 / pi << " degrees." << endl << endl;  
  
   // Third member function  
   // type complex<double> base & type complex<double> power  
   complex <double> cb3 ( 3 , 4 );  
   complex <double> cp3 ( -2 , 1 );  
   complex <double> ce3 = pow ( cb3 ,cp3 );  
  
   cout << "Complex number for base cb3 = " << cb3 << endl;  
   cout << "Complex number for power cp3= " << cp3 << endl;  
   cout << "Complex number returned from complex base and complex power:"  
        << "\n ce3 = cb3 ^ cp3 = " << ce3 << endl;  
   double absce3 = abs ( ce3 );  
   double argce3 = arg ( ce3 );  
   cout << "The modulus of ce3 is: " << absce3 << endl;  
   cout << "The argument of ce3 is: "<< argce3 << " radians, which is "   
        << argce3 * 180 / pi << " degrees." << endl << endl;   
  
   // Fourth member function  
   // type double base & type complex<double> power  
   double cb4 = pi;  
   complex <double> cp4 ( 2 , -1 );  
   complex <double> ce4 = pow ( cb4 ,cp4 );  
  
   cout << "Type double for base cb4 = pi = " << cb4 << endl;  
   cout << "Complex number for power cp4 = " << cp4 << endl;  
   cout << "Complex number returned from double base and complex power:"  
        << "\n ce4 = cb4 ^ cp4 = " << ce4 << endl;  
   double absce4 = abs ( ce4 );  
   double argce4 = arg ( ce4 );  
   cout << "The modulus of ce4 is: " << absce4 << endl;  
   cout << "The argument of ce4 is: "<< argce4 << " radians, which is "   
        << argce4 * 180 / pi << " degrees." << endl << endl;   
}  
```  
  
 **Complex number for base cb1 = (3,4)**  
**Integer for power = 2**  
**Complex number returned from complex base and integer power:**  
 **ce1 = cb1 ^ cp1 = (-7,24)**  
**The modulus of ce1 is: 25**  
**The argument of ce1 is: 1.85459 radians, which is 106.26 degrees.**  
**Complex number for base cb2 = (3,4)**  
**Type double for power cp2 = pi = 3.14159**  
**Complex number returned from complex base and double power:**  
 **ce2 = cb2 ^ cp2 = (-152.915,35.5475)**  
**The modulus of ce2 is: 156.993**  
**The argument of ce2 is: 2.91318 radians, which is 166.913 degrees.**  
**Complex number for base cb3 = (3,4)**  
**Complex number for power cp3= (-2,1)**  
**Complex number returned from complex base and complex power:**  
 **ce3 = cb3 ^ cp3 = (0.0153517,-0.00384077)**  
**The modulus of ce3 is: 0.0158249**  
**The argument of ce3 is: -0.245153 radians, which is -14.0462 degrees.**  
**Type double for base cb4 = pi = 3.14159**  
**Complex number for power cp4 = (2,-1)**  
**Complex number returned from double base and complex power:**  
 **ce4 = cb4 ^ cp4 = (4.07903,-8.98725)**  
**The modulus of ce4 is: 9.8696**  
**The argument of ce4 is: -1.14473 radians, which is -65.5882 degrees.**   
## Requirements  
 **Header:** <complex\>  
  
 **Namespace:** std