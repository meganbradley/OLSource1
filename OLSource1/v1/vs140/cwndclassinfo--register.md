---
title: "CWndClassInfo::Register"
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
  - "CWndClassInfo::Register"
  - "CWndClassInfo.Register"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Register method"
ms.assetid: bc31a034-c6ef-4dd9-8fa4-c68b72bbe08c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWndClassInfo::Register
Called by [CWindowImpl::Create](../vs140/cwindowimpl--create.md) to register the window class if it has not yet been registered.  
  
## Syntax  
  
```  
  
      ATOM Register(  
   WNDPROC* pProc   
);  
```  
  
#### Parameters  
 `pProc`  
 [out] Specifies the original window procedure of an existing window class.  
  
## Return Value  
 If successful, an atom that uniquely identifies the window class being registered. Otherwise, 0.  
  
## Remarks  
 If you have specified the [DECLARE_WND_CLASS](../vs140/declare_wnd_class.md) (the default in [CWindowImpl](../vs140/cwindowimpl-class.md)) or the [DECLARE_WND_CLASS_EX](../vs140/declare_wnd_class_ex.md) macro, `Register` registers a new window class. In this case, the `pProc` parameter is not used.  
  
 If you have specified the [DECLARE_WND_SUPERCLASS](../vs140/declare_wnd_superclass.md) macro, `Register` registers a superclass — a window class that is based on an existing class but uses a different window procedure. The existing window class's window procedure is returned in `pProc`.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWndClassInfo Class](../vs140/cwndclassinfo-class.md)   
 [CWndClassInfo::m_atom](../vs140/cwndclassinfo--m_atom.md)   
 [CWndClassInfo::m_wc](../vs140/cwndclassinfo--m_wc.md)   
 [CWndClassInfo::pWndProc](../vs140/cwndclassinfo--pwndproc.md)