---
title: "arg"
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
  - "std::arg"
  - "arg"
  - "std.arg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "arg function"
ms.assetid: 6e9a74e9-e83f-4788-99e3-e4dacd8aff40
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# arg
Extracts the argument from a complex number.  
  
## Syntax  
  
```  
  
   template<class Type>  
Type arg(  
   const complex<Type>& _ComplexNum  
);  
```  
  
#### Parameters  
 `_ComplexNum`  
 The complex number whose argument is to be determined.  
  
## Return Value  
 The argument of the complex number.  
  
## Remarks  
 The argument is the angle that the complex vector makes with the positive real axis in the complex plane. For a complex number *a + bi*, the argument is equal to arctan(*b/a*)*.* The angle has a positive sense when measured in a counterclockwise direction from the positive real axis and a negative sense when measured in a clockwise direction. The principal values are greater than –pi and less than or equal to +pi.  
  
## Example  
  
```  
// complex_arg.cpp  
// compile with: /EHsc  
#include <complex>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   double pi = 3.14159265359;  
  
   // Complex numbers can be entered in polar form with  
   // modulus and argument parameter inputs but are  
   // stored in Cartesian form as real & imag coordinates  
   complex <double> c1 ( polar ( 5.0 ) );   // Default argument = 0  
   complex <double> c2 ( polar ( 5.0 , pi / 6 ) );  
   complex <double> c3 ( polar ( 5.0 , 13 * pi / 6 ) );  
   cout << "c1 = polar ( 5.0 ) = " << c1 << endl;  
   cout << "c2 = polar ( 5.0 , pi / 6 ) = " << c2 << endl;  
   cout << "c3 = polar ( 5.0 , 13 * pi / 6 ) = " << c3 << endl;  
  
   // The modulus and argument of a complex number can be rcovered  
   // using abs & arg member functions  
   double absc1 = abs ( c1 );  
   double argc1 = arg ( c1 );  
   cout << "The modulus of c1 is recovered from c1 using: abs ( c1 ) = "  
        << absc1 << endl;  
   cout << "Argument of c1 is recovered from c1 using:\n arg ( c1 ) = "  
        << argc1 << " radians, which is " << argc1 * 180 / pi  
        << " degrees." << endl;  
  
   double absc2 = abs ( c2 );  
   double argc2 = arg ( c2 );  
   cout << "The modulus of c2 is recovered from c2 using: abs ( c2 ) = "  
        << absc2 << endl;  
   cout << "Argument of c2 is recovered from c2 using:\n arg ( c2 ) = "  
        << argc2 << " radians, which is " << argc2 * 180 / pi  
        << " degrees." << endl;  
  
   // Testing if the principal angles of c2 and c3 are the same  
   if ( (arg ( c2 ) <= ( arg ( c3 ) + .00000001) ) ||   
        (arg ( c2 ) >= ( arg ( c3 ) - .00000001) ) )  
      cout << "The complex numbers c2 & c3 have the "  
           << "same principal arguments."<< endl;  
   else  
      cout << "The complex numbers c2 & c3 don't have the "  
           << "same principal arguments." << endl;  
}  
```  
  
 **c1 = polar ( 5.0 ) = (5,0)**  
**c2 = polar ( 5.0 , pi / 6 ) = (4.33013,2.5)**  
**c3 = polar ( 5.0 , 13 \* pi / 6 ) = (4.33013,2.5)**  
**The modulus of c1 is recovered from c1 using: abs ( c1 ) = 5**  
**Argument of c1 is recovered from c1 using:**  
 **arg ( c1 ) = 0 radians, which is 0 degrees.**  
**The modulus of c2 is recovered from c2 using: abs ( c2 ) = 5**  
**Argument of c2 is recovered from c2 using:**  
 **arg ( c2 ) = 0.523599 radians, which is 30 degrees.**  
**The complex numbers c2 & c3 have the same principal arguments.**   
## Requirements  
 **Header:** \<complex>  
  
 **Namespace:** std