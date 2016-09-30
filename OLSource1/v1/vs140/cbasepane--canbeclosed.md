---
title: "CBasePane::CanBeClosed"
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
  - "CanBeClosed"
  - "CBasePane.CanBeClosed"
  - "CBasePane::CanBeClosed"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanBeClosed method"
ms.assetid: 46ebddc3-13e7-4ab0-8a2a-9de9f3c6351f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::CanBeClosed
Determines whether the pane can be closed.  
  
## Syntax  
  
```  
virtual BOOL CanBeClosed() const;  
```  
  
## Return Value  
 `TRUE` if the pane can be closed; otherwise `FALSE`.  
  
## Remarks  
 The framework calls this method to determine whether the pane can be closed. If the method returns `TRUE`, a **Close** button is added to the pane's title bar or, if the pane is floating, to the title bar of the pane's miniframe window.  
  
 During construction, you can set this ability by passing the `AFX_CBRS_CLOSE` flag to [CBasePane::CreateEx](../vs140/cbasepane--createex.md).  
  
 The default implementation checks for the `AFX_CBRS_CLOSE` flag.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)