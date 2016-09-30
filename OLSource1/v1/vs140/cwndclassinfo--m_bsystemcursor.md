---
title: "CWndClassInfo::m_bSystemCursor"
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
  - "m_bSystemCursor"
  - "CWndClassInfo.m_bSystemCursor"
  - "CWndClassInfo::m_bSystemCursor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_bSystemCursor"
ms.assetid: 86b9b3be-639a-490b-b83a-9afffb8715dc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWndClassInfo::m_bSystemCursor
If **TRUE**, the system cursor resource will be loaded when the window class is registered.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Otherwise, the cursor resource contained in your module will be loaded.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> uses <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> only when the [DECLARE_WND_CLASS](../vs140/declare_wnd_class.md) (the default in [CWindowImpl](../vs140/cwindowimpl-class.md)) or the [DECLARE_WND_CLASS_EX](../vs140/declare_wnd_class_ex.md) macro is specified. In this case, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is initialized to **TRUE**. For more information, see the [CWndClassInfo](../vs140/cwndclassinfo-class.md) overview.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWndClassInfo Class](../vs140/cwndclassinfo-class.md)   
 [CWndClassInfo::m_lpszCursorID](../vs140/cwndclassinfo--m_lpszcursorid.md)