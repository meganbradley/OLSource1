---
title: "CPrintDialogEx::GetPortName"
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
  - "CPrintDialogEx.GetPortName"
  - "GetPortName"
  - "CPrintDialogEx::GetPortName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPortName method"
ms.assetid: b28d37b0-763f-4af4-a9b6-f7ce6a81eb8f
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintDialogEx::GetPortName
Call this function after calling [DoModal](../vs140/cprintdialogex--domodal.md) or [GetDefaults](../vs140/cprintdialogex--getdefaults.md) to retrieve the name of the currently selected printer port.  
  
## Syntax  
  
```  
  
CString GetPortName( ) const;  
  
```  
  
## Return Value  
 The name of the currently selected printer port.  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPrintDialogEx Class](../vs140/cprintdialogex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialogEx::GetDriverName](../vs140/cprintdialogex--getdrivername.md)   
 [CPrintDialogEx::GetDeviceName](../vs140/cprintdialogex--getdevicename.md)