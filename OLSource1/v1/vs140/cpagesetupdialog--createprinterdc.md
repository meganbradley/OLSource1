---
title: "CPageSetupDialog::CreatePrinterDC"
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
  - "CPageSetupDialog.CreatePrinterDC"
  - "CPageSetupDialog::CreatePrinterDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPageSetupDialog class, attributes"
  - "CreatePrinterDC method"
ms.assetid: 50097a9d-f7ee-4017-af9c-146e5382d57c
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPageSetupDialog::CreatePrinterDC
Creates a printer device context from the [DEVMODE](http://msdn.microsoft.com/library/windows/desktop/dd183565) and [DEVNAMES](../vs140/devnames-structure.md) structures.  
  
## Syntax  
  
```  
  
HDC CreatePrinterDC( );  
  
```  
  
## Return Value  
 Handle to the newly created printer device context (DC).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPageSetupDialog Class](../vs140/cpagesetupdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPageSetupDialog::GetDevMode](../vs140/cpagesetupdialog--getdevmode.md)   
 [CPageSetupDialog::GetDeviceName](../vs140/cpagesetupdialog--getdevicename.md)   
 [CPageSetupDialog::GetDriverName](../vs140/cpagesetupdialog--getdrivername.md)