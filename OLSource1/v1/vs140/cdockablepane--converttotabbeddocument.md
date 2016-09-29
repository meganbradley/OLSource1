---
title: "CDockablePane::ConvertToTabbedDocument"
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
  - "CDockablePane.ConvertToTabbedDocument"
  - "ConvertToTabbedDocument"
  - "CDockablePane::ConvertToTabbedDocument"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ConvertToTabbedDocument method"
ms.assetid: 75329d30-a003-4779-995f-4d239ebc67cd
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::ConvertToTabbedDocument
Converts one or more dockable panes to MDI tabbed documents.  
  
## Syntax  
  
```  
virtual void ConvertToTabbedDocument(  
   BOOL bActiveTabOnly = TRUE  
);  
```  
  
#### Parameters  
 [in] `bActiveTabOnly`  
 When you convert a `CTabbedPane`, specify `TRUE` to convert only the active tab. Specify `FALSE` to convert all tabs in the pane.  
  
## Requirements  
 **Header:** afxdockablepane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)