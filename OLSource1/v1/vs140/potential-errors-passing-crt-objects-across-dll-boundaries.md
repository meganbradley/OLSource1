---
title: "Potential Errors Passing CRT Objects Across DLL Boundaries"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "DLL conflicts [C++]"
ms.assetid: c217ffd2-5d9a-4678-a1df-62a637a96460
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Potential Errors Passing CRT Objects Across DLL Boundaries
When you pass C Run-time (CRT) objects such as file handles, locales, and environment variables into or out of a DLL (function calls across the DLL boundary), unexpected behavior can occur if the DLL, as well as the files calling into the DLL, use different copies of the CRT libraries.  
  
 A related problem can occur when you allocate memory (either explicitly with <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, or implicitly with <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and so on) and then pass a pointer across a DLL boundary to be freed. This can cause a memory access violation or heap corruption if the DLL and its users use different copies of the CRT libraries.  
  
 Another symptom of this problem can be an error in the output window during debugging such as:  
  
 HEAP[]: Invalid Address specified to RtlValidateHeap(#,#)  
  
## Causes  
 Each copy of the CRT library has a separate and distinct state. As such, CRT objects such as file handles, environment variables, and locales are only valid for the copy of the CRT where these objects are allocated or set. When a DLL and its users use different copies of the CRT library, you cannot pass these CRT objects across the DLL boundary and expect them to be picked up correctly on the other side.  
  
 Also, because each copy of the CRT library has its own heap manager, allocating memory in one CRT library and passing the pointer across a DLL boundary to be freed by a different copy of the CRT library is a potential cause for heap corruption.  
  
 If you design your DLL so that it passes CRT objects across the boundary or allocates memory and expects it to be freed outside the DLL, you restrict the DLL users to use the same copy of the CRT library as the DLL. The DLL and its users use the same copy of the CRT library only if both are linked with the same version of the CRT DLL. This could be a problem if you mix applications built with Visual C++ 5.0 with DLLs that are built by Visual C++ 4.1 or earlier. Because the DLL version of the CRT library used by Visual C++ 4.1 is msvcrt40.dll and the one used by Visual 5.0 is msvcrt.dll, you cannot build your application to use the same copy of the CRT library as these DLLs.  
  
 However, there is an exception. In US English version and some other localized versions of Windows 2000, such as German, French, and Czech, a forwarder version of the msvcrt40.dll (version 4.20) is shipped. As a result, even though the DLL is linked with msvcrt40.dll and its user is linked with msvcrt.dll, you are still using the same copy of the CRT library because all calls made to msvcrt40.dll are forwarded to msvcrt.dll.  
  
 However this forwarder version of msvcrt40.dll is not available in some localized versions of Windows 2000, such as Japanese, Korean, and Chinese. So, if your application targets these operating systems, you need to either obtain an upgraded version of the DLL that doesn't rely on msvcrt40.dll or alter your application to not rely on using the same copy of the CRT libraries. If you have developed the DLL, this means rebuilding it with Visual C++ 4.2 or later. If it is a third- party DLL, you need to contact your vendor for an upgrade.  
  
 Please note that this forwarder DLL version of msvcrt40.dll (version 4.20) cannot be redistributed.  
  
## Example  
  
### Description  
 This example passes a file handle across a DLL boundary.  
  
 The DLL and .exe file are built with /MD, so they share a single copy of the CRT.  
  
 If you rebuild with /MT so that they use separate copies of the CRT, running the resulting test1Main.exe results in an access violation.  
  
### Code  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Code  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
  
### Description  
 This example passes environment variables across a DLL boundary.  
  
### Code  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Code  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 If both the DLL and .exe file are built with /MD so that only one copy of the CRT is used, the program runs successfully and produces the following output:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## See Also  
 [C Run-Time Libraries](../vs140/crt-library-features.md)