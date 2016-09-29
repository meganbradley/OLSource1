---
title: "CPageSetupDialog::GetDriverName"
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
  - "CPageSetupDialog.GetDriverName"
  - "GetDriverName"
  - "CPageSetupDialog::GetDriverName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPageSetupDialog class, attributes"
  - "GetDriverName method"
ms.assetid: 1f0362e1-4705-447a-8a1b-690957f3e893
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPageSetupDialog::GetDriverName
Call this function after calling [DoModal](../vs140/cprintdialog--domodal.md) to retrieve the name of the system-defined printer device driver.  
  
## Syntax  
  
```  
  
CString GetDriverName( ) const;  
  
```  
  
## Return Value  
 A `CString` specifying the system-defined driver name.  
  
## Remarks  
 Use a pointer to the `CString` object returned by `GetDriverName` as the value of `lpszDriverName` in a call to [CDC::CreateDC](../vs140/cdc--createdc.md).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPageSetupDialog Class](../vs140/cpagesetupdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPageSetupDialog::GetDeviceName](../vs140/cpagesetupdialog--getdevicename.md)   
 [CPageSetupDialog::GetDevMode](../vs140/cpagesetupdialog--getdevmode.md)   
 [CPageSetupDialog::GetPortName](../vs140/cpagesetupdialog--getportname.md)