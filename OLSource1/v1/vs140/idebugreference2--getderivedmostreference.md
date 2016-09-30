---
title: "IDebugReference2::GetDerivedMostReference"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugReference2::GetDerivedMostReference"
helpviewer_keywords: 
  - "IDebugReference2::GetDerivedMostReference"
ms.assetid: 07253b74-7d39-48e0-8e85-ac8dfd919f6e
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugReference2::GetDerivedMostReference
Gets the derived-most reference of a reference. Reserved for future use.  
  
## Syntax  
  
```cpp#  
HRESULT GetDerivedMostReference(   
   IDebugReference2** ppDerivedMost  
);  
```  
  
```c#  
int GetDerivedMostReference(   
   out IDebugReference2 ppDerivedMost  
);  
```  
  
#### Parameters  
 `ppDerivedMost`  
 [out] Returns an [IDebugReference2](../vs140/idebugreference2.md) object that represents the derived-most property.  
  
## Return Value  
 Always returns `E_NOTIMPL`.  
  
## Remarks  
 For example, if this property describes an object that implements `ClassRoot` but which is actually an instantiation of `ClassDerived` that is derived from `ClassRoot`, then this method returns an [IDebugReference2](../vs140/idebugreference2.md) object representing a reference to the `ClassDerived` object.  
  
## See Also  
 [IDebugReference2](../vs140/idebugreference2.md)