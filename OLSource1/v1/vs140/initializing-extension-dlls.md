---
title: "Initializing Extension DLLs"
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
helpviewer_keywords: 
  - "DLLs [C++], extension"
  - "initializing DLLs"
  - "extension DLLs [C++], initializing"
ms.assetid: 08ad0381-3808-4bea-a93c-c9ba62496543
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Initializing Extension DLLs
Because extension DLLs do not have a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>-derived object (as do regular DLLs), you should add your initialization and termination code to the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function that the MFC DLL Wizard generates.  
  
 The wizard provides the following code for extension DLLs. In the code, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is a placeholder for the name of your project.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Creating a new **CDynLinkLibrary** object during initialization allows the extension DLL to export <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> objects or resources to the client application.  
  
 If you are going to use your extension DLL from one or more regular DLLs, you must export an initialization function that creates a **CDynLinkLibrary** object. That function must be called from each of the regular DLLs that use the extension DLL. An appropriate place to call this initialization function is in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> member function of the regular DLL's <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>-derived object before using any of the extension DLL's exported classes or functions.  
  
 In the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> that the MFC DLL Wizard generates, the call to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> captures the module's run-time classes (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> structures) as well as its object factories (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> objects) for use when the **CDynLinkLibrary** object is created. You should check the return value of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>; if a zero value is returned from <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, return zero from your <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function.  
  
 If your extension DLL will be explicitly linked to an executable (meaning the executable calls <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to link to the DLL), you should add a call to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> on **DLL_PROCESS_DETACH**. This function allows MFC to clean up the extension DLL when each process detaches from the extension DLL (which happens when the process exits or when the DLL is unloaded as a result of a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> call). If your extension DLL will be linked implicitly to the application, the call to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is not necessary.  
  
 Applications that explicitly link to extension DLLs must call **AfxTermExtensionModule** when freeing the DLL. They should also use <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> (instead of the Win32 functions **LoadLibrary** and **FreeLibrary**) if the application uses multiple threads. Using <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> ensures that the startup and shutdown code that executes when the extension DLL is loaded and unloaded does not corrupt the global MFC state.  
  
 Because the MFCx0.dll is fully initialized by the time <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is called, you can allocate memory and call MFC functions within <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> (unlike the 16-bit version of MFC).  
  
 Extension DLLs can take care of multithreading by handling the **DLL_THREAD_ATTACH** and **DLL_THREAD_DETACH** cases in the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> function. These cases are passed to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> when threads attach and detach from the DLL. Calling [TlsAlloc](http://msdn.microsoft.com/library/windows/desktop/ms686801) when a DLL is attaching allows the DLL to maintain thread local storage (TLS) indexes for every thread attached to the DLL.  
  
 Note that the header file Afxdllx.h contains special definitions for structures used in extension DLLs, such as the definition for <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and **CDynLinkLibrary**. You should include this header file in your extension DLL.  
  
> [!NOTE]
>  It is important that you neither define nor undefine any of the _AFX_NO_XXX macros in Stdafx.h. For more information, see the Knowledge Base article "PRB: Problems Occur When Defining _AFX_NO_XXX" (Q140751). You can find Knowledge Base articles in the MSDN Library or at [http://search.support.microsoft.com/](http://search.support.microsoft.com/).  
  
 A sample initialization function that handles multithreading is included in [Using Thread Local Storage in a Dynamic-Link Library](http://msdn.microsoft.com/library/windows/desktop/ms686997) in the [!INCLUDE[winsdkshort](../vs140/includes/winsdkshort_md.md)]. Note that the sample contains an entry-point function called **LibMain**, but you should name this function <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> so that it works with the MFC and C run-time libraries.  
  
 The MFC sample [DLLHUSK](assetId:///dfcaa6ff-b8e2-4efd-8100-ee3650071f90) demonstrates the use of initialization functions.  
  
## What do you want to do?  
  
-   [Initialize regular DLLs](../vs140/initializing-regular-dlls.md)  
  
-   [Initialize non-MFC DLLs](../vs140/initializing-non-mfc-dlls.md)  
  
## What do you want to know more about?  
  
-   [The C run-time library behavior and _DllMainCRTStartup](../vs140/run-time-library-behavior.md)  
  
-   [Using Database, OLE, and Sockets Extension DLLs in Regular DLLs](../vs140/using-database--ole--and-sockets-extension-dlls-in-regular-dlls.md)  
  
-   [The function specification for DllMain (Windows SDK)](http://msdn.microsoft.com/library/windows/desktop/ms682583)  
  
-   [Dynamic-link library entry-point function (Windows SDK)](http://msdn.microsoft.com/library/windows/desktop/ms682596)  
  
## See Also  
 [Initializing a DLL](../vs140/initializing-a-dll.md)