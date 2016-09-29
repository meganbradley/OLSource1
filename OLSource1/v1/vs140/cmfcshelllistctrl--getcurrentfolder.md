---
title: "CMFCShellListCtrl::GetCurrentFolder"
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
  - "CMFCShellListCtrl.GetCurrentFolder"
  - "GetCurrentFolder"
  - "CMFCShellListCtrl::GetCurrentFolder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCurrentFolder method"
ms.assetid: 861085e0-c1fe-4ab1-a4cc-256eeda66ad2
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCShellListCtrl::GetCurrentFolder
Retrieves the path of the currently selected folder in the [CMFCShellListCtrl](../vs140/cmfcshelllistctrl-class.md) object.  
  
## Syntax  
  
```  
BOOL GetCurrentFolder(  
   CString& strPath   
) const;  
```  
  
#### Parameters  
 [out] `strPath`  
 A reference to a string parameter where the method writes the path.  
  
## Return Value  
 Nonzero if successful; 0 otherwise.  
  
## Remarks  
 This method fails if there is no folder selected in the `CMFCShellListCtrl`.  
  
## Requirements  
 **Header:** afxshelllistctrl.h  
  
## See Also  
 [CMFCShellListCtrl Class](../vs140/cmfcshelllistctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)