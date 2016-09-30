---
title: "CMFCOutlookBar::AllowDestroyEmptyTabbedPane"
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
  - "CMFCOutlookBar.AllowDestroyEmptyTabbedPane"
  - "AllowDestroyEmptyTabbedPane"
  - "CMFCOutlookBar::AllowDestroyEmptyTabbedPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AllowDestroyEmptyTabbedPane method"
ms.assetid: 9d6808a8-6c41-4dad-ab3d-28353fb07d70
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCOutlookBar::AllowDestroyEmptyTabbedPane
Specifies whether an empty tabbed pane can be destroyed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if an empty tabbed pane can be destroyed; otherwise, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. The default implementation always returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 If an empty tabbed pane cannot be destroyed, the framework hides it instead.  
  
## Requirements  
 **Header:** afxoutlookbar.h  
  
## See Also  
 [CMFCOutlookBar Class](../vs140/cmfcoutlookbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)