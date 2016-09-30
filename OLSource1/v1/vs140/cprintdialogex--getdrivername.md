---
title: "CPrintDialogEx::GetDriverName"
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
  - "CPrintDialogEx.GetDriverName"
  - "GetDriverName"
  - "CPrintDialogEx::GetDriverName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDriverName method"
ms.assetid: 5b1994e3-5cde-4f12-bee0-31b086154908
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintDialogEx::GetDriverName
Call this function after calling [DoModal](../vs140/cprintdialogex--domodal.md) or [GetDefaults](../vs140/cprintdialogex--getdefaults.md) to retrieve the name of the system-defined printer device driver.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> specifying the system-defined driver name.  
  
## Remarks  
 Use a pointer to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object returned by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> as the value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in a call to [CDC::CreateDC](../vs140/cdc--createdc.md).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPrintDialogEx Class](../vs140/cprintdialogex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialogEx::GetDeviceName](../vs140/cprintdialogex--getdevicename.md)   
 [CPrintDialogEx::GetDevMode](../vs140/cprintdialogex--getdevmode.md)   
 [CPrintDialogEx::GetPortName](../vs140/cprintdialogex--getportname.md)