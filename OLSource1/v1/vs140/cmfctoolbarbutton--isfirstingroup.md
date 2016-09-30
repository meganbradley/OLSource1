---
title: "CMFCToolBarButton::IsFirstInGroup"
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
  - "CMFCToolBarButton::IsFirstInGroup"
  - "IsFirstInGroup"
  - "CMFCToolBarButton.IsFirstInGroup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsFirstInGroup method"
ms.assetid: 3b91cc11-e551-48f2-bfcf-c636ea5a6e78
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::IsFirstInGroup
Determines whether the button is in the first position in its button group.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the button is the first button in its button group; otherwise <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method defines a *button group* as a neighboring set of buttons that are positioned on the same row and are bounded by separators or the border of the toolbar. This method returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if the toolbar button refers to the **Customize** button. For more information about the **Customize** button, see [CMFCToolBar::GetCustomizeButton](../vs140/cmfctoolbar--getcustomizebutton.md).  
  
 Call the [CMFCToolBarButton::IsLastInGroup](../vs140/cmfctoolbarbutton--islastingroup.md) method to determine whether the button is in the last position in its button group.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::GetCustomizeButton](../vs140/cmfctoolbar--getcustomizebutton.md)   
 [CMFCToolBarButton::IsLastInGroup](../vs140/cmfctoolbarbutton--islastingroup.md)