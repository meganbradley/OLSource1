---
title: "CDC::SetAbortProc"
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
  - "CDC.SetAbortProc"
  - "CDC::SetAbortProc"
  - "SetAbortProc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAbortProc method"
  - "CDC class, printer escape functions"
ms.assetid: 6b6dfdfb-9c53-4476-ba0c-d51107bf410f
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::SetAbortProc
Installs the abort procedure for the print job.  
  
## Syntax  
  
```  
  
      int SetAbortProc(  
   BOOL ( CALLBACK* lpfn )( HDC, int )  
);  
```  
  
#### Parameters  
 `lpfn`  
 A pointer to the abort function to install as the abort procedure. For more about the callback function, see [Callback Function for CDC::SetAbortProc](../vs140/callback-function-for-cdc--setabortproc.md).  
  
## Return Value  
 Specifies the outcome of the `SetAbortProc` function. Some of the following values are more probable than others, but all are possible.  
  
-   **SP_ERROR** General error.  
  
-   **SP_OUTOFDISK** Not enough disk space is currently available for spooling, and no more space will become available.  
  
-   **SP_OUTOFMEMORY** Not enough memory is available for spooling.  
  
-   **SP_USERABORT** User ended the job through the Print Manager.  
  
## Remarks  
 If an application is to allow the print job to be canceled during spooling, it must set the abort function before the print job is started with the [StartDoc](../vs140/cdc--startdoc.md) member function. The Print Manager calls the abort function during spooling to allow the application to cancel the print job or to process out-of-disk-space conditions. If no abort function is set, the print job will fail if there is not enough disk space for spooling.  
  
 Note that the features of Microsoft Visual C++ simplify the creation of the callback function passed to `SetAbortProc`. The address passed to the `EnumObjects` member function is a pointer to a function exported with **__declspec(dllexport)** and with the `__stdcall` calling convention.  
  
 You also do not have to export the function name in an **EXPORTS** statement in your application's module-definition file. You can instead use the **EXPORT** function modifier, as in  
  
 **BOOL CALLBACK EXPORT** AFunction( **HDC**, `int` **);**  
  
 to cause the compiler to emit the proper export record for export by name without aliasing. This works for most needs. For some special cases, such as exporting a function by ordinal or aliasing the export, you still need to use an **EXPORTS** statement in a module-definition file.  
  
 Callback registration interfaces are now type-safe (you must pass in a function pointer that points to the right kind of function for the specific callback).  
  
 Also note that all callback functions must trap Microsoft Foundation exceptions before returning to Windows, since exceptions cannot be thrown across callback boundaries. For more information about exceptions, see the article [Exceptions](../vs140/exception-handling-in-mfc.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)