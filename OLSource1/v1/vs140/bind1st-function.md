---
title: "bind1st Function"
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
  - "xfunctional/std::bind1st"
  - "std::bind1st"
  - "std.bind1st"
  - "bind1st"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bind1st function"
  - "bind1st"
ms.assetid: 4fd982e2-3588-47e9-b5a9-84ba4fff1923
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bind1st Function
A helper template function that creates an adaptor to convert a binary function object into a unary function object by binding the first argument of the binary function to a specified value.  
  
## Syntax  
  
```  
  
   template<class   
   Operation  
   , class   
   Type  
   >  
binder1st <Operation> bind1st(  
   const Operation& _Func,   
   const Type& _Left  
);  
```  
  
#### Parameters  
 `_Func`  
 The binary function object to be converted to a unary function object.  
  
 `_Left`  
 The value to which the first argument of the binary function object is to be bound.  
  
## Return Value  
 The unary function object that results from binding the first argument of the binary function object to the value `_Left.`  
  
## Remarks  
 Function binders are a kind of function adaptor and, because they return function objects, can be used in certain types of function composition to construct more complicated and powerful expressions.  
  
 If `_Func` is an object of type `Operation` and `c` is a constant, then `bind1st` (`_Func`, `c`) is equivalent to the [binder1st](../vs140/binder1st-class.md) class constructor `binder1st`<`Operation`> (`_Func`, `c`) and is more convenient.  
  
## Example  
  
```  
// functional_bind1st.cpp  
// compile with: /EHsc  
#include <vector>  
#include <functional>  
#include <algorithm>  
#include <iostream>  
  
using namespace std;  
  
// Creation of a user-defined function object  
// that inherits from the unary_function base class  
class greaterthan5: unary_function<int, bool>  
{  
public:  
    result_type operator()(argument_type i)  
    {  
        return (result_type)(i > 5);  
    }  
};  
  
int main()  
{  
    vector<int> v1;  
    vector<int>::iterator Iter;  
  
    int i;  
    for (i = 0; i <= 5; i++)  
    {  
        v1.push_back(5 * i);  
    }  
  
    cout << "The vector v1 = ( " ;  
    for (Iter = v1.begin(); Iter != v1.end(); Iter++)  
        cout << *Iter << " ";  
    cout << ")" << endl;  
  
    // Count the number of integers > 10 in the vector  
    vector<int>::iterator::difference_type result1a;  
    result1a = count_if(v1.begin(), v1.end(), bind1st(less<int>(), 10));  
    cout << "The number of elements in v1 greater than 10 is: "  
         << result1a << "." << endl;  
  
    // Compare: counting the number of integers > 5 in the vector  
    // with a user defined function object  
    vector<int>::iterator::difference_type result1b;  
    result1b = count_if(v1.begin(), v1.end(), greaterthan5());  
    cout << "The number of elements in v1 greater than 5 is: "  
         << result1b << "." << endl;  
  
    // Count the number of integers < 10 in the vector  
    vector<int>::iterator::difference_type result2;  
    result2 = count_if(v1.begin(), v1.end(), bind2nd(less<int>(), 10));  
    cout << "The number of elements in v1 less than 10 is: "  
         << result2 << "." << endl;  
}  
```  
  
 **The vector v1 = ( 0 5 10 15 20 25 )**  
**The number of elements in v1 greater than 10 is: 3.**  
**The number of elements in v1 greater than 5 is: 4.**  
**The number of elements in v1 less than 10 is: 2.**   
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)