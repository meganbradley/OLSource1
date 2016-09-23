---
title: "mem_fun_ref Function"
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
  - std.mem_fun_ref
  - xfunctional/std::mem_fun_ref
  - std::mem_fun_ref
  - mem_fun_ref
dev_langs: 
  - C++
helpviewer_keywords: 
  - mem_fun_ref
  - mem_fun_ref function
ms.assetid: 1fb77eb2-5bd4-4818-ac8a-21b73085f2c1
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# mem_fun_ref Function
Helper template functions used to construct function object adaptors for member functions when initialized by using reference arguments.  
  
## Syntax  
  
```  
  
      template<class Result, class Type>  
   mem_fun_ref_t<Result, Type> mem_fun_ref(  
      Result (Type::*_Pm )( )   
   );  
template<class Result, class Type, class Arg>  
   mem_fun1_ref_t<Result, Type, Arg>   
      mem_fun_ref(  
         Result (Type::*_Pm )( Arg )   
      );  
template<class Result, class Type>  
   const_mem_fun_ref_t<Result, Type>   
      mem_fun_ref(  
         Result Type::*_Pm )( ) const   
      );  
template<class Result, class Type, class Arg>  
   const_mem_fun1_ref_t<Result, Type, Arg>   
      mem_fun_ref(  
         Result ( _Type::*_Pm )( Arg ) const   
      );  
```  
  
#### Parameters  
 `_Pm`  
 A pointer to the member function of class `Type` to be converted to a function object.  
  
## Return Value  
 A `const` or `non_const` function object of type`mem_fun_ref_t` or `mem_fun1_ref_t`.  
  
## Example  
  
```  
// functional_mem_fun_ref.cpp  
// compile with: /EHsc  
#include <vector>  
#include <functional>  
#include <algorithm>  
#include <iostream>  
  
using namespace std;  
  
class NumVals  
   {  
   int val;  
   public:  
   NumVals ( ) { val = 0; }  
   NumVals ( int j ) { val = j; }  
  
   bool display ( ) { cout << val << " "; return true; }  
   bool isEven ( ) { return ( bool )  !( val %2 ); }  
   bool isPrime( )  
   {  
      if (val < 2) { return true; }  
      for (int i = 2; i <= val / i; ++i)  
      {  
         if (val % i == 0) { return false; }  
      }  
      return true;  
   }  
};  
  
int main( )  
{  
   vector <NumVals> v1 ( 13 ), v2 ( 13 );  
   vector <NumVals>::iterator v1_Iter, v2_Iter;  
   int i, k;  
  
   for ( i = 0; i < 13; i++ ) v1 [ i ] = NumVals ( i+1 );  
   for ( k = 0; k < 13; k++ ) v2 [ k ] = NumVals ( k+1 );  
  
   cout << "The original values stored in v1 are: " ;  
   for_each( v1.begin( ), v1.end( ),   
   mem_fun_ref ( &NumVals::display ) );  
   cout << endl;  
  
   // Use of mem_fun_ref calling member function through a reference  
   // remove the primes in the vector using isPrime ( )  
   v1_Iter = remove_if ( v1.begin( ),  v1.end( ),   
      mem_fun_ref ( &NumVals::isPrime ) );     
   cout << "With the primes removed, the remaining values in v1 are: " ;  
   for_each( v1.begin( ), v1_Iter,   
   mem_fun_ref ( &NumVals::display ) );  
   cout << endl;  
  
   cout << "The original values stored in v2 are: " ;  
   for_each( v2.begin( ), v2.end( ),   
   mem_fun_ref ( &NumVals::display ) );  
   cout << endl;  
  
   // Use of mem_fun_ref calling member function through a reference  
   // remove the even numbers in the vector v2 using isEven ( )  
   v2_Iter = remove_if ( v2.begin( ),  v2.end( ),   
      mem_fun_ref ( &NumVals::isEven ) );     
   cout << "With the even numbers removed, the remaining values are: " ;  
   for_each( v2.begin( ),  v2_Iter,   
   mem_fun_ref ( &NumVals::display ) );  
   cout << endl;  
}  
```  
  
 **The original values stored in v1 are: 1 2 3 4 5 6 7 8 9 10 11 12 13**   
**With the primes removed, the remaining values in v1 are: 4 6 8 9 10 12**   
**The original values stored in v2 are: 1 2 3 4 5 6 7 8 9 10 11 12 13**   
**With the even numbers removed, the remaining values are: 1 3 5 7 9 11 13**    
## Requirements  
 **Header:** <functional\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)