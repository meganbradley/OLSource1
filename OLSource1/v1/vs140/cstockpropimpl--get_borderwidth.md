---
title: "CStockPropImpl::get_BorderWidth"
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
  - "CStockPropImpl::get_BorderWidth"
  - "CStockPropImpl.get_BorderWidth"
  - "ATL::CStockPropImpl::get_BorderWidth"
  - "get_BorderWidth"
  - "ATL.CStockPropImpl.get_BorderWidth"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_BorderWidth method"
ms.assetid: 83d94aa9-ffa5-4358-a412-5edd97bff629
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStockPropImpl::get_BorderWidth
Call this method to get the width of the control's border.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE get_BorderWidth(  
   LONG * pnBorderWidth  
);  
```  
  
#### Parameters  
 *pnBorderWidth*  
 Variable that receives the control's border width.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::put_BorderWidth](../vs140/cstockpropimpl--put_borderwidth.md)