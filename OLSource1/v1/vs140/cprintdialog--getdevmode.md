---
title: "CPrintDialog::GetDevMode"
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
  - "CPrintDialog::GetDevMode"
  - "CPrintDialog.GetDevMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDevMode method"
  - "CPrintDialog class, operations"
ms.assetid: 09813975-3e56-4b60-b4d3-134a8342c10c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintDialog::GetDevMode
Retrieves the `DEVMODE` structure.  
  
## Syntax  
  
```  
  
LPDEVMODE GetDevMode( ) const;  
```  
  
## Return Value  
 The [DEVMODE](http://msdn.microsoft.com/library/windows/desktop/dd183565) data structure, which contains information about the device initialization and environment of a print driver. You must unlock the memory taken by this structure with the Windows [GlobalUnlock](http://msdn.microsoft.com/library/windows/desktop/aa366595) function, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 Call this function after calling [DoModal](../vs140/cprintdialog--domodal.md) or [GetDefaults](../vs140/cprintdialog--getdefaults.md) to retrieve information about the printing device.  
  
## Example  
 See the example for [CPrintDialog::PrintCollate](../vs140/cprintdialog--printcollate.md).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPrintDialog Class](../vs140/cprintdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetDeviceCaps](../vs140/cdc--getdevicecaps.md)