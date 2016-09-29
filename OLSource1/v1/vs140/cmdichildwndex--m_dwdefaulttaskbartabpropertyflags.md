---
title: "CMDIChildWndEx::m_dwDefaultTaskbarTabPropertyFlags"
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
  - "m_dwDefaultTaskbarTabPropertyFlags"
  - "afxmdichildwndex/CMDIChildWndEx::m_dwDefaultTaskbarTabPropertyFlags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_dwDefaultTaskbarTabPropertyFlags data member"
ms.assetid: f1cba201-75cc-4984-8586-a5bb78b9120c
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIChildWndEx::m_dwDefaultTaskbarTabPropertyFlags
A combination of flags, which is passed by the framework to the `SetTaskbarTabProperties` method, when a tab (MDI child) is being registered with Windows 7 taskbar tabs.  
  
## Syntax  
  
```  
AFX_IMPORT_DATA static DWORD m_dwDefaultTaskbarTabPropertyFlags;  
```  
  
## Remarks  
 The default combination is STPF_USEAPPTHUMBNAILWHENACTIVE &#124; STPF_USEAPPPEEKWHENACTIVE.  
  
## Requirements  
 **Header:** afxmdichildwndex.h  
  
## See Also  
 [CMDIChildWndEx Class](../vs140/cmdichildwndex-class.md)