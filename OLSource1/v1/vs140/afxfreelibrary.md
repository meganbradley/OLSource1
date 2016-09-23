---
title: "AfxFreeLibrary"
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
  - AfxFreeLibrary
dev_langs: 
  - C++
helpviewer_keywords: 
  - DLL modules [C++], unmapping
  - unmapping DLL module
  - AfxFreeLibrary function
ms.assetid: 0e06e292-710b-402f-9692-2cdcbab306f9
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AfxFreeLibrary
Both `AfxFreeLibrary` and `AfxLoadLibrary` maintain a reference count for each loaded library module.  
  
## Syntax  
  
```  
  
      BOOL AFXAPI AfxFreeLibrary(  
   HINSTANCE hInstLib   
);  
```  
  
#### Parameters  
 *hInstLib*  
 A handle of the loaded library module. [AfxLoadLibrary](../vs140/afxloadlibrary.md) returns this handle.  
  
## Return Value  
 **TRUE** if the function succeeds; otherwise, **FALSE**.  
  
## Remarks  
 `AfxFreeLibrary` decrements the reference count of the loaded dynamic-link library (DLL) module. When the reference count reaches zero, the module is unmapped from the address space of the calling process and the handle is no longer valid. This reference count is incremented each time `AfxLoadLibrary` is called.  
  
 Before unmapping a library module, the system enables the DLL to detach from the processes using it. Doing so gives the DLL an opportunity to clean up resources allocated on behalf of the current process. After the entry-point function returns, the library module is removed from the address space of the current process.  
  
 Use `AfxLoadLibrary` to map a DLL module.  
  
 Be sure to use `AfxFreeLibrary` and `AfxLoadLibrary` (instead of the Win32 functions **FreeLibrary** and **LoadLibrary**) if your application uses multiple threads. Using `AfxLoadLibrary` and `AfxFreeLibrary` ensures that the startup and shutdown code that executes when the extension DLL is loaded and unloaded does not corrupt the global MFC state.  
  
## Example  
 See the example for [AfxLoadLibrary](../vs140/afxloadlibrary.md).  
  
## Requirements  
 **Header:** afxdll_.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxLoadLibrary](../vs140/afxloadlibrary.md)