---
title: "CMFCColorBar::SetDocumentColors"
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
  - "SetDocumentColors"
  - "CMFCColorBar::SetDocumentColors"
  - "CMFCColorBar.SetDocumentColors"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDocumentColors method"
ms.assetid: 34a3895e-009c-47ca-9d6c-2282e1f49cb8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorBar::SetDocumentColors
Sets the list of colors that are used in the current document.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A caption that is displayed when the color bar control is not docked.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A list of colors that replaces the current document colors.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to show document colors when the color bar control is docked; otherwise, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 *Document colors* are the colors that are currently used in a document. The framework automatically maintains a list of document colors, but you can use this method to modify the list.  
  
## Requirements  
 **Header:** afxcolorbar.h  
  
## See Also  
 [CMFCColorBar Class](../vs140/cmfccolorbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)