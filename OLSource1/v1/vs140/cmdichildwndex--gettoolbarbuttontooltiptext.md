---
title: "CMDIChildWndEx::GetToolbarButtonToolTipText"
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
  - "CMDIChildWndEx::GetToolbarButtonToolTipText"
  - "CMDIChildWndEx.GetToolbarButtonToolTipText"
  - "GetToolbarButtonToolTipText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetToolbarButtonToolTipText method"
ms.assetid: 2d4df43a-1e20-45e7-be8b-ab11604d2ce7
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIChildWndEx::GetToolbarButtonToolTipText
Called by the framework to retrieve a tooltip for a toolbar button.  
  
## Syntax  
  
```  
virtual BOOL GetToolbarButtonToolTipText(  
   CMFCToolBarButton* ,  
   CString&    
);  
```  
  
## Return Value  
 `TRUE` if the tooltip has been displayed. The default implementation returns `FALSE`.  
  
## Remarks  
 Override this method if you want to display custom tool tips for toolbar buttons.  
  
## Requirements  
 **Header:** afxMDIChildWndEx.h  
  
## See Also  
 [CMDIChildWndEx Class](../vs140/cmdichildwndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)