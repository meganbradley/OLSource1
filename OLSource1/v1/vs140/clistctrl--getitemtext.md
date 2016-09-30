---
title: "CListCtrl::GetItemText"
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
  - "CListCtrl::GetItemText"
  - "CListCtrl.GetItemText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemText method"
ms.assetid: aaed3d21-e715-4152-ad32-e465c93784ef
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetItemText
Retrieves the text of a list view item or subitem.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The index of the item whose text is to be retrieved.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the subitem whose text is to be retrieved.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to a string that is to receive the item text.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Length of the buffer pointed to by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Return Value  
 The version returning <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> returns the length of the retrieved string.  
  
 The version returning a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> returns the item text.  
  
## Remarks  
 If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is zero, this function retrieves the item label; if <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is nonzero, it retrieves the text of the subitem. For more information on the subitem argument, see the discussion of the [LVITEM](http://msdn.microsoft.com/library/windows/desktop/bb774760) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::GetItem](../vs140/clistctrl--getitem.md)