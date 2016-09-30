---
title: "CMFCPopupMenu::InsertSeparator"
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
  - "CMFCPopupMenu::InsertSeparator"
  - "InsertSeparator"
  - "CMFCPopupMenu.InsertSeparator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsertSeparator method"
ms.assetid: c70c95bb-e7be-45c5-a7f1-096fdb1cd47c
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPopupMenu::InsertSeparator
Inserts a separator into the pop-up menu at the specified location.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The zero-based index of the position where this method will insert the separator.  
  
## Return Value  
 The zero-based index of the position where the separator was inserted. -1 if this method fails.  
  
## Remarks  
 A value of -1 for <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> means this method will add the separator to the end of the pop-up menu.  
  
 This method fails if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is an invalid value.  
  
## Requirements  
 **Header:** afxpopupmenu.h  
  
## See Also  
 [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)