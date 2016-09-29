---
title: "CWinFormsControl::GetControlHandle"
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
  - "CWinFormsControl.GetControlHandle"
  - "GetControlHandle"
  - "CWinFormsControl::GetControlHandle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetControlHandle method"
ms.assetid: eed8e67d-6cd1-46cc-a3a2-a492edfa06d3
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinFormsControl::GetControlHandle
Retrieves a handle to the Windows Forms control.  
  
## Syntax  
  
```  
inline HWND GetControlHandle( ) const;  
```  
  
## Return Value  
 Returns a handle to the Windows Forms control.  
  
## Remarks  
 `GetControlHandle` is a helper method that returns the window handle stored in the .NET Framework control properties. The window handle value is copied to [CWnd::m_hWnd](../vs140/cwnd--m_hwnd.md) during the call to [CWnd::Attach](../vs140/cwnd--attach.md).  
  
## Requirements  
 **Header:** afxwinforms.h  
  
## See Also  
 [CWinFormsControl Class](../vs140/cwinformscontrol-class.md)   
 [GetControl](../vs140/cwinformscontrol--getcontrol.md)   
 [CreateManagedControl](../vs140/cwinformscontrol--createmanagedcontrol.md)