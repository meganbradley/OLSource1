---
title: "CMFCTasksPane::EnableNavigationToolbar"
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
  - "CMFCTasksPane::EnableNavigationToolbar"
  - "CMFCTasksPane.EnableNavigationToolbar"
  - "EnableNavigationToolbar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableNavigationToolbar method"
ms.assetid: 5a4bc5bb-08b0-4504-ba4d-d0517c4923a5
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTasksPane::EnableNavigationToolbar
Enables or disables the navigation toolbar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to enable the navigation toolbar; otherwise, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the resource ID of the bitmap that contains the images to display on the toolbar.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the size of a toolbar image.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the size of a toolbar button.  
  
## Remarks  
 The navigation toolbar is a toolbar that the framework displays at the top of the task pane. The navigation toolbar contains the **Back**, **Forward**, and **Home** navigation buttons and a menu button that contains the list of available pages.  
  
 By default, the framework does not display the navigation toolbar. If the navigation toolbar is not displayed, the navigation buttons are located on the caption of the docking bar.  
  
## Requirements  
 **Header:** afxTasksPane.h  
  
## See Also  
 [CMFCTasksPane Class](../vs140/cmfctaskspane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)