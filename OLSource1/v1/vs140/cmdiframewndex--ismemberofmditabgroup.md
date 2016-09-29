---
title: "CMDIFrameWndEx::IsMemberOfMDITabGroup"
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
  - "CMDIFrameWndEx::IsMemberOfMDITabGroup"
  - "IsMemberOfMDITabGroup"
  - "CMDIFrameWndEx.IsMemberOfMDITabGroup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsMemberOfMDITabGroup method"
ms.assetid: 74ad9758-da96-4598-9ae6-eb692a35594f
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::IsMemberOfMDITabGroup
Determines whether the specified tabbed window is in the list of windows that are in MDI Tabbed Groups.  
  
## Syntax  
  
```  
BOOL IsMemberOfMDITabGroup(  
   CWnd* pWnd   
);  
```  
  
#### Parameters  
 [in] `pWnd`  
 A pointer to tabbed window.  
  
## Return Value  
 `TRUE` if the specified tabbed window is in the list of tabbed windows that form MDI Tabbed Groups. Otherwise `FALSE`.  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)