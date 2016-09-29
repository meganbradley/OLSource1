---
title: "CComControlBase::GetAmbientFont"
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
  - "CComControlBase.GetAmbientFont"
  - "GetAmbientFont"
  - "ATL.CComControlBase.GetAmbientFont"
  - "ATL::CComControlBase::GetAmbientFont"
  - "CComControlBase::GetAmbientFont"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAmbientFont method"
ms.assetid: 012aeb2e-e925-43b8-a3b8-271912144279
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::GetAmbientFont
Retrieves a pointer to the container's ambient `IFont` interface.  
  
## Syntax  
  
```  
  
      HRESULT GetAmbientFont(  
   IFont** ppFont   
);  
```  
  
#### Parameters  
 `ppFont`  
 A pointer to the container's ambient [IFont](http://msdn.microsoft.com/library/windows/desktop/ms680673) interface.  
  
## Return Value  
 One of the standard HRESULT values.  
  
## Remarks  
 If the property is **NULL**, the pointer is **NULL**. If the pointer is not **NULL**, the caller must release the pointer.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)