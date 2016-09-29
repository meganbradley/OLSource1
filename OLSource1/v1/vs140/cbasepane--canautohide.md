---
title: "CBasePane::CanAutoHide"
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
  - "CanAutoHide"
  - "CBasePane.CanAutoHide"
  - "CBasePane::CanAutoHide"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanAutoHide method"
ms.assetid: 20fb379c-b345-4712-8a3b-29037d4c5417
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::CanAutoHide
Determines whether the pane supports auto-hide mode.  
  
## Syntax  
  
```  
virtual BOOL CanAutoHide() const;  
```  
  
## Return Value  
 `TRUE` if this pane supports auto-hide mode; otherwise `FALSE`.  
  
## Remarks  
 The framework calls this function to determine whether the pane supports auto-hide mode.  
  
 During construction, you can set this ability by passing the `AFX_CBRS_AUTOHIDE` flag to [CBasePane::CreateEx](../vs140/cbasepane--createex.md).  
  
 The default implementation checks for the `AFX_CBRS_AUTOHIDE` flag. Override this method in a derived class to customize this behavior.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)