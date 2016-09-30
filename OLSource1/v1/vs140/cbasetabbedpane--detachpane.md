---
title: "CBaseTabbedPane::DetachPane"
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
  - "CBaseTabbedPane.DetachPane"
  - "DetachPane"
  - "CBaseTabbedPane::DetachPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DetachPane method"
ms.assetid: 017ab162-9be1-4eae-a530-2e03d753f9b3
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBaseTabbedPane::DetachPane
Detaches a pane from the tabbed pane.  
  
## Syntax  
  
```  
virtual BOOL DetachPane(  
   CWnd* pBar,  
   BOOL bHide = FALSE  
);  
```  
  
#### Parameters  
 [in] `pBar`  
 Pointer to the pane to detach.  
  
 [in] `bHide`  
 Boolean parameter that specifies whether the framework hides the pane after it is detached.  
  
## Return Value  
 `TRUE` if the framework successfully detaches the pane; `FALSE` if `pBar` is `NULL` or refers to a pane that is not in the tabbed pane.  
  
## Remarks  
 The framework floats the detached pane if possible. For more information, see [CBasePane::CanFloat](../vs140/cbasepane--canfloat.md).  
  
## Requirements  
 **Header:** afxbasetabbedpane.h  
  
## See Also  
 [CBaseTabbedPane Class](../vs140/cbasetabbedpane-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)