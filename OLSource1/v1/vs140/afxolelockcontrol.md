---
title: "AfxOleLockControl"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AfxOleLockControl"
  - "AFXWIN/AfxOleLockControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxOleLockControl function"
ms.assetid: 12b2cfb5-b98c-410c-a158-442842c5213d
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxOleLockControl
Locks the class factory of the specified control so that dynamically created data associated with the control remains in memory.  
  
## Syntax  
  
```  
  
      BOOL AFXAPI AfxOleLockControl(  
   REFCLSID clsid   
);  
BOOL AFXAPI AfxOleLockControl(  
   LPCTSTR lpszProgID   
);  
```  
  
#### Parameters  
 `clsid`  
 The unique class ID of the control.  
  
 `lpszProgID`  
 The unique program ID of the control.  
  
## Return Value  
 Nonzero if the class factory of the control was successfully locked; otherwise 0.  
  
## Remarks  
 This can significantly speed up display of the controls. For example, once you create a control in a dialog box and lock the control with `AfxOleLockControl`, you do not need to create and kill it again every time the dialog is shown or destroyed. If the user opens and closes a dialog box repeatedly, locking your controls can significantly enhance performance. When you are ready to destroy the control, call `AfxOleUnlockControl`.  
  
## Example  
 [!code[NVC_MFCAutomation#6](../vs140/codesnippet/CPP/afxolelockcontrol_1.cpp)]  
  
## Requirements  
 **Header:** <afxwin.h>  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxOleUnlockControl](../vs140/afxoleunlockcontrol.md)