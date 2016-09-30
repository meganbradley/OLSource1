---
title: "CPrintDialog::GetDriverName"
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
  - "CPrintDialog::GetDriverName"
  - "GetDriverName"
  - "CPrintDialog.GetDriverName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDriverName method"
  - "CPrintDialog class, operations"
ms.assetid: e9e3878b-7940-45c5-8f20-485bbdf34fc2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintDialog::GetDriverName
Retrieves the name of the currently selected printer driver.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> specifying the system-defined driver name.  
  
## Remarks  
 Call this function after calling [DoModal](../vs140/cprintdialog--domodal.md) or [GetDefaults](../vs140/cprintdialog--getdefaults.md) to retrieve the name of the system-defined printer device driver. Use a pointer to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object returned by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> as the value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in a call to [CDC::CreateDC](../vs140/cdc--createdc.md).  
  
## Example  
 See the example for [CPrintDialog::GetDeviceName](../vs140/cprintdialog--getdevicename.md).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPrintDialog Class](../vs140/cprintdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialog::GetDeviceName](../vs140/cprintdialog--getdevicename.md)   
 [CPrintDialog::GetDevMode](../vs140/cprintdialog--getdevmode.md)   
 [CPrintDialog::GetPortName](../vs140/cprintdialog--getportname.md)