---
title: "CComControlBase::GetAmbientShowGrabHandles"
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
  - "ATL::CComControlBase::GetAmbientShowGrabHandles"
  - "ATL.CComControlBase.GetAmbientShowGrabHandles"
  - "GetAmbientShowGrabHandles"
  - "CComControlBase::GetAmbientShowGrabHandles"
  - "CComControlBase.GetAmbientShowGrabHandles"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAmbientShowGrabHandles method"
  - "DISPID_AMBIENT_SHOWGRABHANDLES property"
ms.assetid: 2d95e465-9210-4fe8-859a-f6d6b0cbacb6
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::GetAmbientShowGrabHandles
Retrieves **DISPID_AMBIENT_SHOWGRABHANDLES**, a flag indicating whether the container allows the control to display grab handles for itself when active.  
  
## Syntax  
  
```  
  
      HRESULT GetAmbientShowGrabHandles(  
   BOOL& bShowGrabHandles  
);  
```  
  
#### Parameters  
 *bShowGrabHandles*  
 The property **DISPID_AMBIENT_SHOWGRABHANDLES**.  
  
## Return Value  
 One of the standard HRESULT values.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)