---
title: "CWinApp::GetPrinterDeviceDefaults"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CWinApp::GetPrinterDeviceDefaults
  - GetPrinterDeviceDefaults
  - CWinApp.GetPrinterDeviceDefaults
dev_langs: 
  - C++
helpviewer_keywords: 
  - CWinApp class, operations
  - GetPrinterDeviceDefaults method
  - printer device defaults
  - printers, device defaults
ms.assetid: fac45f81-11e7-4a72-acdf-36837ac026e4
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWinApp::GetPrinterDeviceDefaults
Call this member function to prepare a printer device context for printing.  
  
## Syntax  
  
```  
  
      BOOL GetPrinterDeviceDefaults(  
   struct tagPDA* pPrintDlg   
);  
```  
  
#### Parameters  
 *pPrintDlg*  
 A pointer to a [PRINTDLG](http://msdn.microsoft.com/library/windows/desktop/ms646843) structure.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 Retrieves the current printer defaults from the Windows .INI file as necessary, or uses the last printer configuration set by the user in Print Setup.  
  
## Example  
 [!code[NVC_MFCWindowing#40](../vs140/codesnippet/CPP/cwinapp--getprinterdevicedefaults_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialog Class](../vs140/cprintdialog-class.md)