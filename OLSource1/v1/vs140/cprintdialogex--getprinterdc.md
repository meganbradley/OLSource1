---
title: "CPrintDialogEx::GetPrinterDC"
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
  - "CPrintDialogEx::GetPrinterDC"
  - "CPrintDialogEx.GetPrinterDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPrinterDC method"
ms.assetid: c073d109-43fc-425b-82e4-cbabe6861847
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintDialogEx::GetPrinterDC
Returns a handle to the printer device context.  
  
## Syntax  
  
```  
  
HDC GetPrinterDC( ) const;  
  
```  
  
## Return Value  
 A handle to the printer device context.  
  
## Remarks  
 You must call the Windows [DeleteDC](http://msdn.microsoft.com/library/windows/desktop/dd183533) function to delete the device context when you are done using it.  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPrintDialogEx Class](../vs140/cprintdialogex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialogEx::CreatePrinterDC](../vs140/cprintdialogex--createprinterdc.md)