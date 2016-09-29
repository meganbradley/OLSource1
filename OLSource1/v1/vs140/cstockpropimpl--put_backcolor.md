---
title: "CStockPropImpl::put_BackColor"
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
  - "put_BackColor"
  - "CStockPropImpl.put_BackColor"
  - "CStockPropImpl::put_BackColor"
  - "ATL.CStockPropImpl.put_BackColor"
  - "ATL::CStockPropImpl::put_BackColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "put_BackColor method"
ms.assetid: 55e24bee-6e29-453a-a3d6-3b1193298b4e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStockPropImpl::put_BackColor
Call this method to set the control's background color.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE put_BackColor(  
   OLE_COLOR clrBackColor  
);  
```  
  
#### Parameters  
 *clrBackColor*  
 The new control background color.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::get_BackColor](../vs140/cstockpropimpl--get_backcolor.md)