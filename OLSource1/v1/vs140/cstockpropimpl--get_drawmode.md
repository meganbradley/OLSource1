---
title: "CStockPropImpl::get_DrawMode"
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
  - "CStockPropImpl::get_DrawMode"
  - "CStockPropImpl.get_DrawMode"
  - "ATL.CStockPropImpl.get_DrawMode"
  - "ATL::CStockPropImpl::get_DrawMode"
  - "get_DrawMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_DrawMode method"
ms.assetid: 88cb940e-ef92-4809-9b43-717c2d18135a
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStockPropImpl::get_DrawMode
Call this method to get the control's drawing mode, for example, XOR Pen or Invert Colors.  
  
## Syntax  
  
```  
  
      HRESULT STDMETHODCALLTYPE get_DrawMode(  
   LONG * pnDrawMode  
);  
```  
  
#### Parameters  
 *pnDrawMode*  
 Variable that receives the control's drawing mode.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CStockPropImpl Class](../vs140/cstockpropimpl-class.md)   
 [CStockPropImpl::put_DrawMode](../vs140/cstockpropimpl--put_drawmode.md)