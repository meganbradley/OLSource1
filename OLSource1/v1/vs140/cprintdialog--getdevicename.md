---
title: "CPrintDialog::GetDeviceName"
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
  - "GetDeviceName"
  - "CPrintDialog::GetDeviceName"
  - "CPrintDialog.GetDeviceName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDeviceName method"
  - "CPrintDialog class, operations"
ms.assetid: 0e544b79-1502-4c1e-803a-fc9b13fe2908
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintDialog::GetDeviceName
Retrieves the name of the currently selected printer device.  
  
## Syntax  
  
```  
  
CString GetDeviceName( ) const;  
```  
  
## Return Value  
 The name of the currently selected printer.  
  
## Remarks  
 Call this function after calling [DoModal](../vs140/cprintdialog--domodal.md) to retrieve the name of the currently selected printer, or after calling [GetDefaults](../vs140/cprintdialog--getdefaults.md) to retrieve the current device defaults of the default printer. Use a pointer to the `CString` object returned by `GetDeviceName` as the value of `lpszDeviceName` in a call to [CDC::CreateDC](../vs140/cdc--createdc.md).  
  
## Example  
 This code fragment shows the user's default printer name and the port it is connected to, along with the spooler name the printer uses. The code might show a message box that says, "Your default printer is HP LaserJet IIIP on \\\server\share using winspool.", for example.  
  
 [!code[NVC_MFCDocView#108](../vs140/codesnippet/CPP/cprintdialog--getdevicename_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPrintDialog Class](../vs140/cprintdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialog::GetDriverName](../vs140/cprintdialog--getdrivername.md)   
 [CPrintDialog::GetDevMode](../vs140/cprintdialog--getdevmode.md)   
 [CPrintDialog::GetPortName](../vs140/cprintdialog--getportname.md)