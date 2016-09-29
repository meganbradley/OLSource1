---
title: "CComControlBase::GetAmbientMessageReflect"
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
  - "GetAmbientMessageReflect"
  - "CComControlBase.GetAmbientMessageReflect"
  - "ATL.CComControlBase.GetAmbientMessageReflect"
  - "CComControlBase::GetAmbientMessageReflect"
  - "ATL::CComControlBase::GetAmbientMessageReflect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAmbientMessageReflect method"
  - "DISPID_AMBIENT_MESSAGEREFLECT property"
ms.assetid: 760f1e63-c2f1-4709-b4a0-93188e5fcd3b
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::GetAmbientMessageReflect
Retrieves **DISPID_AMBIENT_MESSAGEREFLECT**, a flag indicating whether the container wants to receive window messages (such as `WM_DRAWITEM`) as events.  
  
## Syntax  
  
```  
  
      HRESULT GetAmbientMessageReflect(  
   BOOL& bMessageReflect  
);  
```  
  
#### Parameters  
 `bMessageReflect`  
 The property **DISPID_AMBIENT_MESSAGEREFLECT**.  
  
## Return Value  
 One of the standard HRESULT values.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)