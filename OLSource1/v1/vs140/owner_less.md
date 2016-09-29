---
title: "owner_less"
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
  - "owner_less"
  - "std::owner_less"
  - "memory/std::owner_less"
  - "std.owner_less"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "owner_less struct"
  - "owner_less function"
ms.assetid: b143c891-707a-4c68-8aaa-bab9dcc65c41
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# owner_less
Allows ownership-based mixed comparisons of shared and weak pointers. Returns `true` if the left parameter is ordered before right parameter by the member function `owner_before`.  
  
## Syntax  
  
```  
template<class Type>  
    struct owner_less; // not defined  
  
template<class Type>  
    struct owner_less<shared_ptr<Type> > {  
    bool operator()(  
        const shared_ptr<Type>& _Left,  
        const shared_ptr<Type>& _Right  
);  
    bool operator()(  
        const shared_ptr<Type>& _Left,  
        const weak_ptr<Type>& _Right  
);  
    bool operator()(  
        const weak_ptr<Type>& _Left,  
        const shared_ptr<Type>& _Right  
);  
};  
  
template<class Type>  
    struct owner_less<weak_ptr<Type> >  
    bool operator()(  
        const weak_ptr<Type>& _Left,  
        const weak_ptr<Type>& _Right  
);  
    bool operator()(  
        const weak_ptr<Type>& _Left,  
        const shared_ptr<Ty>& _Right  
);  
    bool operator()(  
        const shared_ptr<Type>& _Left,  
        const weak_ptr<Type>& _Right  
);  
};  
```  
  
#### Parameters  
 `_left`  
 A shared or weak pointer.  
  
 `_Right`  
 A shared or weak pointer.  
  
## Property Value/Return Value  
 Returns `true` if `_Left` is ordered before `_Right` by the member function `owner_before`.  
  
## Remarks  
 The template classes define all their member operators as returning `_Left``.owner_before(``_Right``)`.  
  
## Requirements  
 **Header:** <memory\>  
  
 **Namespace:** std  
  
## See Also  
 [shared_ptr::owner_before](../vs140/shared_ptr--owner_before.md)   
 [weak_ptr::owner_before](../vs140/weak_ptr--owner_before.md)   
 [<memory\>](../vs140/-memory-.md)