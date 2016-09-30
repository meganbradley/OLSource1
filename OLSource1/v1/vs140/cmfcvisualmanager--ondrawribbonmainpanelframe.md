---
title: "CMFCVisualManager::OnDrawRibbonMainPanelFrame"
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
  - "CMFCVisualManager::OnDrawRibbonMainPanelFrame"
  - "OnDrawRibbonMainPanelFrame"
  - "CMFCVisualManager.OnDrawRibbonMainPanelFrame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawRibbonMainPanelFrame method"
ms.assetid: d56fc51c-9648-4731-b652-cf0078434872
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawRibbonMainPanelFrame
The framework calls this method when it draws the frame around the [CMFCRibbonMainPanel](../vs140/cmfcribbonmainpanel-class.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 Override this method in a derived visual manager to customize the appearance of the frame for the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCRibbonMainPanel Class](../vs140/cmfcribbonmainpanel-class.md)