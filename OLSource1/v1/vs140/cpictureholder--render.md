---
title: "CPictureHolder::Render"
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
  - "Render"
  - "CPictureHolder.Render"
  - "CPictureHolder::Render"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Render method"
ms.assetid: f1af1863-72bf-4020-ac45-a15f0eb61fe0
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPictureHolder::Render
Renders the picture in the rectangle referenced by `rcRender`.  
  
## Syntax  
  
```  
  
      void Render(  
   CDC* pDC,  
   const CRect& rcRender,  
   const CRect& rcWBounds   
);  
```  
  
#### Parameters  
 `pDC`  
 Pointer to the display context in which the picture is to be rendered.  
  
 `rcRender`  
 Rectangle in which the picture is to be rendered.  
  
 *rcWBounds*  
 A rectangle representing the bounding rectangle of the object rendering the picture. For a control, this rectangle is the `rcBounds` parameter passed to an override of [COleControl::OnDraw](../vs140/colecontrol--ondraw.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CPictureHolder Class](../vs140/cpictureholder-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)