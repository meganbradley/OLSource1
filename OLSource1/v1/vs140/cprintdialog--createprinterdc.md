---
title: "CPrintDialog::CreatePrinterDC"
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
  - "CPrintDialog::CreatePrinterDC"
  - "CPrintDialog.CreatePrinterDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreatePrinterDC method"
  - "CPrintDialog class, operations"
ms.assetid: 2e80c2e8-7b5f-4b39-ac31-5249fa574b57
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintDialog::CreatePrinterDC
Creates a printer device context (DC) from the [DEVMODE](http://msdn.microsoft.com/library/windows/desktop/dd183565) and [DEVNAMES](../vs140/devnames-structure.md) structures.  
  
## Syntax  
  
```  
  
HDC CreatePrinterDC( );  
```  
  
## Return Value  
 Handle to the newly created printer device context.  
  
## Remarks  
 This DC is assumed to be the current printer DC, and any other previously obtained printer DCs must be deleted by the user. This function can be called, and the resulting DC used, without ever displaying the Print dialog box.  
  
## Example  
 [!code[NVC_MFCDocView#106](../vs140/codesnippet/CPP/cprintdialog--createprinterdc_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPrintDialog Class](../vs140/cprintdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialog::GetDevMode](../vs140/cprintdialog--getdevmode.md)