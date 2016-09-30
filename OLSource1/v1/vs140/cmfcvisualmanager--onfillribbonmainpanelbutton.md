---
title: "CMFCVisualManager::OnFillRibbonMainPanelButton"
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
  - "CMFCVisualManager::OnFillRibbonMainPanelButton"
  - "CMFCVisualManager.OnFillRibbonMainPanelButton"
  - "OnFillRibbonMainPanelButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFillRibbonMainPanelButton method"
ms.assetid: 83ec1698-e46c-4cb4-82b1-808c3ea25e2b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnFillRibbonMainPanelButton
The framework calls this method when it fills the interior of a ribbon button located on the **Main** panel.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a [CMFCRibbonButton Class](../vs140/cmfcribbonbutton-class.md) object. The framework fills this ribbon button.  
  
## Return Value  
 The color of text for the ribbon button specified by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the ribbon button supports text. A value of -1 if text is invalid for the ribbon button.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of ribbon buttons on the **Main** panel.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCRibbonButton Class](../vs140/cmfcribbonbutton-class.md)