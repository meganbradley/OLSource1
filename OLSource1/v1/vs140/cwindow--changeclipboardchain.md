---
title: "CWindow::ChangeClipboardChain"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CWindow::ChangeClipboardChain
  - ATL.CWindow.ChangeClipboardChain
  - ChangeClipboardChain
  - ATL::CWindow::ChangeClipboardChain
  - CWindow.ChangeClipboardChain
dev_langs: 
  - C++
helpviewer_keywords: 
  - ChangeClipboardChain method
ms.assetid: 0f3e8b9e-b0c9-4585-8b20-e3818a5cdd6f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWindow::ChangeClipboardChain
Removes the window from the chain of Clipboard viewers.  
  
## Syntax  
  
```  
  
      BOOL ChangeClipboardChain(  
   HWND hWndNewNext   
) throw();  
```  
  
## Remarks  
 See [ChangeClipboardChain](http://msdn.microsoft.com/library/windows/desktop/ms649034) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::SetClipboardViewer](../vs140/cwindow--setclipboardviewer.md)