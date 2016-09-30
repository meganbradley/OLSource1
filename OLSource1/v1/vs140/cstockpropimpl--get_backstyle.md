---
title: "CStockPropImpl::get_BackStyle"
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
  - "CStockPropImpl.get_BackStyle"
  - "get_BackStyle"
  - "CStockPropImpl::get_BackStyle"
  - "ATL.CStockPropImpl.get_BackStyle"
  - "ATL::CStockPropImpl::get_BackStyle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_BackStyle method"
ms.assetid: 4e07ccea-2860-47d4-9b08-febb3e8c78da
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStockPropImpl::get_BackStyle
Call this method to get the control's background style, either transparent or opaque.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE get_BackStyle(  
   LONG * pnBackStyle  
);  
```  
  
#### Parameters  
 *pnBackStyle*  
 Variable that receives the control's background style.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::put_BackStyle](../vs140/cstockpropimpl--put_backstyle.md)