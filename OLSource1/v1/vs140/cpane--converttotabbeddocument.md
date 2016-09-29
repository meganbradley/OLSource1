---
title: "CPane::ConvertToTabbedDocument"
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
  - "CPane.ConvertToTabbedDocument"
  - "CPane::ConvertToTabbedDocument"
  - "ConvertToTabbedDocument"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ConvertToTabbedDocument method"
ms.assetid: ff147b58-8b5b-4036-bdae-277b638e4dfd
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::ConvertToTabbedDocument
Converts a dockable pane to a tabbed document.  
  
## Syntax  
  
```  
virtual void ConvertToTabbedDocument(  
   BOOL bActiveTabOnly = TRUE  
);  
```  
  
#### Parameters  
 [in] `bActiveTabOnly`  
 Not used in `CPane::ConvertToTabbedDocument`.  
  
## Remarks  
 Only dockable panes can be converted to tabbed documents. For information, see [CDockablePane::ConvertToTabbedDocument](../vs140/cdockablepane--converttotabbeddocument.md).  
  
## Requirements  
 **Header:** afxpane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)