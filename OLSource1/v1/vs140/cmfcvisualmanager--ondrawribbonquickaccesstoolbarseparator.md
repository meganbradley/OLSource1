---
title: "CMFCVisualManager::OnDrawRibbonQuickAccessToolBarSeparator"
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
  - "CMFCVisualManager.OnDrawRibbonQuickAccessToolBarSeparator"
  - "OnDrawRibbonQuickAccessToolBarSeparator"
  - "CMFCVisualManager::OnDrawRibbonQuickAccessToolBarSeparator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawRibbonQuickAccessToolBarSeparator method"
ms.assetid: 8bb0f823-8285-48f9-8f15-6773707d3419
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawRibbonQuickAccessToolBarSeparator
The framework calls this method when it draws a separator on the **Quick Access Toolbar** of a ribbon.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a [CMFCRibbonSeparator](../vs140/cmfcribbonseparator-class.md) object. The framework draws this ribbon separator.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the separator.  
  
## Remarks  
 Override this method in a derived class to customize the appearance of ribbon separators on the **Quick Access Toolbar**.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCRibbonSeparator Class](../vs140/cmfcribbonseparator-class.md)