---
title: "CMFCVisualManager::OnDrawRibbonCaption"
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
  - "CMFCVisualManager::OnDrawRibbonCaption"
  - "CMFCVisualManager.OnDrawRibbonCaption"
  - "OnDrawRibbonCaption"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawRibbonCaption method"
ms.assetid: 2fd87287-8d95-4f9f-8ddb-baef41dbd582
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawRibbonCaption
The framework calls this method when it draws the caption bar of the main frame window. The framework calls this method only if the ribbon is integrated with the main frame.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a ribbon bar. The visual manager draws this ribbon bar.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the ribbon bar.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries for the text of the caption bar.  
  
## Remarks  
 Override this function in a derived visual manager to customize the appearance of the caption bar. This method affects the caption bar only if the ribbon is integrated with the main frame window.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)