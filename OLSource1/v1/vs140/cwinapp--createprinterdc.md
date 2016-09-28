---
title: "CWinApp::CreatePrinterDC"
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
  - "CreatePrinterDC"
  - "CWinApp::CreatePrinterDC"
  - "CWinApp.CreatePrinterDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinApp class, operations"
  - "CreatePrinterDC method"
  - "printers, device contexts"
  - "device contexts, creating"
ms.assetid: 828b3772-0797-4ed6-a60a-685a19421d1f
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::CreatePrinterDC
Call this member function to create a printer device context (DC) from the selected printer.  
  
## Syntax  
  
```  
  
      BOOL CreatePrinterDC(  
   CDC& dc   
);  
```  
  
#### Parameters  
 `dc`  
 A reference to a printer device context.  
  
## Return Value  
 Nonzero if the printer device context is created successfully; otherwise 0.  
  
## Remarks  
 `CreatePrinterDC` initializes the device context that you pass in by reference, so you can use it to print.  
  
 If the function is successful, when you have finished printing, you must destroy the device context. You can let the destructor of the [CDC](../vs140/cdc-class.md) object do it, or you can do it explicitly by calling [CDC::DeleteDC](../vs140/cdc--deletedc.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::SelectPrinter](../vs140/cwinapp--selectprinter.md)