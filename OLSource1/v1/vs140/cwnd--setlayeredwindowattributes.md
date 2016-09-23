---
title: "CWnd::SetLayeredWindowAttributes"
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
  - SetLayeredWindowAttributes
  - CWnd.SetLayeredWindowAttributes
  - CWnd::SetLayeredWindowAttributes
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetLayeredWindowAttributes method
ms.assetid: 5a8c8e9b-6533-4c04-bb32-1179898d1ba0
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::SetLayeredWindowAttributes
Sets the opacity and transparency color key of a layered window.  
  
## Syntax  
  
```  
  
      BOOL SetLayeredWindowAttributes(  
   COLORREF crKey,  
   BYTE bAlpha,  
   DWORD dwFlags  
);  
```  
  
#### Parameters  
 `crKey`  
 Pointer to a **COLORREF** value that specifies the transparency color key to be used when composing the layered window. All pixels painted by the window in this color will be transparent. To generate a **COLORREF**, use the RGB macro.  
  
 `bAlpha`  
 Alpha value used to describe the opacity of the layered window. For more information, see the **SourceConstantAlpha** member of the [BLENDFUNCTION](http://msdn.microsoft.com/library/windows/desktop/dd183393) structure. When `bAlpha` is 0, the window is completely transparent. When `bAlpha` is 255, the window is opaque.  
  
 `dwFlags`  
 Specifies an action to take. This parameter can be one or more of the following values. For a list of possible values, see[SetLayeredWindowAttributes](http://msdn.microsoft.com/library/windows/desktop/ms633540).  
  
## Return Value  
 Nonzero if the function succeeds; otherwise 0.  
  
## Remarks  
 This member function emulates the functionality of the function [SetLayeredWindowAttributes](http://msdn.microsoft.com/library/windows/desktop/ms633540), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::UpdateLayeredWindow](../vs140/cwnd--updatelayeredwindow.md)