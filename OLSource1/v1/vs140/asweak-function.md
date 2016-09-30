---
title: "AsWeak Function"
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
  - "client/Microsoft::WRL::AsWeak"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AsWeak function"
ms.assetid: a6f10cfc-c1d6-4761-adb9-1a119cc99913
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AsWeak Function
Retrieves a weak reference to a specified instance.  
  
## Syntax  
  
```  
template<  
   typename T  
>  
HRESULT AsWeak(  
   _In_ T* p,  
   _Out_ WeakRef* pWeak  
);  
```  
  
#### Parameters  
 `T`  
 A pointer to the type of parameter `p`.  
  
 `p`  
 An instance of a type.  
  
 `pWeak`  
 When this operation completes, a pointer to a weak reference to parameter `p`.  
  
## Return Value  
 S_OK, if this operation is successful; otherwise, an error HRESULT that indicates the cause of the failure.  
  
## Requirements  
 **Header:** client.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [WRL Namespace](../vs140/microsoft--wrl-namespace.md)