---
title: "CMFCToolBar::SetPermament"
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
  - "SetPermament"
  - "CMFCToolBar::SetPermament"
  - "CMFCToolBar.SetPermament"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetPermament method"
ms.assetid: 715dfe73-efb1-46cd-bc5f-82815709569c
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::SetPermament
Specifies whether a user can close the toolbar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A Boolean value that specifies whether a user can close the toolbar. If this parameter is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, a user cannot close the toolbar. Otherwise, a user can close the toolbar.  
  
## Remarks  
 By default, a user can close each toolbar.  
  
 Call the [CMFCToolBar::CanBeClosed](../vs140/cmfctoolbar--canbeclosed.md) method to determine whether a user can close the toolbar.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::CanBeClosed](../vs140/cmfctoolbar--canbeclosed.md)