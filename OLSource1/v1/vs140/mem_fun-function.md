---
title: "mem_fun Function"
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
  - "std::mem_fun"
  - "mem_fun"
  - "std.mem_fun"
  - "xfunctional/std::mem_fun"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "mem_fun"
  - "mem_fun function"
ms.assetid: a4c82726-ab74-4265-845b-229004e63e9d
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# mem_fun Function
Helper template functions used to construct function object adaptors for member functions when initialized with pointer arguments.  
  
## Syntax  
  
```  
  
      template<class Result, class Type>  
   mem_fun_t<Result, Type> mem_fun (  
      Result(Type::* _Pm )( )   
);  
  
template<class Result, class Type, class Arg>  
   mem_fun1_t<Result, Type, Arg> mem_fun(  
      Result (Type::* _Pm )( Arg )   
);  
  
template<class Result, class Type>  
   const_mem_fun_t<Result, Type>  
      mem_fun(Result (Type::* _Pm )( ) const   
);  
  
template<class Result, class Type, class Arg>  
   const_mem_fun1_t<Result, Type, Arg>  
      mem_fun(Result (Type::* _Pm )( Arg ) const   
);  
```  
  
#### Parameters  
 `_Pm`  
 A pointer to the member function of class **Type** to be converted to a function object.  
  
## Return Value  
 A **const** or **non_const** function object of type `mem_fun_t` or `mem_fun1_t`.  
  
## Example  
  
```  
// functional_mem_fun.cpp  
// compile with: /EHsc  
#include <vector>  
#include <functional>  
#include <algorithm>  
#include <iostream>  
  
using namespace std;  
  
class StoreVals     
{  
    int val;  
public:  
    StoreVals() { val = 0; }  
    StoreVals(int j) { val = j; }  
  
    bool display() { cout << val << " "; return true; }  
    int squareval() { val *= val; return val; }  
    int lessconst(int k) {val -= k; return val; }  
};  
  
int main( )  
{  
    vector<StoreVals *> v1;  
  
    StoreVals sv1(5);  
    v1.push_back(&sv1);  
    StoreVals sv2(10);  
    v1.push_back(&sv2);  
    StoreVals sv3(15);  
    v1.push_back(&sv3);  
    StoreVals sv4(20);  
    v1.push_back(&sv4);  
    StoreVals sv5(25);  
    v1.push_back(&sv5);  
  
    cout << "The original values stored are: " ;  
    for_each(v1.begin(), v1.end(), mem_fun<bool, StoreVals>(&StoreVals::display));  
    cout << endl;  
  
    // Use of mem_fun calling member function through a pointer  
    // square each value in the vector using squareval ()  
    for_each(v1.begin(), v1.end(), mem_fun<int, StoreVals>(&StoreVals::squareval));     
    cout << "The squared values are: " ;  
    for_each(v1.begin(), v1.end(), mem_fun<bool, StoreVals>(&StoreVals::display));  
    cout << endl;  
  
    // Use of mem_fun1 calling member function through a pointer  
    // subtract 5 from each value in the vector using lessconst ()  
    for_each(v1.begin(), v1.end(),   
        bind2nd (mem_fun1<int, StoreVals,int>(&StoreVals::lessconst), 5));     
    cout << "The squared values less 5 are: " ;  
    for_each(v1.begin(), v1.end(), mem_fun<bool, StoreVals>(&StoreVals::display));  
    cout << endl;  
}  
```  
  
## Output  
  
```  
The original values stored are: 5 10 15 20 25   
The squared values are: 25 100 225 400 625   
The squared values less 5 are: 20 95 220 395 620   
```  
  
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)