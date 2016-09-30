---
title: "CFrameWndEx::GetToolbarButtonToolTipText"
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
  - "CFrameWndEx.GetToolbarButtonToolTipText"
  - "CFrameWndEx::GetToolbarButtonToolTipText"
  - "GetToolbarButtonToolTipText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetToolbarButtonToolTipText method"
ms.assetid: 44eb7c97-9d39-48b2-930e-e7d32a120035
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::GetToolbarButtonToolTipText
Called by the framework when the application displays the tooltip for a toolbar button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a toolbar button.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The tooltip text to display for the button.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the tooltip has been displayed. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> otherwise.  
  
## Remarks  
 By default, this method does nothing. Override this method if you want to display the tooltip for the toolbar button.  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)