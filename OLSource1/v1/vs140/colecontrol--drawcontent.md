---
title: "COleControl::DrawContent"
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
  - "COleControl.DrawContent"
  - "COleControl::DrawContent"
  - "DrawContent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawContent method"
ms.assetid: 9fc9ec40-d2de-41ff-82c0-f9e7d069dd9f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::DrawContent
Called by the framework when the control's appearance needs to be updated.  
  
## Syntax  
  
```  
  
      void DrawContent(  
   CDC* pDC,  
   CRect& rc   
);  
```  
  
#### Parameters  
 `pDC`  
 Pointer to the device context.  
  
 `rc`  
 Rectangular area to be drawn in.  
  
## Remarks  
 This function directly calls the overridable `OnDraw` function.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::OnDraw](../vs140/colecontrol--ondraw.md)   
 [COleControl::DrawMetafile](../vs140/colecontrol--drawmetafile.md)   
 [COleControl::OnDrawMetafile](../vs140/colecontrol--ondrawmetafile.md)