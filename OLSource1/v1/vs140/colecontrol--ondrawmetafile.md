---
title: "COleControl::OnDrawMetafile"
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
  - "COleControl::OnDrawMetafile"
  - "OnDrawMetafile"
  - "COleControl.OnDrawMetafile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawMetafile method"
ms.assetid: e1345c9b-183c-4ce5-88b8-3b92202e3df1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnDrawMetafile
Called by the framework to draw the OLE control in the specified bounding rectangle using the specified metafile device context.  
  
## Syntax  
  
```  
  
      virtual void OnDrawMetafile(  
   CDC* pDC,  
   const CRect& rcBounds   
);  
```  
  
#### Parameters  
 `pDC`  
 The device context in which the drawing occurs.  
  
 `rcBounds`  
 The rectangular area of the control, including the border.  
  
## Remarks  
 The default implementation calls the [OnDraw](../vs140/colecontrol--ondraw.md) function.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::OnDraw](../vs140/colecontrol--ondraw.md)   
 [COleControl::DrawContent](../vs140/colecontrol--drawcontent.md)   
 [COleControl::DrawMetafile](../vs140/colecontrol--drawmetafile.md)