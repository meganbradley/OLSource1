---
title: "AfxSetAllocHook"
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
  - "AfxSetAllocHook"
  - "AFX/AfxSetAllocHook"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxSetAllocHook function"
ms.assetid: d92a4233-b0a7-44f1-8a68-13e0f00033d6
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxSetAllocHook
Sets a hook that enables calling of the specified function before each memory block is allocated.  
  
## Syntax  
  
```  
  
      AFX_ALLOC_HOOK AfxSetAllocHook(  
   AFX_ALLOC_HOOK pfnAllocHook   
);   
```  
  
#### Parameters  
 *pfnAllocHook*  
 Specifies the name of the function to call. See the Remarks for the prototype of an allocation function.  
  
## Return Value  
 Nonzero if you want to permit the allocation; otherwise 0.  
  
## Remarks  
 The Microsoft Foundation Class Library debug-memory allocator can call a user-defined hook function to allow the user to monitor a memory allocation and to control whether the allocation is permitted. Allocation hook functions are prototyped as follows:  
  
 **BOOL AFXAPI AllocHook( size_t** `nSize`**, BOOL** `bObject`**, LONG** `lRequestNumber` **);**  
  
 `nSize`  
 The size of the proposed memory allocation.  
  
 `bObject`  
 **TRUE** if the allocation is for a `CObject`-derived object; otherwise **FALSE**.  
  
 `lRequestNumber`  
 The memory allocation's sequence number.  
  
 Note that the **AFXAPI** calling convention implies that the callee must remove the parameters from the stack.  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxMessageBox](../vs140/afxmessagebox.md)