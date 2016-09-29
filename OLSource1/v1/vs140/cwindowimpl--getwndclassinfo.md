---
title: "CWindowImpl::GetWndClassInfo"
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
  - "GetWndClassInfo"
  - "CWindowImpl::GetWndClassInfo"
  - "CWindowImpl.GetWndClassInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetWndClassInfo method"
ms.assetid: 5cf26df0-75de-45a2-a97f-9431d69934a9
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindowImpl::GetWndClassInfo
Called by [Create](../vs140/cwindowimpl--create.md) to access the window class information.  
  
## Syntax  
  
```  
  
static CWndClassInfo& GetWndClassInfo( );  
  
```  
  
## Return Value  
 A static instance of [CWndClassInfo](../vs140/cwndclassinfo-class.md).  
  
## Remarks  
 By default, `CWindowImpl` obtains this method through the [DECLARE_WND_CLASS](../vs140/declare_wnd_class.md) macro, which specifies a new window class.  
  
 To superclass an existing window class, derive your class from `CWindowImpl` and include the [DECLARE_WND_SUPERCLASS](../vs140/declare_wnd_superclass.md) macro to override `GetWndClassInfo`. For more information, see the [CWindowImpl](../vs140/cwindowimpl-class.md) overview.  
  
 Besides using the `DECLARE_WND_CLASS` and `DECLARE_WND_SUPERCLASS` macros, you can override `GetWndClassInfo` with your own implementation.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindowImpl Class](../vs140/cwindowimpl-class.md)