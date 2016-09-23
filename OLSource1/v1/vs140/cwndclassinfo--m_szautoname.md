---
title: "CWndClassInfo::m_szAutoName"
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
  - m_szAutoName
  - CWndClassInfo.m_szAutoName
  - CWndClassInfo::m_szAutoName
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_szAutoName
ms.assetid: 1689fdd0-bebb-483e-a3d5-4ce0ad7aa245
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWndClassInfo::m_szAutoName
Holds the name of the window class.  
  
## Syntax  
  
```  
  
TCHAR m_szAutoName[13];  
  
```  
  
## Remarks  
 `CWndClassInfo` uses `m_szAutoName` only if **NULL** is passed for the `WndClassName` parameter to [DECLARE_WND_CLASS](../vs140/declare_wnd_class.md), the [DECLARE_WND_CLASS_EX](../vs140/declare_wnd_class_ex.md) or [DECLARE_WND_SUPERCLASS](../vs140/declare_wnd_superclass.md). ATL will construct a name when the window class is registered.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWndClassInfo Class](../vs140/cwndclassinfo-class.md)