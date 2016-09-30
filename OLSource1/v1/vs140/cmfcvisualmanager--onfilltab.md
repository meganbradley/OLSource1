---
title: "CMFCVisualManager::OnFillTab"
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
  - "CMFCVisualManager.OnFillTab"
  - "OnFillTab"
  - "CMFCVisualManager::OnFillTab"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFillTab method"
ms.assetid: da896cc0-fc00-495e-89b8-323b3fb0026d
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnFillTab
The framework calls this method when it fills the background of a tab window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries for the tab window.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to a brush. The framework uses this brush to fill the tab window.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The zero-based tab index of a tab for which the framework fills the background.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the tab is active; otherwise <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A pointer to the parent tab control.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of tabs.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)