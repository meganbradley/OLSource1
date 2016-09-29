---
title: "CFileDialog::SetControlState"
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
  - "SetControlState"
  - "afxdlgs/CFileDialog::SetControlState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetControlState"
ms.assetid: d5be9a0c-be75-41ca-a270-2700b73b358c
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileDialog::SetControlState
Sets the current visibility and enabled states of a given control.  
  
## Syntax  
  
```  
HRESULT SetControlState(  
   DWORD dwIDCtl,  
   CDCONTROLSTATEF dwState  
);  
```  
  
#### Parameters  
 `dwIDCtl`  
 The ID of the control.  
  
 `dwState`  
 One or more values from the CDCONTROLSTATE enumeration that indicate the current state of the control.  
  
## Remarks  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CFileDialog Class](../vs140/cfiledialog-class.md)