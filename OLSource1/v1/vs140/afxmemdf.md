---
title: "afxMemDF"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - AFX/afxMemDF
  - afxMemDF
dev_langs: 
  - C++
helpviewer_keywords: 
  - allocMemDF global variable
  - afxMemDF global variable
  - delayFreeMemDF global variable
  - checkAlwaysMemDF global variable
ms.assetid: cf117501-5446-4fce-81b3-f7194bc95086
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# afxMemDF
This variable is accessible from a debugger or your program and allows you to tune allocation diagnostics.  
  
## Syntax  
  
```  
  
int afxMemDF;  
```  
  
## Remarks  
 `afxMemDF` can have the following values as specified by the enumeration `afxMemDF`:  
  
-   **allocMemDF** Turns on debugging allocator (default setting in Debug library).  
  
-   **delayFreeMemDF** Delays freeing memory. While your program frees a memory block, the allocator does not return that memory to the underlying operating system. This will place maximum memory stress on your program.  
  
-   **checkAlwaysMemDF** Calls `AfxCheckMemory` every time memory is allocated or freed. This will significantly slow memory allocations and deallocations.  
  
## Example  
 [!code[NVC_MFC_Utilities#30](../vs140/codesnippet/CPP/afxmemdf_1.cpp)]
  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)