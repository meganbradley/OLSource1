---
title: "CControlBar::IsFloating"
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
  - "CControlBar.IsFloating"
  - "IsFloating"
  - "CControlBar::IsFloating"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CControlBar class, attributes"
  - "IsFloating method"
ms.assetid: ca5a2b35-9a68-4bea-8cf3-9b655c0d47b1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CControlBar::IsFloating
Call this member function to determine whether the control bar is floating or docked.  
  
## Syntax  
  
```  
  
BOOL IsFloating( ) const;  
  
```  
  
## Return Value  
 Nonzero if the control bar is floating; otherwise 0.  
  
## Remarks  
 To change the state of a control bar from docked to floating, call [CFrameWnd::FloatControlBar](../vs140/cframewnd--floatcontrolbar.md).  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CControlBar Class](../vs140/ccontrolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFrameWnd::FloatControlBar](../vs140/cframewnd--floatcontrolbar.md)