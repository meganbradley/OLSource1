---
title: "CComControlBase::GetAmbientAppearance"
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
  - "CComControlBase.GetAmbientAppearance"
  - "GetAmbientAppearance"
  - "CComControlBase::GetAmbientAppearance"
  - "ATL::CComControlBase::GetAmbientAppearance"
  - "ATL.CComControlBase.GetAmbientAppearance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DISPID_AMBIENT_APPEARANCE property"
  - "GetAmbientAppearance method"
ms.assetid: 88e8087b-141f-4998-9eba-8e6d07265c29
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::GetAmbientAppearance
Retrieves **DISPID_AMBIENT_APPEARANCE**, the current appearance setting for the control: 0 for flat and 1 for 3D.  
  
## Syntax  
  
```  
  
      HRESULT GetAmbientAppearance(  
   short& nAppearance  
);   
```  
  
#### Parameters  
 `nAppearance`  
 The property **DISPID_AMBIENT_APPEARANCE**.  
  
## Return Value  
 One of the standard HRESULT values.  
  
## Example  
 [!code[NVC_ATL_COM#22](../vs140/codesnippet/CPP/ccomcontrolbase--getambientappearance_1.h)]  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)