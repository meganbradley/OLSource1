---
title: "CPrintDialog::GetPortName"
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
  - "GetPortName"
  - "CPrintDialog::GetPortName"
  - "CPrintDialog.GetPortName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPrintDialog class, operations"
  - "GetPortName method"
ms.assetid: 7decf747-4e87-47b3-ba6b-7a4d3053540d
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPrintDialog::GetPortName
Retrieves the name of the currently selected printer port.  
  
## Syntax  
  
```  
  
CString GetPortName( ) const;  
```  
  
## Return Value  
 The name of the currently selected printer port.  
  
## Remarks  
 Call this function after calling [DoModal](../vs140/cprintdialog--domodal.md) or [GetDefaults](../vs140/cprintdialog--getdefaults.md) to retrieve the name of the currently selected printer port.  
  
## Example  
 See the example for [CPrintDialog::GetDeviceName](../vs140/cprintdialog--getdevicename.md).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPrintDialog Class](../vs140/cprintdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPrintDialog::GetDriverName](../vs140/cprintdialog--getdrivername.md)   
 [CPrintDialog::GetDeviceName](../vs140/cprintdialog--getdevicename.md)