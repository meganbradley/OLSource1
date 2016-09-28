---
title: "COleServerDoc::RequestPositionChange"
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
  - "COleServerDoc.RequestPositionChange"
  - "COleServerDoc::RequestPositionChange"
  - "RequestPositionChange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RequestPositionChange method"
  - "COleServerDoc class, operations"
ms.assetid: 98552214-7e75-41b0-9204-493edcc05909
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerDoc::RequestPositionChange
Call this member function to have the container application change the item's position.  
  
## Syntax  
  
```  
  
      void RequestPositionChange(  
   LPCRECT lpPosRect   
);  
```  
  
#### Parameters  
 `lpPosRect`  
 Pointer to a `RECT` structure or a `CRect` object containing the item's new position.  
  
## Remarks  
 This function is usually called (in conjunction with `UpdateAllItems`) when the data in an in-place active item has changed. Following this call, the container might or might not perform the change by calling `OnSetItemRects`. The resulting position might be different from the one requested.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerDoc::ScrollContainerBy](../vs140/coleserverdoc--scrollcontainerby.md)