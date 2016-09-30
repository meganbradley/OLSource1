---
title: "CMFCVisualManager::OnFillRibbonMenuFrame"
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
  - "OnFillRibbonMenuFrame"
  - "CMFCVisualManager::OnFillRibbonMenuFrame"
  - "CMFCVisualManager.OnFillRibbonMenuFrame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFillRibbonMenuFrame method"
ms.assetid: 6853be03-f6e0-4c46-8710-ce708f78869c
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnFillRibbonMenuFrame
The framework calls this method when it fills the menu frame of the ribbon panel.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to an instance of the [CMFCRibbonMainPanel Class](../vs140/cmfcribbonmainpanel-class.md). The framework fills the menu frame for this ribbon panel.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the menu frame.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of the menu bar for the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCRibbonMainPanel Class](../vs140/cmfcribbonmainpanel-class.md)