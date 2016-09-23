---
title: "CListBox::GetHorizontalExtent"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - GetHorizontalExtent
  - CListBox::GetHorizontalExtent
  - CListBox.GetHorizontalExtent
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetHorizontalExtent method
  - CListBox class, general operations
ms.assetid: 47d50ef1-9e16-453b-9e8c-87e6a4df1000
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CListBox::GetHorizontalExtent
Retrieves from the list box the width in pixels by which it can be scrolled horizontally.  
  
## Syntax  
  
```  
  
int GetHorizontalExtent( ) const;  
```  
  
## Return Value  
 The scrollable width of the list box, in pixels.  
  
## Remarks  
 This is applicable only if the list box has a horizontal scroll bar.  
  
## Example  
 [!code[NVC_MFC_CListBox#14](../vs140/codesnippet/CPP/clistbox--gethorizontalextent_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::SetHorizontalExtent](../vs140/clistbox--sethorizontalextent.md)   
 [LB_GETHORIZONTALEXTENT](http://msdn.microsoft.com/library/windows/desktop/bb775200)