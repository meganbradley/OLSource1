---
title: "CMFCVisualManager::OnDrawRibbonApplicationButton"
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
  - "OnDrawRibbonApplicationButton"
  - "CMFCVisualManager::OnDrawRibbonApplicationButton"
  - "CMFCVisualManager.OnDrawRibbonApplicationButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawRibbonApplicationButton method"
ms.assetid: a2fdafe9-07de-466a-9988-722610703254
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawRibbonApplicationButton
The framework calls this method when it draws the **Main Button** on the ribbon.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the **Main Button** on the ribbon.  
  
## Remarks  
 Override this method in a derived visual manager if you want to customize the appearance of the **Main Button**.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCRibbonButton Class](../vs140/cmfcribbonbutton-class.md)