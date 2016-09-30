---
title: "CMFCVisualManager::OnDrawRibbonMainPanelButtonBorder"
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
  - "OnDrawRibbonMainPanelButtonBorder"
  - "CMFCVisualManager.OnDrawRibbonMainPanelButtonBorder"
  - "CMFCVisualManager::OnDrawRibbonMainPanelButtonBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawRibbonMainPanelButtonBorder method"
ms.assetid: aabf1155-8f6e-45fe-88fd-85e4cd11668d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawRibbonMainPanelButtonBorder
The framework calls this method when it draws the border of a [CMFCRibbonButton](../vs140/cmfcribbonbutton-class.md) that is positioned on the **Main** panel.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> located on the main panel of the ribbon. The framework draws the border for this button.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of the border for a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> on the **Main** panel.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCRibbonButton Class](../vs140/cmfcribbonbutton-class.md)