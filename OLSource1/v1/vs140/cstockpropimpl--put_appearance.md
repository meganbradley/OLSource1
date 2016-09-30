---
title: "CStockPropImpl::put_Appearance"
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
  - "ATL.CStockPropImpl.put_Appearance"
  - "ATL::CStockPropImpl::put_Appearance"
  - "CStockPropImpl::put_Appearance"
  - "put_Appearance"
  - "CStockPropImpl.put_Appearance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put_Appearance method"
ms.assetid: b46afac2-c673-496f-8819-03475a3ad2f4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStockPropImpl::put_Appearance
Call this method to set the paint style used by the control, for example, flat or 3D.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE put_Appearance(   
   SHORT nAppearance  
);  
```  
  
#### Parameters  
 `nAppearance`  
 The new paint style to be used by the control.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::get_Appearance](../vs140/cstockpropimpl--get_appearance.md)