---
title: "CMFCVisualManager::OnDrawTearOffCaption"
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
  - "CMFCVisualManager.OnDrawTearOffCaption"
  - "CMFCVisualManager::OnDrawTearOffCaption"
  - "OnDrawTearOffCaption"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawTearOffCaption method"
ms.assetid: 429f9af3-9579-4cab-a81e-f8fc121e2f94
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnDrawTearOffCaption
The framework calls this method when it draws the caption for a [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the caption.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the caption is active; <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> otherwise.  
  
## Remarks  
 This function is called by the framework when a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object processes a WM_PAINT message and must draw a tear-off caption.  
  
 Override this method in a derived class to customize the look of captions for tear-off bars.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md)