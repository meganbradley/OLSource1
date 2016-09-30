---
title: "CWndClassInfo::m_lpszCursorID"
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
  - "m_lpszCursorID"
  - "CWndClassInfo.m_lpszCursorID"
  - "CWndClassInfo::m_lpszCursorID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_lpszCursorID"
ms.assetid: 22e3f93c-76e7-4d2d-a291-aab465727435
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWndClassInfo::m_lpszCursorID
Specifies either the name of the cursor resource or the resource identifier in the low-order word and zero in the high-order word.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 When the window class is registered, the handle to the cursor identified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is retrieved and stored by [m_wc](../vs140/cwndclassinfo--m_wc.md).  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> uses <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> only when the [DECLARE_WND_CLASS](../vs140/declare_wnd_class.md) (the default in [CWindowImpl](../vs140/cwindowimpl-class.md)) or the [DECLARE_WND_CLASS_EX](../vs140/declare_wnd_class_ex.md) macro is specified. In this case, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is initialized to **IDC_ARROW**. For more information, see the [CWndClassInfo](../vs140/cwndclassinfo-class.md) overview.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWndClassInfo Class](../vs140/cwndclassinfo-class.md)   
 [CWndClassInfo::m_bSystemCursor](../vs140/cwndclassinfo--m_bsystemcursor.md)