---
title: "COleServerDoc::DiscardUndoState"
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
  - "DiscardUndoState"
  - "COleServerDoc.DiscardUndoState"
  - "COleServerDoc::DiscardUndoState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DiscardUndoState method"
  - "COleServerDoc class, operations"
ms.assetid: 4aded824-fc2c-4e12-a23f-b4c202244df5
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerDoc::DiscardUndoState
If the user performs an editing operation that cannot be undone, call this function to force the container application to discard its undo-state information.  
  
## Syntax  
  
```  
  
BOOL DiscardUndoState( );  
```  
  
## Return Value  
 Nonzero on success; otherwise 0.  
  
## Remarks  
 This function is provided so that servers that support Undo can free resources that would otherwise be consumed by undo-state information that cannot be used.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerDoc Class](../vs140/coleserverdoc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleServerDoc::OnReactivateAndUndo](../vs140/coleserverdoc--onreactivateandundo.md)