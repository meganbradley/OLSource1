---
title: "CBaseTabbedPane::ConvertToTabbedDocument"
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
  - "CBaseTabbedPane.ConvertToTabbedDocument"
  - "CBaseTabbedPane::ConvertToTabbedDocument"
  - "ConvertToTabbedDocument"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ConvertToTabbedDocument method"
ms.assetid: fe8024c9-13c1-4355-89b6-46c2d019a064
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBaseTabbedPane::ConvertToTabbedDocument
Converts one or more dockable panes to MDI tabbed documents.  
  
## Syntax  
  
```  
virtual void ConvertToTabbedDocument(  
   BOOL bActiveTabOnly = TRUE  
);  
```  
  
#### Parameters  
 [in] `bActiveTabOnly`  
 When you convert a tabbed pane, specify `TRUE` to convert only the active tab. Specify `FALSE` to convert all tabs in the pane.  
  
## Requirements  
 **Header:** afxbasetabbedpane.h  
  
## See Also  
 [CBaseTabbedPane Class](../vs140/cbasetabbedpane-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)