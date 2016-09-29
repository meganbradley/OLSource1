---
title: "operator== Operator (Microsoft::WRL)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "client/Microsoft::WRL::operator=="
dev_langs: 
  - "C++"
ms.assetid: 94f383a5-17a9-40c7-9d9c-778acdc54b27
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator== Operator (Microsoft::WRL)
Equality operator for [ComPtr](../vs140/comptr-class.md) and [ComPtrRef](../vs140/comptrref-class.md) objects.  
  
## Syntax  
  
```  
WRL_NOTHROW bool operator==(  
   const ComPtr<T>& a,  
   const ComPtr<U>& b  
);  
WRL_NOTHROW bool operator==(  
   const ComPtr<T>& a,  
   decltype(__nullptr)  
);  
WRL_NOTHROW bool operator==(  
   decltype(__nullptr),  
   const ComPtr<T>& a  
);  
WRL_NOTHROW bool operator==(  
   const Details::ComPtrRef<ComPtr<T>>& a,  
   const Details::ComPtrRef<ComPtr<U>>& b  
);  
WRL_NOTHROW bool operator==(  
   const Details::ComPtrRef<ComPtr<T>>& a,  
   decltype(__nullptr)  
);  
WRL_NOTHROW bool operator==(  
   decltype(__nullptr),  
   const Details::ComPtrRef<ComPtr<T>>& a  
);  
WRL_NOTHROW bool operator==(  
   const Details::ComPtrRef<ComPtr<T>>& a,  
   void* b  
);  
WRL_NOTHROW bool operator==(  
   void* b,  
   const Details::ComPtrRef<ComPtr<T>>& a  
);  
```  
  
#### Parameters  
 `a`  
 The left object.  
  
 `b`  
 The right object.  
  
## Return Value  
 `true` if the objects are equal; otherwise, `false`.  
  
## Requirements  
 **Header:** client.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [WRL Namespace](../vs140/microsoft--wrl-namespace.md)