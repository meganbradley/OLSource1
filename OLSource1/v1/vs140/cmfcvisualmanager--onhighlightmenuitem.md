---
title: "CMFCVisualManager::OnHighlightMenuItem"
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
  - "CMFCVisualManager.OnHighlightMenuItem"
  - "OnHighlightMenuItem"
  - "CMFCVisualManager::OnHighlightMenuItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnHighlightMenuItem method"
ms.assetid: be523e00-6335-4bf8-a60a-2414acb50701
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManager::OnHighlightMenuItem
The framework calls this method when it draws a highlighted menu item.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the device context for a menu.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a [CMFCToolBarMenuButton](../vs140/cmfctoolbarmenubutton-class.md) object to display. The default implementation does not use this parameter.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A rectangle that specifies the boundaries of the menu item.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The current text color of highlighted menu items. The default implementation does not use this parameter.  
  
## Remarks  
 The default implementation of this method does not use the parameters <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. It fills the rectangle specified by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> with the standard background color.  
  
 Override this method in a derived visual manager to customize the appearance of highlighted menu items. Use the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter to modify the text color of a highlighted menu item.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCVisualManager Class](../vs140/cmfcvisualmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)