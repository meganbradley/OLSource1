---
title: "CMFCVisualManager::OnDrawSeparator"
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
  - "OnDrawSeparator"
  - "CMFCVisualManager::OnDrawSeparator"
  - "CMFCVisualManager.OnDrawSeparator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawSeparator method"
ms.assetid: c937afc9-a6fb-4584-955a-54b95d14f263
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawSeparator
The framework calls this method when it draws a separator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the device context for a control bar.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a pane that contains the separator.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the separator.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates the orientation of a docked pane. A value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> indicates that the pane is docked horizontally. A value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> indicates that the pane is docked vertically.  
  
## Remarks  
 Separators are used on control bars to separate groups of related icons. The default implementation for this method displays the standard separator. Override this method in a derived visual manager to customize the appearance of the separator.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)