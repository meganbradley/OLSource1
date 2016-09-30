---
title: "CMFCPopupMenu::CheckArea"
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
  - "CheckArea"
  - "CMFCPopupMenu.CheckArea"
  - "CMFCPopupMenu::CheckArea"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CheckArea method"
ms.assetid: 07261d61-fcc4-4a49-906d-1b5d1b2eb1eb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPopupMenu::CheckArea
Determines the location of a point relative to the pop-up menu.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A point, in screen coordinates.  
  
## Return Value  
 A MENUAREA_TYPE parameter that indicates where the point is relative to the pop-up menu.  
  
## Remarks  
 A MENUAREA_TYPE parameter can have any one of the following values.  
  
-   OUTSIDE - <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is outside the pop-up menu.  
  
-   LOGO - <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is over a logo area.  
  
-   TEAROFF_CAPTION - <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is over the tear-off caption.  
  
-   SHADOW_BOTTOM - <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is over the bottom shadow of the pop-up menu.  
  
-   SHADOW_RIGHT - <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is over the right shadow of the pop-up menu.  
  
-   MENU - <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is over a command.  
  
## Requirements  
 **Header:** afxpopupmenu.h  
  
## See Also  
 [CMFCPopupMenu Class](../vs140/cmfcpopupmenu-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)