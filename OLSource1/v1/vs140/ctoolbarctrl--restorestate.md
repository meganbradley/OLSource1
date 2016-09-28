---
title: "CToolBarCtrl::RestoreState"
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
  - "RestoreState"
  - "CToolBarCtrl.RestoreState"
  - "CToolBarCtrl::RestoreState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RestoreState method"
ms.assetid: f7dcd8f5-83c5-44d7-9b76-b366471231f1
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBarCtrl::RestoreState
Restores the state of the toolbar control from the location in the registry specified by the parameters.  
  
## Syntax  
  
```  
  
      void RestoreState(  
   HKEY hKeyRoot,  
   LPCTSTR lpszSubKey,  
   LPCTSTR lpszValueName   
);  
```  
  
#### Parameters  
 `hKeyRoot`  
 Identifies a currently open key in the registry or any of the following predefined reserved handle values:  
  
-   **HKEY_CLASSES_ROOT**  
  
-   **HKEY_CURRENT_USER**  
  
-   **HKEY_LOCAL_MACHINE**  
  
-   **HKEY_USERS**  
  
 `lpszSubKey`  
 Points to a null-terminated string containing the name of the subkey with which a value is associated. This parameter can be null or a pointer to an empty string. If the parameter is **NULL**, the value will be added to the key identified by the `hKeyRoot` parameter.  
  
 `lpszValueName`  
 Points to a string containing the name of the value to retrieve. If a value with this name is not already present in the key, the function adds it to the key.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::SaveState](../vs140/ctoolbarctrl--savestate.md)