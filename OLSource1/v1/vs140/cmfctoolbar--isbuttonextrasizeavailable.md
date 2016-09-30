---
title: "CMFCToolBar::IsButtonExtraSizeAvailable"
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
  - "CMFCToolBar.IsButtonExtraSizeAvailable"
  - "IsButtonExtraSizeAvailable"
  - "CMFCToolBar::IsButtonExtraSizeAvailable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsButtonExtraSizeAvailable method"
ms.assetid: d7cfb09e-c674-4fa7-a97e-21c5a5bd3888
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::IsButtonExtraSizeAvailable
Determines whether the toolbar can display buttons that have extended borders.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the bar can display buttons with the extra border size; otherwise <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 The toolbar object returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if it can display buttons that have extended borders. A toolbar button calls this method when it handles the [CMFCToolBarButton::OnChangeParentWnd](../vs140/cmfctoolbarbutton--onchangeparentwnd.md) notification and will set its internal extra border size flag accordingly. This internal flag may be retrieved later by calling [CMFCToolBarButton::IsExtraSize](../vs140/cmfctoolbarbutton--isextrasize.md).  
  
 Override this method in a class derived from [CMFCToolBar](../vs140/cmfctoolbar-class.md) and return <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if your bar can display the toolbar buttons with the extra border size and return <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> otherwise. The default implementation returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)