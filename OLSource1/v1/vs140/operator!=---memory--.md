---
title: "operator!= (&lt;memory&gt;)"
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
  - "std::!="
  - "!="
  - "std::operator!="
  - "std.operator!="
  - "std.!="
  - "memory/std::operator!="
  - "operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator !=, allocators objects"
  - "operator !=, unique_ptr objects"
  - "!= operator"
  - "operator!=, unique_ptr objects"
  - "operator!=, allocators objects"
ms.assetid: 4c87d3f8-fa0d-486b-bed7-1123b3968d32
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator!= (&lt;memory&gt;)
Tests for inequality between objects.  
  
## Syntax  
  
```  
template<class Type, class Other>  
   bool operator!=(  
      const allocator<Type>& _Left,  
      const allocator<Other>& _Right  
   ) throw();  
template<class Type1, class Del1, class Type2, class Del2>  
    bool operator!=(  
        const unique_ptr<Type1, Del1>& _Left,  
        const unique_ptr<Type2&, Del2>& _Right  
);  
template<class Ty1, class Ty2>  
    bool operator!=(  
        const shared_ptr<Ty1>& _Left,  
        const shared_ptr<Ty2>& _Right  
   );  
  
```  
  
#### Parameters  
 `_Left`  
 One of the objects to be tested for inequality.  
  
 `_Right`  
 One of the objects to be tested for inequality.  
  
 `Ty1`  
 The type controlled by the left shared pointer.  
  
 `Ty2`  
 The type controlled by the right shared pointer.  
  
## Return Value  
 **true** if the objects are not equal; **false** if objects are equal.  
  
## Remarks  
 The first template operator returns false. (All default allocators are equal.)  
  
 The second and third template operators return `!(``_Left` `==` `_Right``)`.  
  
## Example  
  
```  
// memory_op_me.cpp  
// compile with: /EHsc  
#include <memory>  
#include <iostream>  
#include <vector>  
  
using namespace std;  
  
int main( )   
{  
   allocator<double> Alloc;  
   vector <char>:: allocator_type v1Alloc;  
  
   if ( Alloc != v1Alloc )  
      cout << "The allocator objects Alloc & v1Alloc not are equal."  
           << endl;  
   else  
      cout << "The allocator objects Alloc & v1Alloc are equal."  
           << endl;  
}  
```  
  
 **The allocator objects Alloc & v1Alloc are equal.**   
## Example  
  
```  
// std_tr1__memory__operator_ne.cpp   
// compile with: /EHsc   
#include <memory>   
#include <iostream>   
  
int main()   
    {   
    std::shared_ptr<int> sp0(new int(0));   
    std::shared_ptr<int> sp1(new int(0));   
  
    std::cout << "sp0 != sp0 == " << std::boolalpha   
        << (sp0 != sp0) << std::endl;   
    std::cout << "sp0 != sp1 == " << std::boolalpha   
        << (sp0 != sp1) << std::endl;   
  
    return (0);   
    }  
  
```  
  
 **sp0 != sp0 == false**  
**sp0 != sp1 == true**   
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [auto_ptr Class](../vs140/auto_ptr-class.md)   
 [shared_ptr Class](../vs140/shared_ptr-class.md)   
 [shared_ptr::operator!=](assetId:///1798dc0c-311b-4a1a-8148-5d21e41026e0)   
 [unique_ptr Class](../vs140/unique_ptr-class.md)