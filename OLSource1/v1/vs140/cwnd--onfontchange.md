---
title: "CWnd::OnFontChange"
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
  - "WM_FONTCHANGE"
  - "CWnd::OnFontChange"
  - "CWnd.OnFontChange"
  - "OnFontChange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnFontChange method"
  - "WM_FONTCHANGE"
ms.assetid: bb012d2e-5bcc-49ce-a1bf-c5c2ee1f1e7d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnFontChange
All top-level windows in the system receive an `OnFontChange` call from the framework after the application changes the pool of font resources.  
  
## Syntax  
  
```  
  
afx_msg void OnFontChange( );  
```  
  
## Remarks  
 An application that adds or removes fonts from the system (for example, through the [AddFontResource](http://msdn.microsoft.com/library/windows/desktop/dd183326) or [RemoveFontResource](http://msdn.microsoft.com/library/windows/desktop/dd162922) Windows function) should send the [WM_FONTCHANGE](http://msdn.microsoft.com/library/windows/desktop/dd145211) message to all top-level windows.  
  
 To send this message, use the [SendMessage](http://msdn.microsoft.com/library/windows/desktop/ms644950) Windows function with the `hWnd` parameter set to **HWND_BROADCAST**.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [AddFontResource](http://msdn.microsoft.com/library/windows/desktop/dd183326)   
 [RemoveFontResource](http://msdn.microsoft.com/library/windows/desktop/dd162922)   
 [SendMessage](http://msdn.microsoft.com/library/windows/desktop/ms644950)   
 [WM_FONTCHANGE](http://msdn.microsoft.com/library/windows/desktop/dd145211)