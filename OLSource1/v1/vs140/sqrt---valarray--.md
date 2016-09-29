---
title: "sqrt (&lt;valarray&gt;)"
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
  - "sqrt"
  - "valarray/std::sqrt"
  - "std::sqrt"
  - "std.sqrt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sqrt (<valarray>)"
ms.assetid: dacd615e-5137-4c92-8d35-4479d1e92904
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sqrt (&lt;valarray&gt;)
Operates on the elements of an input valarray, returning a valarray whose elements are equal to the square root of the elements of the input valarray.  
  
## Syntax  
  
```  
  
   template<class Type>  
valarray<Type> sqrt(  
   const valarray<Type>& _Left  
);  
```  
  
#### Parameters  
 `_Left`  
 The input valarray whose elements are to be operated on by the member function.  
  
## Return Value  
 A valarray whose elements are equal to the square root of the elements of the input valarray.  
  
## Example  
  
```  
// valarray_sqrt.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
#include <cmath>  
  
int main( )  
{  
   using namespace std;  
   int i;  
  
   valarray<double> va1 ( 6 );  
   for ( i = 0 ; i < 5 ; i++ )  
      va1 [ i ] = i * i;  
  
   cout << "The initial valarray is: ( ";  
      for ( i = 0 ; i < 5 ; i++ )  
         cout << va1 [ i ] << " ";  
   cout << ")." << endl;  
  
   valarray<double> va2 = sqrt ( va1 );  
   cout << "The square root of the initial valarray is: ( ";  
      for ( i = 0 ; i < 5 ; i++ )  
         cout << va2 [ i ] << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The initial valarray is: ( 0 1 4 9 16 ).**  
**The square root of the initial valarray is: ( 0 1 2 3 4 ).**   
## Requirements  
 **Header:** <valarray\>  
  
 **Namespace:** std  
  
## See Also  
 [sqrt and pow](../vs140/sqrt-and-pow.md)