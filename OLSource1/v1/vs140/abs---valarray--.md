---
title: "abs (&lt;valarray&gt;)"
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
  - "std::abs"
  - "std.abs"
  - "abs"
  - "valarray/std::abs"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "abs function"
ms.assetid: fbfe3b5a-9637-460d-a261-8423bb892519
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# abs (&lt;valarray&gt;)
Operates on the elements of an input valarray, returning a valarray whose elements are equal to the absolute value of the elements of the input valarray.  
  
## Syntax  
  
```  
  
   template<class Type>  
valarray<Type> abs(  
   const valarray<Type>& _Left  
);  
```  
  
#### Parameters  
 `_Left`  
 The input valarray whose elements are to be operated on by the member function.  
  
## Return Value  
 A valarray whose elements are equal to the absolute value of the elements of the input valarray.  
  
## Example  
  
```  
// valarray_abs.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
  
   valarray<int> va1 ( 9 ), va2 ( 9 );  
   for ( i = 0 ; i < 4 ; i++ )  
      va1 [ i ] =  -i;  
   for ( i = 4 ; i < 9 ; i++ )  
      va1 [ i ] =  i;  
  
   cout << "The initial valarray is: ";  
      for (i = 0 ; i < 9 ; i++ )  
         cout << va1 [ i ] << " ";  
   cout << "." << endl;  
  
   va2 = abs ( va1 );  
   cout << "The absolute value of the initial valarray is: ";  
      for (i = 0 ; i < 9 ; i++ )  
         cout << va2 [ i ] << " ";  
   cout << "." << endl;  
}  
```  
  
 **The initial valarray is: 0 -1 -2 -3 4 5 6 7 8 .**  
**The absolute value of the initial valarray is: 0 1 2 3 4 5 6 7 8 .**   
## Requirements  
 **Header:** <valarray\>  
  
 **Namespace:** std  
  
## See Also  
 [abs](../vs140/abs--stl-samples-.md)