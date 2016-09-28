---
title: "valarray::value_type"
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
  - "std::valarray::value_type"
  - "std.valarray.value_type"
  - "valarray.value_type"
  - "valarray::value_type"
  - "valarray/std::valarray::value_type"
  - "value_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_type typedef"
ms.assetid: 60436647-a39e-4172-9fb2-9a521e507ef1
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# valarray::value_type
A type that represents the type of element stored in a valarray.  
  
## Syntax  
  
```  
  
typedef Type value  
_  
type;  
  
```  
  
## Remarks  
 The type is a synonym for the template parameter **Type**.  
  
## Example  
  
```  
// valarray_value_type.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
  
int main( )  
{  
   using namespace std;  
   int i;  
   valarray<int> va ( 10 );  
   for ( i = 0 ; i < 10 ; i += 2 )  
      va [ i ] =  i;  
   for ( i = 1 ; i < 10 ; i += 2 )  
      va [ i ] =  -1;  
  
   cout << "The initial operand valarray is:  ( ";  
      for ( i = 0 ; i < 10 ; i++ )  
         cout << va [ i ] << " ";  
   cout << ")." << endl;  
  
   // value_type declaration and initialization:  
   valarray<int>::value_type Right = 10;  
  
   cout << "The decalared value_type Right is: "   
           << Right << endl;  
   va *= Right;  
   cout << "The resulting valarray is:  ( ";  
      for ( i = 0 ; i < 10 ; i++ )  
         cout << va [ i ] << " ";  
   cout << ")." << endl;  
}  
```  
  
 **The initial operand valarray is:  ( 0 -1 2 -1 4 -1 6 -1 8 -1 ).**  
**The decalared value_type Right is: 10**  
**The resulting valarray is:  ( 0 -10 20 -10 40 -10 60 -10 80 -10 ).**   
## Requirements  
 **Header:** <valarray\>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)