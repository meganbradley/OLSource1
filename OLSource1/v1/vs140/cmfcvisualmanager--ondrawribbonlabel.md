---
title: "CMFCVisualManager::OnDrawRibbonLabel"
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
  - "OnDrawRibbonLabel"
  - "CMFCVisualManager.OnDrawRibbonLabel"
  - "CMFCVisualManager::OnDrawRibbonLabel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawRibbonLabel method"
ms.assetid: 737a1979-cc94-4a28-8d02-51278382f5c4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawRibbonLabel
The framework calls this method when it draws the label of the ribbon.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a [CMFCRibbonLabel](../vs140/cmfcribbonlabel-class.md) object. The framework draws this ribbon label.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the ribbon panel.  
  
## Remarks  
 Override this method in a derived class to customize the ribbon label.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCRibbonLabel Class](../vs140/cmfcribbonlabel-class.md)