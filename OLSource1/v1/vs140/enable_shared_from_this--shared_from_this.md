---
title: "enable_shared_from_this::shared_from_this"
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
  - "enable_shared_from_this.shared_from_this"
  - "tr1::enable_shared_from_this::shared_from_this"
  - "tr1.enable_shared_from_this.shared_from_this"
  - "std::tr1::enable_shared_from_this::shared_from_this"
  - "enable_shared_from_this::shared_from_this"
  - "std.tr1.enable_shared_from_this.shared_from_this"
  - "shared_from_this"
  - "memory/std::tr1::enable_shared_from_this::shared_from_this"
  - "std.enable_shared_from_this.shared_from_this"
  - "std::enable_shared_from_this::shared_from_this"
  - "memory/std::enable_shared_from_this::shared_from_this"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "shared_from_this method"
  - "shared_from_this method [TR1]"
ms.assetid: e3465b8e-d61a-4873-aa05-0b657e29fe48
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# enable_shared_from_this::shared_from_this
Generates a `shared_ptr` that shares ownership of the instance with existing `shared_ptr` owners.  
  
## Syntax  
  
```  
shared_ptr<T> shared_from_this();  
shared_ptr<const T> shared_from_this() const;  
```  
  
## Remarks  
 When you derive objects from the `enable_shared_from_this` base class, the `shared_from_this` template member functions return a [shared_ptr](../vs140/shared_ptr-class.md) object that shares ownership of this instance with existing `shared_ptr` owners. Otherwise, if you create a new `shared_ptr` from `this`, it is distinct from existing `shared_ptr` owners, which can lead to invalid references or cause the object to be deleted more than once. The  behavior is undefined if you call `shared_from_this` on an instance that is not already owned by a `shared_ptr` object.  
  
## Example  
  
```  
// std_memory_shared_from_this.cpp   
// compile with: /EHsc   
#include <memory>  
#include <iostream>  
  
using namespace std;  
  
struct base : public std::enable_shared_from_this<base>  
{  
    int val;  
  
    shared_ptr<base> share_more()  
    {  
        return shared_from_this();  
    }  
};  
  
int main()  
{  
    auto sp1 = make_shared<base>();  
    auto sp2 = sp1->share_more();  
  
    sp1->val = 3;  
    cout << "sp2->val == " << sp2->val << endl;  
  
    return 0;  
}   
```  
  
 **sp2->val == 3**   
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [enable_shared_from_this](../vs140/enable_shared_from_this-class.md)