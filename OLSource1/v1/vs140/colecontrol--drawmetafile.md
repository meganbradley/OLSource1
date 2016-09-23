---
title: "COleControl::DrawMetafile"
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
  - COleControl.DrawMetafile
  - DrawMetafile
  - COleControl::DrawMetafile
dev_langs: 
  - C++
helpviewer_keywords: 
  - DrawMetafile method
ms.assetid: 3a90d025-2cea-46fc-a139-7e2eecb796b7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleControl::DrawMetafile
Called by the framework when the metafile device context is being used.  
  
## Syntax  
  
```  
  
      void DrawMetafile(  
   CDC* pDC,  
   CRect& rc  
);  
```  
  
#### Parameters  
 `pDC`  
 Pointer to the metafile device context.  
  
 `rc`  
 Rectangular area to be drawn in.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::OnDraw](../vs140/colecontrol--ondraw.md)   
 [COleControl::DrawContent](../vs140/colecontrol--drawcontent.md)   
 [COleControl::OnDrawMetafile](../vs140/colecontrol--ondrawmetafile.md)