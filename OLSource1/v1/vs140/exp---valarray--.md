---
title: "exp (&lt;valarray&gt;)"
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
  - "valarray/std::exp"
  - "std::exp"
  - "std.exp"
  - "exp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "exp function"
ms.assetid: 8ff5656e-8dba-4fe8-b358-a4d0c25ffe12
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# exp (&lt;valarray&gt;)
Operates on the elements of an input valarray, returning a valarray whose elements are equal to the natural exponential of the elements of the input valarray.  
  
## Syntax  
  
```  
  
   template<class Type>  
valarray<Type> exp(  
   const valarray<Type>& _Left  
);  
```  
  
#### Parameters  
 `_Left`  
 The input valarray whose elements are to be operated on by the member function.  
  
## Return Value  
 A valarray whose elements are equal to the natural exponential of the elements of the input valarray.  
  
## Example  
  
```  
// valarray_exp.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
#include <iomanip>  
  
int main( )  
{  
   using namespace std;  
   int i;  
  
   valarray<double> va1 ( 9 );  
   for ( i = 0 ; i < 9 ; i++ )   
      va1 [ i ] =  10 * ( 0.25 * i - 1 );  
   valarray<double> va2 ( 9 );  
  
   cout << "Initial valarray:";  
   for ( i = 0 ; i < 9 ; i++ )  
      cout << " " << va1 [ i ];  
   cout << endl;  
  
   va2 = exp ( va1 );  
   cout << "The natural exponential of the initial valarray is:\n";  
   for ( i = 0 ; i < 9 ; i++ )  
      cout << va2 [ i ] << endl;  
}  
```  
  
 **Initial valarray: -10 -7.5 -5 -2.5 0 2.5 5 7.5 10**  
**The natural exponential of the initial valarray is:**  
**4.53999e-005**  
**0.000553084**  
**0.00673795**  
**0.082085**  
**1**  
**12.1825**  
**148.413**  
**1808.04**  
**22026.5**   
## Requirements  
 **Header:** \<valarray>  
  
 **Namespace:** std  
  
## See Also  
 [exp, log, and log10](../vs140/exp--log--and-log10.md)