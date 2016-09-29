---
title: "WeakReference::SetUnknown Method"
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
  - "implements/Microsoft::WRL::Details::WeakReference::SetUnknown"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetUnknown method"
ms.assetid: 5dddb9e3-a7c1-4195-8166-97c5ab6e972f
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# WeakReference::SetUnknown Method
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
```  
void SetUnknown(  
   _In_ IUnknown* unk  
);  
```  
  
#### Parameters  
 `unk`  
 A pointer to the `IUnknown` interface of an object.  
  
## Remarks  
 Sets the strong reference of the current `WeakReference` object to the specified interface pointer.  
  
## Requirements  
 **Header:** implements.h  
  
 **Namespace:** Microsoft::WRL::Details  
  
## See Also  
 [WeakReference Class](../vs140/weakreference-class.md)   
 [Microsoft::WRL::Details Namespace](../vs140/microsoft--wrl--details-namespace.md)