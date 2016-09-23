---
title: "complex::value_type"
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
  - std.complex.value_type
  - std::complex::value_type
  - complex::value_type
  - complex.value_type
  - value_type
dev_langs: 
  - C++
helpviewer_keywords: 
  - value_type typedef
ms.assetid: 09ee6f70-5d7e-400e-9403-c8a53e827dd2
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# complex::value_type
A type that represents the data type used to represent the real and imaginary parts of a complex number.  
  
## Syntax  
  
```  
  
typedef Type value_type;  
  
```  
  
## Remarks  
 `value_type` is a synonym for the class complex **Type** template parameter.  
  
## Example  
  
```  
// complex_valuetype.cpp  
// compile with: /EHsc  
#include <complex>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   complex <double>::value_type a = 3, b = 4;  
  
   complex <double> c1 ( a , b );  
   cout << "Specifying initial real & imaginary parts"  
      << "\nof type value_type: "  
      << "c1 = " << c1 << "." << endl;  
}  
```  
  
 **Specifying initial real & imaginary parts**  
**of type value_type: c1 = (3,4).**   
## Requirements  
 **Header:** <complex\>  
  
 **Namespace:** std  
  
## See Also  
 [complex Class](../vs140/complex-class.md)