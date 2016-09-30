---
title: "CPrintDialogEx::GetDefaults"
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
  - "GetDefaults"
  - "CPrintDialogEx.GetDefaults"
  - "CPrintDialogEx::GetDefaults"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDefaults method"
ms.assetid: 45588565-fb73-4a73-a5a7-cf59ccf786a2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintDialogEx::GetDefaults
Call this function to retrieve the device defaults of the default printer without displaying a dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 **TRUE** if successful, otherwise **FALSE**.  
  
## Remarks  
 Creates a printer device context (DC) from the [DEVMODE](http://msdn.microsoft.com/library/windows/desktop/dd183565) and [DEVNAMES](../vs140/devnames-structure.md) structures.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> does not display the Print property sheet. Instead, it sets the **hDevNames** and **hDevMode** members of [m_pdex](../vs140/cprintdialogex--m_pdex.md) to handles to the [DEVMODE](http://msdn.microsoft.com/library/windows/desktop/dd183565) and [DEVNAMES](../vs140/devnames-structure.md) structures that are initialized for the system default printer. Both **hDevNames** and **hDevMode** must be NULL, or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> fails.  
  
 If the **PD_RETURNDC** flag is set, this function will not only return **hDevNames** and **hDevMode** (located in **m_pdex.hDevNames** and **m_pdex.hDevMode**) to the caller, but will also return a printer DC in **m_pdex.hDC**. It is the responsibility of the caller to delete the printer DC and call the Windows [GlobalFree](http://msdn.microsoft.com/library/windows/desktop/aa366579) function on the handles when you are finished with the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPrintDialogEx Class](../vs140/cprintdialogex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialogEx::m_pdex](../vs140/cprintdialogex--m_pdex.md)   
 [CPrintDialog::GetDeviceName](../vs140/cprintdialog--getdevicename.md)   
 [CPrintDialog::GetDriverName](../vs140/cprintdialog--getdrivername.md)   
 [CPrintDialog::GetPortName](../vs140/cprintdialog--getportname.md)