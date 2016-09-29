---
title: "CDC::AbortDoc"
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
  - "AbortDoc"
  - "CDC::AbortDoc"
  - "CDC.AbortDoc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, printer escape functions"
  - "AbortDoc method"
ms.assetid: 1aeec43f-e8ed-4264-89df-d69420fcad66
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::AbortDoc
Terminates the current print job and erases everything the application has written to the device since the last call to the [StartDoc](../vs140/cdc--startdoc.md) member function.  
  
## Syntax  
  
```  
  
int AbortDoc( );  
```  
  
## Return Value  
 A value greater than or equal to 0 if successful, or a negative value if an error has occurred. The following list shows common error values and their meanings:  
  
-   **SP_ERROR** General error.  
  
-   **SP_OUTOFDISK** Not enough disk space is currently available for spooling, and no more space will become available.  
  
-   **SP_OUTOFMEMORY** Not enough memory is available for spooling.  
  
-   **SP_USERABORT** User terminated the job through the Print Manager.  
  
## Remarks  
 This member function replaces the `ABORTDOC` printer escape.  
  
 **AbortDoc** should be used to terminate the following:  
  
-   Printing operations that do not specify an abort function using [SetAbortProc](../vs140/cdc--setabortproc.md).  
  
-   Printing operations that have not yet reached their first **NEWFRAME** or **NEXTBAND** escape call.  
  
 If an application encounters a printing error or a canceled print operation, it must not attempt to terminate the operation by using either the [EndDoc](../vs140/cdc--enddoc.md) or **AbortDoc** member functions of class `CDC`. GDI automatically terminates the operation before returning the error value.  
  
 If the application displays a dialog box to allow the user to cancel the print operation, it must call **AbortDoc** before destroying the dialog box.  
  
 If Print Manager was used to start the print job, calling **AbortDoc** erases the entire spool job — the printer receives nothing. If Print Manager was not used to start the print job, the data may have been sent to the printer before **AbortDoc** was called. In this case, the printer driver would have reset the printer (when possible) and closed the print job.  
  
## Example  
 See the example for [CDC::StartDoc](../vs140/cdc--startdoc.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::StartDoc](../vs140/cdc--startdoc.md)   
 [CDC::EndDoc](../vs140/cdc--enddoc.md)   
 [CDC::SetAbortProc](../vs140/cdc--setabortproc.md)