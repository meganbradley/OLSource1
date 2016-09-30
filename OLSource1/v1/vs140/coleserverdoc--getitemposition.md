---
title: "COleServerDoc::GetItemPosition"
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
  - "COleServerDoc.GetItemPosition"
  - "COleServerDoc::GetItemPosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerDoc class, attributes"
  - "GetItemPosition method"
ms.assetid: d7bddf7d-ec7a-4bb3-b4f8-d7eeb3306ef9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerDoc::GetItemPosition
Call the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function to get the coordinates of the item being edited in place.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure or a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object to receive the coordinates of the item.  
  
## Remarks  
 Coordinates are in pixels relative to the container application window's client area.  
  
 The item's position can be compared with the current clipping rectangle to determine the extent to which the item is visible (or not visible) on the screen.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerDoc::GetItemClipRect](../vs140/coleserverdoc--getitemcliprect.md)