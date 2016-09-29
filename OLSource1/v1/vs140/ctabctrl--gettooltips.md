---
title: "CTabCtrl::GetToolTips"
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
  - "CTabCtrl::GetToolTips"
  - "CTabCtrl.GetToolTips"
  - "GetToolTips"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetToolTips method"
ms.assetid: ea2fc9b2-1195-4e61-8c44-8cffa0b3c0e4
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabCtrl::GetToolTips
Retrieves the handle of the tool tip control associated with a tab control.  
  
## Syntax  
  
```  
  
CToolTipCtrl* GetToolTips( ) const;  
```  
  
## Return Value  
 Handle of the tool tip control if successful; otherwise **NULL**.  
  
## Remarks  
 A tab control creates a tool tip control if it has the **TCS_TOOLTIPS** style. You can also assign a tool tip control to a tab control by using the `SetToolTips` member function.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTabCtrl Class](../vs140/ctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTabCtrl::SetToolTips](../vs140/ctabctrl--settooltips.md)   
 [CTabCtrl::Create](../vs140/ctabctrl--create.md)