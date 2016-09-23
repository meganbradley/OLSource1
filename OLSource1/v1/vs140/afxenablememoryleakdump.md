---
title: "AfxEnableMemoryLeakDump"
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
  - AfxEnableMemoryLeakDump
dev_langs: 
  - C++
helpviewer_keywords: 
  - AfxEnableMemoryLeakDump function
ms.assetid: 79d7b613-2729-4f5c-88fb-5c48fe562f83
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AfxEnableMemoryLeakDump
Enables and disables the memory leak dump in the `AFX_DEBUG_STATE` destructor.  
  
## Syntax  
  
```  
BOOL AFXAPI AfxEnableMemoryLeakDump(  
   BOOL bDump  
);  
```  
  
#### Parameters  
 [in] `bDump`  
 `TRUE` indicates the memory leak dump is enabled; `FALSE` indicates the memory leak dump is disabled.  
  
## Return Value  
 The previous value for this flag.  
  
## Remarks  
 When an application unloads the MFC library, the MFC library checks for memory leaks. At this point, any memory leaks are reported to the user through the **Debug** window of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
 If your application loads another library before the MFC library, some memory allocations in that library will be incorrectly reported as memory leaks. False memory leaks can cause your application to close slowly as the MFC library reports them. In this case, use `AfxEnableMemoryLeakDump` to disable the memory leak dump.  
  
> [!NOTE]
>  If you use this method to turn off the memory leak dump, you will not receive reports of valid memory leaks in your application. You should only use this method if you are confident that the memory leak report contains false memory leaks.  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros, Global Functions, and Global Variables](../vs140/macros--global-functions--and-global-variables.md)