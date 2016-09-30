---
title: "_endthread, _endthreadex"
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
  - "_endthread"
  - "_endthreadex"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_endthread"
  - "endthreadex"
  - "_endthreadex"
  - "endthread"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_endthread function"
  - "endthread function"
  - "terminating threads"
  - "endthreadex function"
  - "_endthreadex function"
  - "threading [C++], terminating threads"
ms.assetid: 18a91f2f-659e-40b4-b266-ec12dcf2abf5
caps.latest.revision: 25
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _endthread, _endthreadex
Terminates a thread; <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> terminates a thread that's created by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> terminates a thread that's created by<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Thread exit code.  
  
## Remarks  
 You can call <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> explicitly to terminate a thread; however, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is called automatically when the thread returns from the routine passed as a parameter to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. Terminating a thread with a call to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> helps ensure proper recovery of resources allocated for the thread.  
  
> [!NOTE]
>  For an executable file linked with Libcmt.lib, do not call the Win32 [ExitThread](http://msdn.microsoft.com/library/windows/desktop/ms682659.aspx) API; this prevents the run-time system from reclaiming allocated resources. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> reclaim allocated thread resources and then call <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> automatically closes the thread handle. (This behavior differs from the Win32 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> API.) Therefore, when you use <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, do not explicitly close the thread handle by calling the Win32 [CloseHandle](http://msdn.microsoft.com/library/windows/desktop/ms724211.aspx) API.  
  
 Like the Win32 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> API, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> does not close the thread handle. Therefore, when you use <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, you must close the thread handle by calling the Win32 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> API.  
  
> [!NOTE]
>  <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> cause C++ destructors pending in the thread not to be called.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|\<process.h>|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|\<process.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Libraries  
 Multithreaded versions of the [C run-time libraries](../vs140/crt-library-features.md) only.  
  
## Example  
 See the example for [_beginthread](../vs140/_beginthread--_beginthreadex.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Process and Environment Control](../vs140/process-and-environment-control.md)   
 [_beginthread, _beginthreadex](../vs140/_beginthread--_beginthreadex.md)