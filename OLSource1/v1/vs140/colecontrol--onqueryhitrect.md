---
title: "COleControl::OnQueryHitRect"
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
  - "COleControl.OnQueryHitRect"
  - "COleControl::OnQueryHitRect"
  - "OnQueryHitRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnQueryHitRect method"
ms.assetid: 7c638d1e-96a4-40a4-9c2c-8d976a9439f2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnQueryHitRect
Called by the framework in response to a container's **IViewObjectEx::QueryHitRect** request.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies how the object is to be represented. Valid values are taken from the enumeration [DVASPECT](http://msdn.microsoft.com/library/windows/desktop/ms690318) or **DVASPECT2**.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure specifying the bounding rectangle of the OLE control client area.  
  
 *prcLoc*  
 Pointer to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure specifying the rectangle to be checked for a hit (overlap with the object rectangle), relative to the upper left corner of the object.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Not used.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to the result of the hit query. One of the following values:  
  
-   **HITRESULT_OUTSIDE** no point in the rectangle is hit by the OLE object.  
  
-   **HITRESULT_HIT** at least one point in the rectangle would be a hit on the object.  
  
## Return Value  
 Nonzero if a hit result is successfully returned; otherwise 0.  
  
## Remarks  
 Queries whether an object's display rectangle overlaps any point in the given rectangle (hits the rectangle). <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> can be overridden to test hits for non-rectangular objects.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::OnQueryHitPoint](../vs140/colecontrol--onqueryhitpoint.md)