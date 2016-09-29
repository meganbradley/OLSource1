---
title: "bind2nd Function"
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
  - "std::bind2nd"
  - "xfunctional/std::bind2nd"
  - "bind2nd"
  - "std.bind2nd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bind2nd"
  - "bind2nd function"
ms.assetid: 84c7bf43-1ec9-4fb3-99c9-5f04debdfc2a
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bind2nd Function
A helper template function that creates an adaptor to convert a binary function object into a unary function object by binding the second argument of the binary function to a specified value.  
  
## Syntax  
  
```  
  
   template<class Operation, class Type>  
binder2nd <Operation> bind2nd(  
   const Operation& _Func,   
   const Type& _Right  
);  
```  
  
#### Parameters  
 `_Func`  
 The binary function object to be converted to a unary function object.  
  
 `_Right`  
 The value to which the second argument of the binary function object is to be bound.  
  
## Return Value  
 The unary function object that results from binding the second argument of the binary function object to the value `_Right.`  
  
## Remarks  
 Function binders are a kind of function adaptor and, because they return function objects, can be used in certain types of function composition to construct more complicated and powerful expressions.  
  
 If `_Func` is an object of type **Operation** and `c` is a constant, then `bind2nd` ( `_Func`, `c` ) is equivalent to the [binder2nd](../vs140/binder2nd-class.md) class constructor **binder2nd\<Operation>** ( `_Func`, `c` ) and more convenient.  
  
## Example  
  
```  
// functional_bind2nd.cpp  
// compile with: /EHsc  
#include <vector>  
#include <functional>  
#include <algorithm>  
#include <iostream>  
  
using namespace std;  
  
// Creation of a user-defined function object  
// that inherits from the unary_function base class  
class greaterthan15: unary_function<int, bool>  
{  
public:  
    result_type operator()(argument_type i)  
    {  
        return (result_type)(i > 15);  
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
  
    cout << "The vector v1 = ( ";  
    for (Iter = v1.begin(); Iter != v1.end(); Iter++)  
        cout << *Iter << " ";  
    cout << ")" << endl;  
  
    // Count the number of integers > 10 in the vector  
    vector<int>::iterator::difference_type result1a;  
    result1a = count_if(v1.begin(), v1.end(), bind2nd(greater<int>(), 10));  
    cout << "The number of elements in v1 greater than 10 is: "  
         << result1a << "." << endl;  
  
    // Compare counting the number of integers > 15 in the vector  
    // with a user-defined function object  
    vector<int>::iterator::difference_type result1b;  
    result1b = count_if(v1.begin(), v1.end(), greaterthan15());  
    cout << "The number of elements in v1 greater than 15 is: "  
         << result1b << "." << endl;  
  
    // Count the number of integers < 10 in the vector  
    vector<int>::iterator::difference_type result2;  
    result2 = count_if(v1.begin(), v1.end(), bind1st(greater<int>(), 10));  
    cout << "The number of elements in v1 less than 10 is: "  
         << result2 << "." << endl;  
}  
```  
  
 **The vector v1 = ( 0 5 10 15 20 25 )**  
**The number of elements in v1 greater than 10 is: 3.**  
**The number of elements in v1 greater than 15 is: 2.**  
**The number of elements in v1 less than 10 is: 2.**   
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)