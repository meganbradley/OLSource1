---
title: "CHtmlView::OnToolBar"
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
  - "CHtmlView.OnToolBar"
  - "CHtmlView::OnToolBar"
  - "OnToolBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnToolBar method"
  - "CHtmlView class, events"
ms.assetid: 6a0cf6a2-cc30-4879-b9b0-0ce56e4eb348
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHtmlView::OnToolBar
This member function is called by the framework when the [ToolBar](https://msdn.microsoft.com/en-us/library/aa768274.aspx) property has changed.  
  
## Syntax  
  
```  
  
      virtual void OnToolBar(  
   BOOL bToolBar   
);  
```  
  
#### Parameters  
 *bToolBar*  
 Nonzero if Internet Explorer's toolbar is visible or zero otherwise.  
  
## Requirements  
 **Header:** afxhtml.h  
  
## See Also  
 [CHtmlView Class](../vs140/chtmlview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CHtmlView::GetToolBar](../vs140/chtmlview--gettoolbar.md)   
 [CHtmlView::SetToolBar](../vs140/chtmlview--settoolbar.md)   
 [DWebBrowserEvents2::OnToolBar](https://msdn.microsoft.com/en-us/library/aa768293.aspx)