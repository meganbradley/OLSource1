---
title: "CStockPropImpl::get_BorderColor"
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
  - "CStockPropImpl::get_BorderColor"
  - "CStockPropImpl.get_BorderColor"
  - "ATL.CStockPropImpl.get_BorderColor"
  - "ATL::CStockPropImpl::get_BorderColor"
  - "get_BorderColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_BorderColor method"
ms.assetid: 3207fcb6-204e-4e76-9f97-018403788691
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStockPropImpl::get_BorderColor
Call this method to get the control's border color.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE get_BorderColor(  
   OLE_COLOR * pclrBorderColor  
);  
```  
  
#### Parameters  
 *pclrBorderColor*  
 Variable that receives the control's border color.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::put_BorderColor](../vs140/cstockpropimpl--put_bordercolor.md)