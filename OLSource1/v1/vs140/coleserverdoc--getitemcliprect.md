---
title: "COleServerDoc::GetItemClipRect"
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
  - "COleServerDoc.GetItemClipRect"
  - "GetItemClipRect"
  - "COleServerDoc::GetItemClipRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleServerDoc class, attributes"
  - "GetItemClipRect method"
ms.assetid: 14bf50d1-0441-4649-b21f-56a3423ea50d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerDoc::GetItemClipRect
Call the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function to get the clipping-rectangle coordinates of the item that is being edited in place.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure or a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object to receive the clipping-rectangle coordinates of the item.  
  
## Remarks  
 Coordinates are in pixels relative to the container application window's client area.  
  
 Drawing should not occur outside the clipping rectangle. Usually, drawing is automatically restricted. Use this function to determine whether the user has scrolled outside the visible portion of the document; if so, scroll the container document as needed by means of a call to [ScrollContainerBy](../vs140/coleserverdoc--scrollcontainerby.md).  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerDoc::GetItemPosition](../vs140/coleserverdoc--getitemposition.md)   
 [COleServerDoc::ScrollContainerBy](../vs140/coleserverdoc--scrollcontainerby.md)