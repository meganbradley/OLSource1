---
title: "CPane::GetPaneName"
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
  - "CPane.GetPaneName"
  - "GetPaneName"
  - "CPane::GetPaneName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPaneName method"
ms.assetid: 24905d06-1c9d-4849-aae8-3fcff2a247cd
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::GetPaneName
Retrieves the title for the pane.  
  
## Syntax  
  
```  
virtual void GetPaneName(  
   CString& strName  
) const;  
```  
  
#### Parameters  
 [out] `strName`  
 A `CString` object that is filled with the caption name.  
  
## Remarks  
 The pane title is displayed in the caption area when the pane is docked or floating. If the pane is part of a tabbed group, the title is displayed in the tab area. If the pane is in auto-hide mode, the title is displayed on a `CMFCAutoHideButton`.  
  
## Requirements  
 **Header:** afxpane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)