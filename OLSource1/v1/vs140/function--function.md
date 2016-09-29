---
title: "function::function"
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
  - "functional/std::tr1::function"
  - "function::function"
  - "std::tr1::function::function"
  - "function.function"
  - "std.tr1.function.function"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "function constructor [TR1]"
ms.assetid: 10504e05-f7ed-4c1f-83d7-a955964afc4e
caps.latest.revision: 25
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# function::function
Constructs a wrapper that either is empty or stores a callable object of arbitrary type with a fixed signature.  
  
## Syntax  
  
```  
function();  
function(nullptr_t npc);  
function(const function& _Right);  
template<class Fx>  
   function(Fx _Func);  
template<class Fx>  
    function(reference_wrapper<Fx> _Fnref);  
template<class Fx, class Alloc>  
    function(  
        Fx _Func,   
        const Alloc& _Ax  
);  
template<class Fx, class Alloc>  
    function(  
        reference_wrapper<Fx> _Fnref,   
        const Alloc& _Ax  
    );  
```  
  
#### Parameters  
 `_Right`  
 The function object to copy.  
  
 Fx  
 The type of the callable object.  
  
 `_Func`  
 The callable object to wrap.  
  
 Alloc  
 The allocator type.  
  
 `_Ax`  
 The allocator.  
  
 `_Fnref`  
 The callable object reference to wrap.  
  
## Remarks  
 The first two constructors construct an empty `function` object. The next three constructors construct a `function` object that holds the callable object passed as the operand. The last two constructors allocate storage with the allocator object _Ax.  
  
## Example  
  
```  
// std_tr1__functional__function_function.cpp   
// compile with: /EHsc   
#include <functional>   
#include <iostream>   
#include <vector>  
  
int square(int val)  
{  
    return val * val;  
}  
  
class multiply_by  
{  
public:  
    explicit multiply_by(const int n) : m_n(n) { }  
  
    int operator()(const int x) const  
    {  
        return m_n * x;  
    }  
  
private:  
    int m_n;  
};  
  
int main()   
{   
  
    typedef std::vector< std::function<int (int)> > vf_t;  
  
    vf_t v;  
    v.push_back(square);  
    v.push_back(std::negate<int>());  
    v.push_back(multiply_by(3));  
  
    for (vf_t::const_iterator i = v.begin(); i != v.end(); ++i)  
    {  
        std::cout << (*i)(10) << std::endl;  
    }  
  
    std::function<int (int)> f = v[0];  
    std::function<int (int)> g;  
  
    if (f) {  
        std::cout << "f is non-empty (correct)." << std::endl;  
    } else {  
        std::cout << "f is empty (can't happen)." << std::endl;  
    }  
  
    if (g) {  
        std::cout << "g is non-empty (can't happen)." << std::endl;  
    } else {  
        std::cout << "g is empty (correct)." << std::endl;  
    }  
  
    return 0;   
}  
```  
  
 **100**  
**-10**  
**30**  
**f is non-empty (correct).**  
**g is empty (correct).**   
## Requirements  
 **Header:** \<functional>  
  
 **Namespace:** std  
  
## See Also  
 [function](../vs140/function-class.md)   
 [function::operator=](../vs140/function--operator=.md)   
 [lvalues and rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)