---
title: "CComControlBase::GetAmbientBackColor"
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
  - "ATL::CComControlBase::GetAmbientBackColor"
  - "CComControlBase::GetAmbientBackColor"
  - "CComControlBase.GetAmbientBackColor"
  - "ATL.CComControlBase.GetAmbientBackColor"
  - "GetAmbientBackColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAmbientBackColor method"
  - "DISPID_AMBIENT_BACKCOLOR property"
ms.assetid: b197d89e-06be-4bde-b742-514ec030b648
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::GetAmbientBackColor
Retrieves **DISPID_AMBIENT_BACKCOLOR**, the ambient background color for all controls, defined by the container.  
  
## Syntax  
  
```  
  
      HRESULT GetAmbientBackColor(  
   OLE_COLOR& BackColor   
);  
```  
  
#### Parameters  
 *BackColor*  
 The property **DISPID_AMBIENT_BACKCOLOR**.  
  
## Return Value  
 One of the standard HRESULT values.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)