---
title: "CStockPropImpl::get_Font"
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
  - "ATL::CStockPropImpl::get_Font"
  - "ATL.CStockPropImpl.get_Font"
  - "CStockPropImpl.get_Font"
  - "get_Font"
  - "CStockPropImpl::get_Font"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_Font method"
ms.assetid: f0a8cca1-b3d6-4b5e-b461-2ae2572dc579
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStockPropImpl::get_Font
Call this method to get a pointer to the control's font properties.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE get_Font(  
   IFontDisp** ppFont  
);  
```  
  
#### Parameters  
 `ppFont`  
 Variable that receives a pointer to the control's font properties.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::put_Font](../vs140/cstockpropimpl--put_font.md)