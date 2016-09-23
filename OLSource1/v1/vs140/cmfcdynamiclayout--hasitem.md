---
title: "CMFCDynamicLayout::HasItem"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
dev_langs: 
  - C++
ms.assetid: b4c1e97b-c35b-4278-87b5-6ea16779ff43
caps.latest.revision: 8
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCDynamicLayout::HasItem
Checks if a child control was added to dynamic layout.  
  
## Syntax  
  
```  
  
  BOOL HasItem(  
HWND hwnd);  
```  
  
#### Parameters  
 `hwnd`  
 The window handle for the control.  
  
## Return Value  
 TRUE if layout already has this item; otherwise FALSE.  
  
## Remarks  
  
## Requirements  
 **Header:** afxlayout.h  
  
## See Also  
 [CMFCDynamicLayout Class](../vs140/cmfcdynamiclayout-class.md)