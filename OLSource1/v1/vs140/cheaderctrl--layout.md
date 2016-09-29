---
title: "CHeaderCtrl::Layout"
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
  - "HD_LAYOUT"
  - "Layout"
  - "CHeaderCtrl::Layout"
  - "CHeaderCtrl.Layout"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Layout method"
  - "HD_LAYOUT"
ms.assetid: 33971346-9ed1-4b3a-8eba-57b24547f224
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeaderCtrl::Layout
Retrieves the size and position of a header control within a given rectangle.  
  
## Syntax  
  
```  
  
      BOOL Layout(  
   HDLAYOUT* pHeaderLayout   
);  
```  
  
#### Parameters  
 *pHeaderLayout*  
 Pointer to an [HDLAYOUT](http://msdn.microsoft.com/library/windows/desktop/bb775249) structure, which contains information used to set the size and position of a header control.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This function is used to determine the appropriate dimensions for a new header control that is to occupy the given rectangle.  
  
## Example  
 [!code[NVC_MFC_CHeaderCtrl#13](../vs140/codesnippet/CPP/cheaderctrl--layout_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CHeaderCtrl Class](../vs140/cheaderctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)