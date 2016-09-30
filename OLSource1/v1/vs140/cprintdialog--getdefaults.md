---
title: "CPrintDialog::GetDefaults"
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
  - "CPrintDialog::GetDefaults"
  - "CPrintDialog.GetDefaults"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDefaults method"
  - "CPrintDialog class, operations"
ms.assetid: 84410502-7b77-4d4e-b8a3-234c624e19e9
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintDialog::GetDefaults
Retrieves the device defaults of the default printer without displaying a dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the function was successful; otherwise 0.  
  
## Remarks  
 The retrieved values are placed in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure.  
  
 In some cases, a call to this function will call the [constructor](../vs140/cprintdialog--cprintdialog.md) for <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> set to **FALSE**. In these cases, a printer DC and **hDevNames** and **hDevMode** (two handles located in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> data member) are automatically allocated.  
  
 If the constructor for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> was called with <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> set to **FALSE**, this function will not only return **hDevNames** and **hDevMode** (located in **m_pd.hDevNames** and **m_pd.hDevMode**) to the caller, but will also return a printer DC in **m_pd.hDC**. It is the responsibility of the caller to delete the printer DC and call the Windows [GlobalFree](http://msdn.microsoft.com/library/windows/desktop/aa366579) function on the handles when you are finished with the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
## Example  
 This code fragment gets the default printer's device context and reports to the user the resolution of the printer in dots per inch. (This attribute of the printer's capabilities is often referred to as DPI.)  
  
 [!code[NVC_MFCDocView#107](../vs140/codesnippet/CPP/cprintdialog--getdefaults_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPrintDialog Class](../vs140/cprintdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialog::m_pd](../vs140/cprintdialog--m_pd.md)   
 [CPrintDialog::GetDeviceName](../vs140/cprintdialog--getdevicename.md)   
 [CPrintDialog::GetDriverName](../vs140/cprintdialog--getdrivername.md)   
 [CPrintDialog::GetPortName](../vs140/cprintdialog--getportname.md)