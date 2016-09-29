---
title: "CSimpleDialog::DoModal"
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
  - "CSimpleDialog.DoModal"
  - "ATL.CSimpleDialog.DoModal"
  - "CSimpleDialog::DoModal"
  - "ATL::CSimpleDialog::DoModal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoModal method"
ms.assetid: 9e087a72-bf3b-48dc-a64c-45c51250c4c9
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSimpleDialog::DoModal
Invokes a modal dialog box and returns the dialog-box result when done.  
  
## Syntax  
  
```  
  
      INT_PTR DoModal(  
   HWND hWndParent = ::GetActiveWindow()   
);  
```  
  
#### Parameters  
 `hWndParent`  
 A handle to the parent of the dialog box. If no value is provided, the parent is set to the current active window.  
  
## Return Value  
 If successful, the return value is the resource ID of the control that dismissed the dialog box.  
  
 If the function fails, the return value is –1. To get extended error information, call `GetLastError`.  
  
## Remarks  
 This method handles all interaction with the user while the dialog box is active. This is what makes the dialog box modal; that is, the user cannot interact with other windows until the dialog box is closed.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CSimpleDialog Class](../vs140/csimpledialog-class.md)