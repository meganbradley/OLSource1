---
title: "CPrintDialogEx::CreatePrinterDC"
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
  - "CPrintDialogEx.CreatePrinterDC"
  - "CPrintDialogEx::CreatePrinterDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreatePrinterDC method"
ms.assetid: 3af762e0-9f92-4cf7-a255-d6999be2c2e2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintDialogEx::CreatePrinterDC
Creates a printer device context (DC) from the [DEVMODE](http://msdn.microsoft.com/library/windows/desktop/dd183565) and [DEVNAMES](../vs140/devnames-structure.md) structures.  
  
## Syntax  
  
```  
  
HDC CreatePrinterDC( );  
  
```  
  
## Return Value  
 Handle to the newly created printer device context.  
  
## Remarks  
 The returned DC is also stored in the **hDC** member of [m_pdex](../vs140/cprintdialogex--m_pdex.md).  
  
 This DC is assumed to be the current printer DC, and any other previously obtained printer DCs must be deleted. This function can be called, and the resulting DC used, without ever displaying the Print dialog box.  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPrintDialogEx Class](../vs140/cprintdialogex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialogEx::GetPrinterDC](../vs140/cprintdialogex--getprinterdc.md)   
 [CPrintDialogEx::GetDevMode](../vs140/cprintdialogex--getdevmode.md)