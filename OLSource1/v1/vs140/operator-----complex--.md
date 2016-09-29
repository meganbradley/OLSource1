---
title: "operator&gt;&gt; (&lt;complex&gt;)"
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
  - "std::operator>>"
  - "std::>>"
  - "std.>>"
  - ">>"
  - "std.operator>>"
  - "operator>>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator >>, complex numbers"
  - "operator>>"
  - "operator>>, complex numbers"
  - ">> operator, complex numbers"
ms.assetid: 6c883415-56dd-43ee-b151-a43ef393ecd0
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&gt;&gt; (&lt;complex&gt;)
Extracts a complex value from the input stream.  
  
## Syntax  
  
```  
  
   template<class Type, class Elem, class Traits>  
basic_istream<Elem, Traits>&  
   operator>>(  
      basic_istream<Elem, Traits>& _Istr,  
      complex<Type>& _Right  
   );  
```  
  
#### Parameters  
 `_Istr`  
 The input stream from which the complex number is being extracted.  
  
 `_Right`  
 The complex number that is being extracted from the input stream.  
  
## Return Value  
 Reads the value of the specified complex number from `_Istr` and returns it into `_Right.`  
  
## Remarks  
 The valid input formats are  
  
-   *( real part, imaginary part )*  
  
-   *( real part )*  
  
-   *real part*  
  
## Example  
  
```  
// complex_op_extract.cpp  
// compile with: /EHsc  
#include <complex>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   double pi = 3.14159265359;  
  
   complex <double> c2;  
  
   cout << "Input a complex number ( try: 2.0 ): ";  
   cin >> c2;  
   cout << c2 << endl;  
}  
```  
  
  **`2.0`**    
## Requirements  
 **Header:** \<complex>  
  
 **Namespace:** std