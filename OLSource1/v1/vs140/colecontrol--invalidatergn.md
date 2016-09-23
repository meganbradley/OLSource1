---
title: "COleControl::InvalidateRgn"
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
  - COleControl.InvalidateRgn
  - COleControl::InvalidateRgn
dev_langs: 
  - C++
helpviewer_keywords: 
  - InvalidateRgn method
ms.assetid: 5e19a401-8907-4828-95bc-9a3aa08b9561
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleControl::InvalidateRgn
Invalidates the container window's client area within the given region.  
  
## Syntax  
  
```  
  
      void InvalidateRgn(  
   CRgn* pRgn,  
   BOOL bErase = TRUE   
);  
```  
  
#### Parameters  
 `pRgn`  
 A pointer to a [CRgn](../vs140/crgn-class.md) object that identifies the display region of the OLE object to invalidate, in client coordinates of the containing window. If this parameter is **NULL**, the extent is the entire object.  
  
 `bErase`  
 Specifies whether the background within the invalidated region is to be erased. If **TRUE**, the background is erased. If **FALSE**, the background remains unchanged.  
  
## Remarks  
 This can be used to redraw windowless controls within the container. The invalidated region, along with all other areas in the update region, is marked for painting when the next [WM_PAINT](http://msdn.microsoft.com/library/windows/desktop/dd145213) message is sent.  
  
 If `bErase` is **TRUE** for any part of the update region, the background in the entire region, not just in the given part, is erased.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)