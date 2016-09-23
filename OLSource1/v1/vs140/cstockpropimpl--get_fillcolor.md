---
title: "CStockPropImpl::get_FillColor"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATL::CStockPropImpl::get_FillColor
  - get_FillColor
  - CStockPropImpl::get_FillColor
  - ATL.CStockPropImpl.get_FillColor
  - CStockPropImpl.get_FillColor
dev_langs: 
  - C++
helpviewer_keywords: 
  - get_FillColor method
ms.assetid: 25a7177b-3621-47ed-8c9e-e341c13468d4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CStockPropImpl::get_FillColor
Call this method to get the control's fill color.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE get_FillColor(   
   OLE_COLOR * pclrFillColor  
);  
```  
  
#### Parameters  
 *pclrFillColor*  
 Variable that receives the control's fill color.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::put_FillColor](../vs140/cstockpropimpl--put_fillcolor.md)