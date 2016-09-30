---
title: "CMFCVisualManager::OnDrawRibbonPanelCaption"
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
  - "OnDrawRibbonPanelCaption"
  - "CMFCVisualManager.OnDrawRibbonPanelCaption"
  - "CMFCVisualManager::OnDrawRibbonPanelCaption"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawRibbonPanelCaption method"
ms.assetid: 35808047-27b1-4340-9467-082bb2c2af17
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawRibbonPanelCaption
The framework calls this method when it draws the caption of a [CMFCRibbonPanel Class](../vs140/cmfcribbonpanel-class.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object. The framework draws the caption for this ribbon panel.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the caption for the ribbon panel.  
  
## Remarks  
 Override this method in a derived class to customize the appearance of captions for ribbon panels.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCRibbonPanel Class](../vs140/cmfcribbonpanel-class.md)