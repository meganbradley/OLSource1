---
title: "operator== (&lt;complex&gt;)"
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
  - "std.=="
  - "std::=="
  - "operator=="
  - "std.operator=="
  - "std::operator=="
  - "=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator==, complex numbers"
  - "operator ==, complex numbers"
  - "== operator, with specific standard C++ objects"
ms.assetid: 4bc38a57-89dc-4b0c-b3bc-32e5d3aff515
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# operator== (&lt;complex&gt;)
Tests for equality between two complex numbers, one or both of which may belong to the subset of the type for the real and imaginary parts.  
  
## Syntax  
  
```  
  
      template<class Type>  
   bool operator==(  
      const complex<Type>& _Left,  
      const complex<Type>& _Right  
   );  
template<class Type>  
   bool operator==(  
      const complex<Type>& _Left,  
      const Type& _Right  
   );  
template<class Type>  
   bool operator==(  
      const Type& _Left,  
      const complex<Type>& _Right  
   );  
```  
  
#### Parameters  
 `_Left`  
 A complex number or object of its parameter type to be tested for inequality.  
  
 `_Right`  
 A complex number or object of its parameter type to be tested for inequality.  
  
## Return Value  
 **true** if the numbers are equal; **false** if numbers are not equal.  
  
## Remarks  
 Two complex numbers are equal if and only if their real parts are equal and their imaginary parts are equal. Otherwise, they are unequal.  
  
 The operation is overloaded so that comparison tests can be executed without the conversion of the data to a particular format.  
  
## Example  
  
```  
// complex_op_EQ.cpp  
// compile with: /EHsc  
#include <complex>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   double pi = 3.14159265359;  
  
   // Example of the first member function  
   // type complex<double> compared with type complex<double>  
   complex <double> cl1 ( polar ( 3.0 , pi / 6 ) );  
   complex <double> cr1a ( polar ( 3.0 , pi /6 ) );  
   complex <double> cr1b ( polar ( 2.0 , pi / 3 ) );  
  
   cout << "The left-side complex number is cl1 = " << cl1 << endl;  
   cout << "The 1st right-side complex number is cr1a = " << cr1a << endl;  
   cout << "The 2nd right-side complex number is cr1b = " << cr1b << endl;  
   if ( cl1 == cr1a )  
      cout << "The complex numbers cl1 & cr1a are equal." << endl;  
   else  
      cout << "The complex numbers cl1 & cr1a are not equal." << endl;  
   if ( cl1 == cr1b )  
      cout << "The complex numbers cl1 & cr1b are equal." << endl;  
   else  
      cout << "The complex numbers cl1 & cr1b are not equal." << endl;  
   cout << endl;  
  
   // Example of the second member function  
   // type complex<int> compared with type int  
   complex <int> cl2a ( 3 , 4 );  
   complex <int> cl2b ( 5 ,0 );  
   int cr2a =3;  
   int cr2b =5;  
  
   cout << "The 1st left-side complex number is cl2a = " << cl2a << endl;  
   cout << "The 1st right-side complex number is cr2a = " << cr2a << endl;  
   if ( cl2a == cr2a )  
      cout << "The complex numbers cl2a & cr2a are equal." << endl;  
   else  
      cout << "The complex numbers cl2a & cr2a are not equal." << endl;  
  
   cout << "The 2nd left-side complex number is cl2b = " << cl2b << endl;  
   cout << "The 2nd right-side complex number is cr2b = " << cr2b << endl;  
   if ( cl2b == cr2b )  
      cout << "The complex numbers cl2b & cr2b are equal." << endl;  
   else  
      cout << "The complex numbers cl2b & cr2b are not equal." << endl;  
   cout << endl;  
  
   // Example of the third member function  
   // type double compared with type complex<double>  
   double cl3a =3;  
   double cl3b =5;  
   complex <double> cr3a (3 , 4 );  
   complex <double> cr3b (5 ,0 );  
  
   cout << "The 1st left-side complex number is cl3a = " << cl3a << endl;  
   cout << "The 1st right-side complex number is cr3a = " << cr3a << endl;  
   if ( cl3a == cr3a )  
      cout << "The complex numbers cl3a & cr3a are equal." << endl;  
   else  
      cout << "The complex numbers cl3a & cr3a are not equal." << endl;  
  
   cout << "The 2nd left-side complex number is cl3b = " << cl3b << endl;  
   cout << "The 2nd right-side complex number is cr3b = " << cr3b << endl;  
   if ( cl3b == cr3b )  
      cout << "The complex numbers cl3b & cr3b are equal." << endl;  
   else  
      cout << "The complex numbers cl3b & cr3b are not equal." << endl;  
   cout << endl;  
}  
```  
  
 **The left-side complex number is cl1 = (2.59808,1.5)**  
**The 1st right-side complex number is cr1a = (2.59808,1.5)**  
**The 2nd right-side complex number is cr1b = (1,1.73205)**  
**The complex numbers cl1 & cr1a are equal.**  
**The complex numbers cl1 & cr1b are not equal.**  
**The 1st left-side complex number is cl2a = (3,4)**  
**The 1st right-side complex number is cr2a = 3**  
**The complex numbers cl2a & cr2a are not equal.**  
**The 2nd left-side complex number is cl2b = (5,0)**  
**The 2nd right-side complex number is cr2b = 5**  
**The complex numbers cl2b & cr2b are equal.**  
**The 1st left-side complex number is cl3a = 3**  
**The 1st right-side complex number is cr3a = (3,4)**  
**The complex numbers cl3a & cr3a are not equal.**  
**The 2nd left-side complex number is cl3b = 5**  
**The 2nd right-side complex number is cr3b = (5,0)**  
**The complex numbers cl3b & cr3b are equal.**   
## Requirements  
 **Header:** <complex\>  
  
 **Namespace:** std