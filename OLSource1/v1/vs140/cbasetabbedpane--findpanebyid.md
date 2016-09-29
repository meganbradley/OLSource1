---
title: "CBaseTabbedPane::FindPaneByID"
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
  - "FindPaneByID"
  - "CBaseTabbedPane.FindPaneByID"
  - "CBaseTabbedPane::FindPaneByID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FindPaneByID method"
ms.assetid: b62fb73c-ee44-4501-be91-162db24c44af
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBaseTabbedPane::FindPaneByID
Returns a pane identified by the pane ID.  
  
## Syntax  
  
```  
virtual CWnd* FindPaneByID(  
    UINT uBarID   
);  
```  
  
#### Parameters  
 [in] `uBarID`  
 Specifies the ID of the pane to find.  
  
## Return Value  
 A pointer to the pane if it was found; otherwise, `NULL`.  
  
## Remarks  
 This method compares all tabs in the pane and returns the one with the ID specified by the `uBarID` parameter.  
  
## Requirements  
 **Header:** afxBaseTabbedPane.h  
  
## See Also  
 [CBaseTabbedPane Class](../vs140/cbasetabbedpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)