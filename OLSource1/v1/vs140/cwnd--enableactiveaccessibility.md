---
title: "CWnd::EnableActiveAccessibility"
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
  - "CWnd::EnableActiveAccessibility"
  - "CWnd.EnableActiveAccessibility"
  - "EnableActiveAccessibility"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableActiveAccessibility method"
ms.assetid: 2e843130-c796-4d90-95c6-c8726eb6b31e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::EnableActiveAccessibility
Enables user-defined Active Accessibility functions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 MFC's default Active Accessibility support is sufficient for standard windows and controls, including ActiveX controls; however, if your <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>-derived class contains nonwindowed user interface elements, MFC has no way of knowing about them. In that case, you must override the appropriate [Active Accessibility member functions](assetId:///68af04ac-4eb9-4b7d-b33f-c45512097a74) in your class, and you must call **EnableActiveAccessibility** in the class's constructor.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)