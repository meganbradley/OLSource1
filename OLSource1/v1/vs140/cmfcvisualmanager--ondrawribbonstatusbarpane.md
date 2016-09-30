---
title: "CMFCVisualManager::OnDrawRibbonStatusBarPane"
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
  - "CMFCVisualManager::OnDrawRibbonStatusBarPane"
  - "CMFCVisualManager.OnDrawRibbonStatusBarPane"
  - "OnDrawRibbonStatusBarPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawRibbonStatusBarPane method"
ms.assetid: fae3a8d3-9151-4ffd-a5a4-eb92373aaae9
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawRibbonStatusBarPane
The framework calls this method when it draws a pane on the status bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the status bar that contains the pane.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to a status bar pane. The framework draws this [CMFCRibbonStatusBarPane](../vs140/cmfcribbonstatusbarpane-class.md) object.  
  
## Return Value  
 A reserved value. The default implementation returns -1.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of a pane on the status bar.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCRibbonStatusBarPane Class](../vs140/cmfcribbonstatusbarpane-class.md)