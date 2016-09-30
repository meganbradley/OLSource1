---
title: "CComControlBase::GetAmbientUserMode"
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
  - "GetAmbientUserMode"
  - "CComControlBase.GetAmbientUserMode"
  - "ATL.CComControlBase.GetAmbientUserMode"
  - "CComControlBase::GetAmbientUserMode"
  - "ATL::CComControlBase::GetAmbientUserMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DISPID_AMBIENT_USERMODE property"
  - "GetAmbientUserMode method"
ms.assetid: 8cc820e3-5b78-4a25-a345-39350e99ea68
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::GetAmbientUserMode
Retrieves **DISPID_AMBIENT_USERMODE**, a flag indicating whether the container is in run-mode (**TRUE**) or design-mode (**FALSE**).  
  
## Syntax  
  
```  
  
      HRESULT GetAmbientUserMode(  
   BOOL& bUserMode  
);  
```  
  
#### Parameters  
 `bUserMode`  
 The property **DISPID_AMBIENT_USERMODE**.  
  
## Return Value  
 One of the standard HRESULT values.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)