---
title: "CMDIChildWndEx::GetFrameText"
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
  - "GetFrameText"
  - "CMDIChildWndEx.GetFrameText"
  - "CMDIChildWndEx::GetFrameText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFrameText method"
ms.assetid: 4132339f-8fdf-4271-a5d2-b342dd9f6573
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIChildWndEx::GetFrameText
Called by the framework to retrieve the text for the MDI child window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A string that contains the frame window text.  
  
## Remarks  
 This method is called by the framework to determine what text to display on the MDI tab that contains the MDI child frame window.  
  
 By default this method returns the window text. Override <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>-derived class to customize this behavior.  
  
## Requirements  
 **Header:** afxMDIChildWndEx.h  
  
## See Also  
 [CMDIChildWndEx Class](../vs140/cmdichildwndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStringT Class](../vs140/cstringt-class.md)