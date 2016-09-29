---
title: "CStockPropImpl::put_Font"
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
  - "ATL.CStockPropImpl.put_Font"
  - "CStockPropImpl.put_Font"
  - "ATL::CStockPropImpl::put_Font"
  - "put_Font"
  - "CStockPropImpl::put_Font"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put_Font method"
ms.assetid: 709c3389-9c46-45fe-a133-db169dc47da9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStockPropImpl::put_Font
Call this method to set the control's font properties.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE put_Font(  
   IFontDisp* pFont   
);  
```  
  
#### Parameters  
 `pFont`  
 A pointer to the control's font properties.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::get_Font](../vs140/cstockpropimpl--get_font.md)   
 [CStockPropImpl::putref_Font](../vs140/cstockpropimpl--putref_font.md)