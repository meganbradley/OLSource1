---
title: "CMFCToolBar::CalcSize"
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
  - "CMFCToolBar.CalcSize"
  - "CMFCToolBar::CalcSize"
  - "CalcSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CalcSize method"
ms.assetid: 9b3b732d-58ae-4c9f-a4b5-b0a7dbb6cd44
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::CalcSize
Called by the framework as part of the layout calculation process.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to specify that the toolbar is docked vertically; <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to specify that the toolbar is docked horizontally.  
  
## Return Value  
 A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object that specifies the overall size of the buttons on the toolbar.  
  
## Remarks  
 This method considers the attributes that affect the size of each button, such as the area of the text label and the border size.  
  
 If the toolbar contains no buttons, this method returns the reserved size of a single button by using the [CMFCToolBar::GetButtonSize](../vs140/cmfctoolbar--getbuttonsize.md) method.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::GetButtonSize](../vs140/cmfctoolbar--getbuttonsize.md)