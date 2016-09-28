---
title: "CPrintDialogEx::GetDeviceName"
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
  - "CPrintDialogEx::GetDeviceName"
  - "CPrintDialogEx.GetDeviceName"
  - "GetDeviceName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDeviceName method"
ms.assetid: d30300b7-85a9-49d3-acc0-73fef102bb8c
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintDialogEx::GetDeviceName
Call this function after calling [DoModal](../vs140/cprintdialogex--domodal.md) to retrieve the name of the currently selected printer, or after calling [GetDefaults](../vs140/cprintdialogex--getdefaults.md) to retrieve the name of the default printer.  
  
## Syntax  
  
```  
  
CString GetDeviceName( ) const;  
  
```  
  
## Return Value  
 The name of the currently selected printer.  
  
## Remarks  
 Use a pointer to the `CString` object returned by `GetDeviceName` as the value of `lpszDeviceName` in a call to [CDC::CreateDC](../vs140/cdc--createdc.md).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPrintDialogEx Class](../vs140/cprintdialogex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialogEx::GetDriverName](../vs140/cprintdialogex--getdrivername.md)   
 [CPrintDialogEx::GetDevMode](../vs140/cprintdialogex--getdevmode.md)   
 [CPrintDialogEx::GetPortName](../vs140/cprintdialogex--getportname.md)