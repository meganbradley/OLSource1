---
title: "CWinAppEx::StoreWindowPlacement"
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
  - "StoreWindowPlacement"
  - "CWinAppEx.StoreWindowPlacement"
  - "CWinAppEx::StoreWindowPlacement"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "StoreWindowPlacement method"
ms.assetid: a3db2f75-cc73-4bd6-bb25-0596e83e86b2
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::StoreWindowPlacement
Called by the framework to write the size and location of the main frame window to the registry.  
  
## Syntax  
  
```  
virtual BOOL StoreWindowPlacement(  
   const CRect& rectNormalPosition,  
   int nFlags,  
   int nShowCmd   
);  
```  
  
#### Parameters  
 [in] `nFlags`  
 Flags that control the position of the minimized window and how the operating system switches between a minimized window and a restored window.  
  
 [in] `nShowCmd`  
 An integer that specifies the show state of the window. For more information about possible values, see [CWnd::ShowWindow](../vs140/cwnd--showwindow.md).  
  
 [in] `rectNormalPosition`  
 A rectangle that contains the coordinates of the main frame window when it is in the restored state.  
  
## Return Value  
 Nonzero if successful; 0 otherwise.  
  
## Remarks  
 By default, MFC automatically saves the position and state of the main frame window before the application exits. This information is stored in the Windows registry under the WindowPlacement key in the default registry location for your application. For more information about the default registry location of your application, see [CWinAppEx::GetRegistryBase](../vs140/cwinappex--getregistrybase.md).  
  
 Override this method if you want to store additional information about the main frame window.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx::LoadWindowPlacement](../vs140/cwinappex--loadwindowplacement.md)