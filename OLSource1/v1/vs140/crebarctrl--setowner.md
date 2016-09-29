---
title: "CReBarCtrl::SetOwner"
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
  - "CReBarCtrl::SetOwner"
  - "SetOwner"
  - "CReBarCtrl.SetOwner"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetOwner method"
  - "CReBarCtrl class, attributes"
ms.assetid: 50206395-eab4-42bd-a8d1-a1b0a9492a1e
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl::SetOwner
Implements the behavior of the Win32 message [RB_SETPARENT](http://msdn.microsoft.com/library/windows/desktop/bb774522), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
```  
  
      CWnd* SetOwner(  
   CWnd* pWnd   
);  
```  
  
#### Parameters  
 `pWnd`  
 A pointer to a `CWnd` object to set as the owner of the rebar control.  
  
## Return Value  
 A pointer to a [CWnd](../vs140/cwnd-class.md) object that is the current owner of the rebar control.  
  
## Remarks  
 Note that this member function uses pointers to `CWnd` objects for both the current and selected owner of the rebar control, rather than handles to windows.  
  
> [!NOTE]
>  This member function does not change the actual parent that was set when the control was created; rather it sends notification messages to the window you specify.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)