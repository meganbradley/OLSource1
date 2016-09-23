---
title: "Troubleshooting Exceptions: Microsoft.VisualBasic.ApplicationServices.CantStartSingleInstanceException"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - CantStartSingleInstanceException exception
  - Microsoft.VisualBasic.ApplicationServices.CantStartSingleInstanceException exception
ms.assetid: 3639f15d-9547-43da-8145-60da34782991
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Troubleshooting Exceptions: Microsoft.VisualBasic.ApplicationServices.CantStartSingleInstanceException
The exception that is thrown when the second instance of a single-instance application could not connect to the original instance.  
  
## Remarks  
 Possible causes for this problem include:  
  
-   The original instance stopped responding.  
  
-   The application does not have permissions to create kernel objects.  
  
     The base name for the kernel objects comes from concatenating the assembly's GUID, major version number, and minor version number. For example, the base name could be 3639f15d-9547-43da-8145-60da347829915.1.  
  
## See Also  
 <xref:Microsoft.VisualBasic.ApplicationServices.CantStartSingleInstanceException?qualifyHint=False>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)