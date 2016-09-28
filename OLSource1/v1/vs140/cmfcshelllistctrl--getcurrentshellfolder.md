---
title: "CMFCShellListCtrl::GetCurrentShellFolder"
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
  - "CMFCShellListCtrl.GetCurrentShellFolder"
  - "GetCurrentShellFolder"
  - "CMFCShellListCtrl::GetCurrentShellFolder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCurrentShellFolder method"
ms.assetid: 45555c3d-cc03-4319-8c49-2998e7e19d50
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCShellListCtrl::GetCurrentShellFolder
Gets a pointer to the currently selected item in the [CMFCShellListCtrl](../vs140/cmfcshelllistctrl-class.md) object.  
  
## Syntax  
  
```  
const IShellFolder* GetCurrentShellFolder() const;  
```  
  
## Return Value  
 A pointer to the [IShellFolder Interface](http://msdn.microsoft.com/library/windows/desktop/bb775075) for the selected object.  
  
## Remarks  
 This method returns `NULL` if no object is currently selected.  
  
## Requirements  
 **Header:** afxshelllistctrl.h  
  
## See Also  
 [CMFCShellListCtrl Class](../vs140/cmfcshelllistctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)