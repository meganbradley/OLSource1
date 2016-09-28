---
title: "valarray::apply"
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
  - "std::valarray::apply"
  - "valarray.apply"
  - "std.valarray.apply"
  - "valarray::apply"
  - "apply"
  - "valarray/std::valarray::apply"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "apply method"
ms.assetid: de0fa123-8cd7-4d7d-be1c-0fda959d25a3
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# valarray::apply
Applies a specified function to each element of a valarray.  
  
## Syntax  
  
```  
  
      valarray<Type> apply(  
   Type _Func(Type)  
) const;  
valarray<Type> apply(  
   Type _Func(const Type&)  
) const;  
```  
  
#### Parameters  
 *_Func(Type)*  
 The function object to be applied to each element of the operand valarray.  
  
 *_Func(const Type&)*  
 The function object for const to be applied to each element of the operand valarray.  
  
## Return Value  
 A valarray whose elements have had `_Func` applied element-wise to the elements of the operand valarray.  
  
## Remarks  
 The member function returns an object of class [valarray](../vs140/valarray-class.md)**<Type\>**, of length [size](../vs140/valarray--size.md), each of whose elements `I` is **func**((**\*this**)[`I`]).  
  
## Example  
  
```  
// valarray_apply.cpp  
// compile with: /EHsc  
#include <valarray>  
#include <iostream>  
  
using namespace std;  
  
int __cdecl MyApplyFunc( int n )  
{  
   return n*2;  
}  
  
int main( int argc, char* argv[] )  
{  
   valarray<int> vaR(10), vaApplied(10);  
   int i;  
  
   for ( i = 0; i < 10; i += 3 )  
      vaR[i] = i;  
  
   for ( i = 1; i < 10; i += 3 )  
      vaR[i] = 0;  
  
   for ( i = 2; i < 10; i += 3 )  
      vaR[i] = -i;  
  
   cout << "The initial Right valarray is: (";  
   for   ( i=0; i < 10; ++i )  
      cout << " " << vaR[i];  
   cout << " )" << endl;  
  
   vaApplied = vaR.apply( MyApplyFunc );  
  
   cout << "The element-by-element result of "  
       << "applying MyApplyFunc to vaR is the\nvalarray: ( ";  
   for ( i = 0; i < 10; ++i )  
      cout << " " << vaApplied[i];  
   cout << " )" << endl;  
}  
```  
  
 **The initial Right valarray is: ( 0 0 -2 3 0 -5 6 0 -8 9 )**  
**The element-by-element result of applying MyApplyFunc to vaR is the**  
**valarray: (  0 0 -4 6 0 -10 12 0 -16 18 )**   
## Requirements  
 **Header:** <valarray\>  
  
 **Namespace:** std  
  
## See Also  
 [valarray Class](../vs140/valarray-class.md)