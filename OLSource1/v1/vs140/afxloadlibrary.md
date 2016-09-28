---
title: "AfxLoadLibrary"
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
  - "AfxLoadLibrary"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "mappings [C++], DLL module"
  - "AfxLoadLibrary function"
  - "DLL modules [C++], mapping"
  - "DLL modules [C++]"
ms.assetid: 1339678b-c843-4474-b9c9-8f3bd9905e2e
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxLoadLibrary
Use `AfxLoadLibrary` to map a DLL module.  
  
## Syntax  
  
```  
  
      HINSTANCE AFXAPI AfxLoadLibrary(  
   LPCTSTR lpszModuleName   
);  
```  
  
#### Parameters  
 *lpszModuleName*  
 Points to a null-terminated string that contains the name of the module (either a .DLL or .EXE file). The name specified is the filename of the module.  
  
 If the string specifies a path but the file does not exist in the specified directory, the function fails.  
  
 If a path is not specified and the filename extension is omitted, the default extension .DLL is appended. However, the filename string can include a trailing point character (.) to indicate that the module name has no extension. When no path is specified, the function searches for the file in the following sequence:  
  
-   The directory from which the application loaded.  
  
-   The current directory.  
  
-   **Windows 95/98:** The Windows system directory. **Windows NT:** The 32-bit Windows system directory. The name of this directory is SYSTEM32.  
  
-   **Windows NT only:** The 16-bit Windows system directory. There is no Win32 function that obtains the path of this directory, but it is searched. The name of this directory is SYSTEM.  
  
-   The Windows directory.  
  
-   The directories that are listed in the PATH environment variable.  
  
## Return Value  
 If the function succeeds, the return value is a handle to the module. If the function fails, the return value is NULL.  
  
## Remarks  
 It returns a handle that can be used in [GetProcAddress](http://msdn.microsoft.com/library/windows/desktop/ms683212) to get the address of a DLL function. `AfxLoadLibrary` can also be used to map other executable modules.  
  
 Each process maintains a reference count for each loaded library module. This reference count is incremented each time `AfxLoadLibrary` is called and is decremented each time `AfxFreeLibrary` is called. When the reference count reaches zero, the module is unmapped from the address space of the calling process and the handle is no longer valid.  
  
 Be sure to use `AfxLoadLibrary` and `AfxFreeLibrary` (instead of the Win32 functions **LoadLibrary** and **FreeLibrary**) if your application uses multiple threads and if it dynamically loads an extension DLL. Using `AfxLoadLibrary` and `AfxFreeLibrary` insures that the startup and shutdown code that executes when the extension DLL is loaded and unloaded does not corrupt the global MFC state.  
  
 Using `AfxLoadLibrary` in an application requires you to dynamically link to the DLL version of MFC; the header file for `AfxLoadLibrary`, Afxdll_.h, is only included if MFC is linked to the application as a DLL. This is by design because you have to link to the DLL version of MFC to use or create extension DLLs.  
  
## Example  
 [!code[NVC_MFC_DLLUser#1](../vs140/codesnippet/CPP/afxloadlibrary_1.cpp)]  
[!code[NVC_MFC_DLLUser#2](../vs140/codesnippet/CPP/afxloadlibrary_2.cpp)]  
[!code[NVC_MFC_DLLUser#3](../vs140/codesnippet/CPP/afxloadlibrary_3.cpp)]  
  
## Requirements  
 **Header:** afxdll_.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxFreeLibrary](../vs140/afxfreelibrary.md)