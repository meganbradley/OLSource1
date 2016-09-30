---
title: "CMFCVisualManager::OnFillOutlookBarCaption"
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
  - "OnFillOutlookBarCaption"
  - "CMFCVisualManager.OnFillOutlookBarCaption"
  - "CMFCVisualManager::OnFillOutlookBarCaption"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFillOutlookBarCaption method"
ms.assetid: b16b18c0-6987-4890-83af-d1fb0d556d98
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnFillOutlookBarCaption
The framework calls this method when it fills the background of an Outlook caption bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the caption bar.  
  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A reference to a [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter. The method writes the color of text on the caption bar to this parameter.  
  
## Remarks  
 The default implementation of this method fills the caption bar with the color for shadows based on the current skin. Override this method in a derived visual manager to customize the color of the Outlook caption bar.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)