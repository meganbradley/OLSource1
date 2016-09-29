---
title: "CStockPropImpl::put_BorderStyle"
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
  - "ATL::CStockPropImpl::put_BorderStyle"
  - "CStockPropImpl::put_BorderStyle"
  - "put_BorderStyle"
  - "ATL.CStockPropImpl.put_BorderStyle"
  - "CStockPropImpl.put_BorderStyle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put_BorderStyle method"
ms.assetid: 44090edc-049c-48af-a2cf-7914e8bb7573
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStockPropImpl::put_BorderStyle
Call this method to set the control's border style.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE put_BorderStyle(  
   LONG nBorderStyle  
);  
```  
  
#### Parameters  
 *nBorderStyle*  
 The new border style.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::get_BorderStyle](../vs140/cstockpropimpl--get_borderstyle.md)