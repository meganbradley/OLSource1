---
title: "CStockPropImpl::get_BackColor"
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
  - "ATL::CStockPropImpl::get_BackColor"
  - "ATL.CStockPropImpl.get_BackColor"
  - "CStockPropImpl::get_BackColor"
  - "CStockPropImpl.get_BackColor"
  - "get_BackColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_BackColor method"
ms.assetid: 72755bbf-a668-4fd9-89bb-3ea631862617
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStockPropImpl::get_BackColor
Call this method to get the control's background color.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE get_BackColor(  
   OLE_COLOR * pclrBackColor  
);  
```  
  
#### Parameters  
 *pclrBackColor*  
 Variable that receives the control's background color.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::put_BackColor](../vs140/cstockpropimpl--put_backcolor.md)