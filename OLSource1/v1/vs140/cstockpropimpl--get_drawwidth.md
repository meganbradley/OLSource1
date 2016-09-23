---
title: "CStockPropImpl::get_DrawWidth"
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
  - ATL.CStockPropImpl.get_DrawWidth
  - CStockPropImpl.get_DrawWidth
  - get_DrawWidth
  - ATL::CStockPropImpl::get_DrawWidth
  - CStockPropImpl::get_DrawWidth
dev_langs: 
  - C++
helpviewer_keywords: 
  - get_DrawWidth method
ms.assetid: 054f84cf-453c-4b66-9227-cd1cce9d1807
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CStockPropImpl::get_DrawWidth
Call this method to get the drawing width (in pixels) used by the control's drawing methods.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE get_DrawWidth(   
   LONG * pnDrawWidth  
);  
```  
  
#### Parameters  
 *pnDrawWidth*  
 Variable that receives the control's width value, in pixels.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::put_DrawWidth](../vs140/cstockpropimpl--put_drawwidth.md)