---
title: "difftime, _difftime32, _difftime64"
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
  - "_difftime32"
  - "difftime"
  - "_difftime64"
apilocation: 
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_difftime64"
  - "difftime"
  - "difftime64"
  - "_difftime32"
  - "difftime32"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_difftime32 function"
  - "difftime function"
  - "time, finding the difference"
  - "difftime64 function"
  - "_difftime64 function"
  - "difftime32 function"
ms.assetid: 4cc0ac2b-fc7b-42c0-8283-8c9d10c566d0
caps.latest.revision: 23
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# difftime, _difftime32, _difftime64
Finds the difference between two times.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Ending time.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Beginning time.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> returns the elapsed time in seconds, from <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The value returned is a double precision floating-point number. The return value may be 0, indicating an error.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function computes the difference between the two supplied time values <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 The time value supplied must fit within the range of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is a 64-bit value. Thus, the end of the range was extended from 23:59:59 January 18, 2038, UTC to 23:59:59, December 31, 3000. The lower range of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is still midnight, January 1, 1970.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is an inline function that evaluates to either <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> depending on whether <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is defined. _difftime32 and _difftime64 can be used directly to force the use of a particular size of the time type.  
  
 These functions validate their parameters. If either of the parameters is zero or negative, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return 0 and set <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|\<time.h>|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|\<time.h>|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|\<time.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Using random floating point numbers 1.04749e+038 2.01482e+038 1.72737e+038Multiplying 2 floating point numbers 100 million times...Program takes      3 seconds.Multiplying 2 floating point numbers 500 million times...**  
**Program takes      5 seconds.**   
## .NET Framework Equivalent  
 [System::DateTime::Subtract](https://msdn.microsoft.com/en-us/library/system.datetime.subtract.aspx)  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)   
 [Time Management](../vs140/time-management.md)   
 [time, _time32, _time64](../vs140/time--_time32--_time64.md)