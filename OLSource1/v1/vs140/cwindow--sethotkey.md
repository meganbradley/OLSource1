---
title: "CWindow::SetHotKey"
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
  - "CWindow.SetHotKey"
  - "ATL::CWindow::SetHotKey"
  - "ATL.CWindow.SetHotKey"
  - "CWindow::SetHotKey"
  - "SetHotKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetHotKey method"
ms.assetid: 843278ae-e4ef-47c7-9ce4-95604761a7e7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::SetHotKey
Associates a hot key with the window by sending a **WM_SETHOTKEY** message.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The virtual key code of the hot key. For a list of of standard virtual key codes, see Winuser.h.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The modifiers of the hot key. For a list of possible values, see **WM_SETHOTKEY** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 For a list of possible return values, see [WM_SETHOTKEY](http://msdn.microsoft.com/library/windows/desktop/ms646284) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::GetHotKey](../vs140/cwindow--gethotkey.md)