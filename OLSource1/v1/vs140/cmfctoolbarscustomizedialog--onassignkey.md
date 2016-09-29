---
title: "CMFCToolBarsCustomizeDialog::OnAssignKey"
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
  - "CMFCToolBarsCustomizeDialog.OnAssignKey"
  - "OnAssignKey"
  - "CMFCToolBarsCustomizeDialog::OnAssignKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnAssignKey method"
ms.assetid: 43d42034-6ae8-437e-bedc-f458e44b0bd0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarsCustomizeDialog::OnAssignKey
Validates keyboard shortcuts as a user defines them.  
  
## Syntax  
  
```  
virtual BOOL OnAssignKey(  
   ACCEL* pAccel   
);  
```  
  
#### Parameters  
 [in, out] `pAccel`  
 Pointer to the proposed keyboard assigment that is expressed as an [ACCEL](http://msdn.microsoft.com/library/windows/desktop/ms646340) struct.  
  
## Return Value  
 `TRUE` if the key can be assigned, or `FALSE` if the key cannot be assigned. The default implementation always returns `TRUE`.  
  
## Remarks  
 Override this method in a derived class to perform extra processing when a user assigns a new keyboard shortcut, or to validate keyboard shortcuts as the user defines them. To prevent a shortcut from being assigned, return `FALSE`. You should also display a message box or otherwise inform the user of the reason why the keyboard shortcut was rejected.  
  
## Requirements  
 **Header:** afxToolBarsCustomizeDialog.h  
  
## See Also  
 [CMFCToolBarsCustomizeDialog Class](../vs140/cmfctoolbarscustomizedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)