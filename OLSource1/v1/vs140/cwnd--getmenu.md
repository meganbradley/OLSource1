---
title: "CWnd::GetMenu"
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
  - "CWnd::GetMenu"
  - "CWnd.GetMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMenu method"
ms.assetid: b498b0d5-81f2-472c-8cae-ba263d73ec1e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetMenu
Retrieves a pointer to the menu for this window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Identifies the menu. The value is **NULL** if <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> has no menu. The return value is undefined if <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is a child window.  
  
 The returned pointer may be temporary and should not be stored for later use.  
  
## Remarks  
 This function should not be used for child windows because they do not have a menu.  
  
## Example  
 [!code[NVC_MFCWindowing#98](../vs140/codesnippet/CPP/cwnd--getmenu_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [GetMenu](http://msdn.microsoft.com/library/windows/desktop/ms647640)