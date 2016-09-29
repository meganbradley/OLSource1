---
title: "operator&gt; (&lt;memory&gt;)"
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
  - "std::operator>"
  - "memory/std::operator>"
  - "std.operator>"
  - "operator>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator> operator"
ms.assetid: 4dfdeb34-c8b7-4e6f-97e6-5b6307c99e5a
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&gt; (&lt;memory&gt;)
Tests for one object being greater than a second object.  
  
## Syntax  
  
```  
template<class Ty1, class Del1, class Ty2, class Del2>  
    bool operator>(  
        const unique_ptr<Ty1, Del1>& _Left,  
        const unique_ptr<Ty2&, Del2gt;& _Right  
    );  
template<class Ty1, class Ty2>  
    bool operator>(  
        const shared_ptr<Ty1>& _Left,  
        const shared_ptr<Ty2>& _Right  
    );  
```  
  
#### Parameters  
 `_Left`  
 One of the objects to be compared.  
  
 `_Right`  
 One of the objects to be compared.  
  
 `Ty1`  
 The type controlled by the left shared pointer.  
  
 `Ty2`  
 The type controlled by the right shared pointer.  
  
## Property Value/Return Value  
 Returns `_Left``.get() >` `_Right``.get().`  
  
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [<memory\>](../vs140/-memory-.md)   
 [shared_ptr Class](../vs140/shared_ptr-class.md)   
 [unique_ptr Class](../vs140/unique_ptr-class.md)