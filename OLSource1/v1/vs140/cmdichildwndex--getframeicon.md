---
title: "CMDIChildWndEx::GetFrameIcon"
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
  - "CMDIChildWndEx.GetFrameIcon"
  - "CMDIChildWndEx::GetFrameIcon"
  - "GetFrameIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFrameIcon method"
ms.assetid: 7af5fae5-58b8-4434-a0f9-e13693d7d164
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIChildWndEx::GetFrameIcon
Called by the framework to retrieve the icon of the MDI child window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A handle to the window icon.  
  
## Remarks  
 This method is called by the framework to determine what icon to display on the MDI tab that contains the MDI child frame window.  
  
 By default this method returns the window icon. Override <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>-derived class to customize this behavior.  
  
## Requirements  
 **Header:** afxMDIChildWndEx.h  
  
## See Also  
 [CMDIChildWndEx Class](../vs140/cmdichildwndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)