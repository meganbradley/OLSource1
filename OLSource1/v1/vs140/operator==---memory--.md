---
title: "operator== (&lt;memory&gt;)"
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
  - "std.=="
  - "std::=="
  - "memory/std::operator=="
  - "operator=="
  - "std.operator=="
  - "std::operator=="
  - "=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator ==, unique_ptr objects"
  - "operator==, unique_ptr objects"
  - "operator ==, allocators objects"
  - "== operator, with specific standard C++ objects"
  - "operator==, allocators objects"
ms.assetid: 04c15ebd-14ce-43bd-b68f-4e468c2e950c
caps.latest.revision: 25
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# operator== (&lt;memory&gt;)
Tests for equality between objects.  
  
## Syntax  
  
```  
template<class Type, class Other>  
   bool operator==(  
      const allocator<Type>& _Left,  
      const allocator<Other>& _Right  
   ) throw();  
template<class Ty1, class Del1, class Ty2, class Del2>  
    bool operator==(  
        const unique_ptr<Ty1, Del1>& _Left,  
        const unique_ptr<Ty2, Del2>& _Right  
    );  
template<class Ty1, class Ty2>  
    bool operator==(  
      const shared_ptr<Ty1>& _Left;,  
      const shared_ptr<Ty2>& _Right  
   );  
  
```  
  
#### Parameters  
 `_Left`  
 One of the objects to be tested for equality.  
  
 `_Right`  
 One of the objects to be tested for equality.  
  
 `Ty1`  
 The type controlled by the left shared pointer.  
  
 `Ty2`  
 The type controlled by the right shared pointer.  
  
## Return Value  
 `true` if the objects are equal, `false` if objects are not equal.  
  
## Remarks  
 The first template operator returns true. (All default allocators are equal.)  
  
 The second and third template operators return `_Left.get() == _Right.get()`.  
  
## Example  
  
```  
// memory_op_eq.cpp  
// compile with: /EHsc  
#include <memory>  
#include <iostream>  
#include <vector>  
  
using namespace std;  
  
int main( )   
{  
   allocator<char> Alloc;  
   vector <int>:: allocator_type v1Alloc;  
  
   allocator<char> cAlloc(Alloc);   
   allocator<int> cv1Alloc(v1Alloc);  
  
   if ( cv1Alloc == v1Alloc )  
      cout << "The allocator objects cv1Alloc & v1Alloc are equal."  
           << endl;  
   else  
      cout << "The allocator objects cv1Alloc & v1Alloc are not equal."  
           << endl;  
  
   if ( cAlloc == Alloc )  
      cout << "The allocator objects cAlloc & Alloc are equal."  
           << endl;  
   else  
      cout << "The allocator objects cAlloc & Alloc are not equal."  
           << endl;  
}  
```  
  
 **The allocator objects cv1Alloc & v1Alloc are equal.**  
**The allocator objects cAlloc & Alloc are equal.**   
## Example  
  
```  
// std_tr1__memory__operator_eq.cpp   
// compile with: /EHsc   
#include <memory>   
#include <iostream>   
  
int main()   
    {   
    std::shared_ptr<int> sp0(new int(0));   
    std::shared_ptr<int> sp1(new int(0));   
  
    std::cout << "sp0 == sp0 == " << std::boolalpha   
        << (sp0 == sp0) << std::endl;   
    std::cout << "sp0 == sp1 == " << std::boolalpha   
        << (sp0 == sp1) << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **sp0 == sp0 == true**  
**sp0 == sp1 == false**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [auto_ptr Class](../vs140/auto_ptr-class.md)   
 [shared_ptr Class](../vs140/shared_ptr-class.md)   
 [shared_ptr::operator==](assetId:///69467417-7d95-4363-b64e-ca5ac08b9530)   
 [unique_ptr Class](../vs140/unique_ptr-class.md)