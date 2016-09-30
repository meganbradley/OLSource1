---
title: "CWindow::SetIcon"
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
  - "ATL.CWindow.SetIcon"
  - "CWindow::SetIcon"
  - "ATL::CWindow::SetIcon"
  - "CWindow.SetIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetIcon method"
ms.assetid: c7b5da14-0663-495c-9661-0292cda2ca07
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::SetIcon
Sets the window's large or small icon to the icon identified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The handle to a new icon.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] If **TRUE** (the default value), the method sets a large icon. Otherwise, it sets a small icon.  
  
## Return Value  
 The handle to the previous icon.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> sends a [WM_SETICON](http://msdn.microsoft.com/library/windows/desktop/ms632643) message to the window.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::GetIcon](../vs140/cwindow--geticon.md)