---
title: "_get_dstbias"
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
  - "_get_dstbias"
  - "__dstbias"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "__dstbias"
  - "_get_dstbias"
  - "get_dstbias"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "__dstbias"
  - "daylight saving time offset"
  - "get_dstbias function"
  - "_get_dstbias function"
ms.assetid: e751358c-1ecc-411b-ae2c-81b2ec54ea45
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _get_dstbias
Retrieves the daylight saving time offset in seconds.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The offset in seconds of daylight saving time.  
  
## Return Value  
 Zero if successful or an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> value if an error occurs.  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function retrieves the number of seconds in daylight saving time as an integer. If daylight saving time is in effect, the default offset is 3600 seconds, which is the number of seconds in one hour (though a few regions do observe a two-hour offset).  
  
 If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the invalid parameter handler is invoked as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function sets <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 We recommend you use this function instead of the macro <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or the deprecated function <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|\<time.h>|  
  
 For more information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Time Management](../vs140/time-management.md)   
 [Global Variables _doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md)   
 [_get_daylight](../vs140/_get_daylight.md)   
 [_get_timezone](../vs140/_get_timezone.md)   
 [_get_tzname](../vs140/_get_tzname.md)