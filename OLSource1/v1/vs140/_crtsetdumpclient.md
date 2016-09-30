---
title: "_CrtSetDumpClient"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "_CrtSetDumpClient"
apilocation: 
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_CrtSetDumpClient"
  - "CrtSetDumpClient"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_CrtSetDumpClient function"
  - "CrtSetDumpClient function"
ms.assetid: f3dd06d0-c331-4a12-b68d-25378d112033
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _CrtSetDumpClient
Installs an application-defined function to dump <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> type memory blocks (debug version only).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 New client-defined memory dump function to hook into the C run-time debug memory dump process.  
  
## Return Value  
 Returns the previously defined client block dump function.  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function allows the application to hook its own function to dump objects stored in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> memory blocks into the C run-time debug memory dump process. As a result, every time a debug dump function such as [_CrtMemDumpAllObjectsSince](../vs140/_crtmemdumpallobjectssince.md) or [_CrtDumpMemoryLeaks](../vs140/_crtdumpmemoryleaks.md) dumps a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> memory block, the application's dump function is called as well. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> provides an application with an easy method for detecting memory leaks and validating or reporting the contents of data stored in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> blocks. When [_DEBUG](../vs140/_debug.md) is not defined, calls to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> are removed during preprocessing.  
  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function installs the new application-defined dump function specified in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and returns the previously defined dump function. An example of a client block dump function is as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> argument is a pointer to the beginning of the user data portion of the memory block and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> specifies the size of the allocated memory block in bytes. The client block dump function must return <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. The pointer to the client dump function that is passed to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is of type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, as defined in Crtdbg.h:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 For more information about functions that operate on <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> type memory blocks, see [Client Block Hook Functions](../vs140/client-block-hook-functions.md). The [_CrtReportBlockType](../vs140/_crtreportblocktype.md) function can be used to return information about block types and subtypes.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|\<crtdbg.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Libraries  
 Debug versions of [C run-time libraries](../vs140/crt-library-features.md) only.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Debug Routines](../vs140/debug-routines.md)   
 [_CrtReportBlockType](../vs140/_crtreportblocktype.md)   
 [_CrtGetDumpClient](../vs140/_crtgetdumpclient.md)