---
title: "CMFCVisualManager::OnFillRibbonButton"
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
  - "CMFCVisualManager::OnFillRibbonButton"
  - "OnFillRibbonButton"
  - "CMFCVisualManager.OnFillRibbonButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFillRibbonButton method"
ms.assetid: 24340ab0-9008-41c3-9c1b-67f218f84cde
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnFillRibbonButton
The framework calls this method when it fills the interior of a ribbon button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a [CMFCRibbonButton](../vs140/cmfcribbonbutton-class.md) object. The framework fills the interior of this ribbon button.  
  
## Return Value  
 The color of text for the ribbon button specified by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the ribbon button supports text. A value of -1 if text is invalid for the ribbon button.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of ribbon buttons.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCRibbonButton Class](../vs140/cmfcribbonbutton-class.md)