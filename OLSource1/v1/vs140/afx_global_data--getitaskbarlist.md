---
title: "AFX_GLOBAL_DATA::GetITaskbarList"
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
  - "afxglobals/AFX_GLOBAL_DATA::GetITaskbarList"
  - "GetITaskbarList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetITaskbarList"
ms.assetid: 82db87bc-4675-4970-a61f-0cb8c32715ff
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AFX_GLOBAL_DATA::GetITaskbarList
Creates and stores in the global data a pointer to the `ITaskBarList` interface.  
  
## Syntax  
  
```  
ITaskbarList *GetITaskbarList();  
```  
  
## Return Value  
 A pointer to the `ITaskbarList` interface if creation of a task bar list object succeeds; `NULL` if creation fails or if the current Operation System is less than Windows 7.  
  
## Remarks  
  
## Requirements  
 **Header:** afxglobals.h  
  
## See Also  
 [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md)