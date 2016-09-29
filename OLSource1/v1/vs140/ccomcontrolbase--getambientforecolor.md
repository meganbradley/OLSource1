---
title: "CComControlBase::GetAmbientForeColor"
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
  - "GetAmbientForeColor"
  - "ATL.CComControlBase.GetAmbientForeColor"
  - "CComControlBase.GetAmbientForeColor"
  - "ATL::CComControlBase::GetAmbientForeColor"
  - "CComControlBase::GetAmbientForeColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAmbientForeColor method"
  - "DISPID_AMBIENT_FORECOLR property"
ms.assetid: a87e4899-d249-4444-9712-fa27ccd1ae40
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::GetAmbientForeColor
Retrieves **DISPID_AMBIENT_FORECOLOR**, the ambient foreground color for all controls, defined by the container.  
  
## Syntax  
  
```  
  
      HRESULT GetAmbientForeColor(  
   OLE_COLOR& ForeColor   
);  
```  
  
#### Parameters  
 *ForeColor*  
 The property **DISPID_AMBIENT_FORECOLOR**.  
  
## Return Value  
 One of the standard HRESULT values.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)