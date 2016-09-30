---
title: "_futime, _futime32, _futime64"
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
  - "_futime64"
  - "_futime32"
  - "_futime"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "futime"
  - "_futime"
  - "futime64"
  - "_futime64"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_futime function"
  - "futime32 function"
  - "futime64 function"
  - "file modification time [C++]"
  - "_futime64 function"
  - "futime function"
  - "_futime32 function"
ms.assetid: b942ce8f-5cc7-4fa8-ab47-de5965eded53
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _futime, _futime32, _futime64
Sets the modification time on an open file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 File descriptor to the open file.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to the structure containing the new modification date.  
  
## Return Value  
 Return 0 if successful. If an error occurs, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the function returns –1 and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, indicating an invalid file descriptor, or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, indicating an invalid parameter.  
  
## Remarks  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> routine sets the modification date and the access time on the open file associated with <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>*.* <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is identical to [_utime](../vs140/_utime--_utime32--_utime64--_wutime--_wutime32--_wutime64.md), except that its argument is the file descriptor of an open file, rather than the name of a file or a path to a file. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> structure contains fields for the new modification date and access time. Both fields must contain valid values. <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> are identical to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> except for the use of the 32-bit and 64-bit time types, respectively. <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> use a 64-bit time type and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is identical in behavior to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. If you need to force the old behavior, define <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. Doing this causes <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to be identical in behavior to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and causes the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> structure to use the 32-bit time type, making it equivalent to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, which uses the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> structure, can read and modify file dates through 23:59:59, December 31, 3000, UTC; whereas a call to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> fails if the date on the file is later than 23:59:59 January 18, 2038, UTC. Midnight, January 1, 1970, is the lower bound of the date range for these functions.  
  
## Requirements  
  
|Function|Required header|Optional header|  
|--------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|\<sys/utime.h>|\<errno.h>|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|\<sys/utime.h>|\<errno.h>|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|\<sys/utime.h>|\<errno.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Input: crt_futime.c_input  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Sample Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
  
-   [System::IO::File::SetLastAccessTime](https://msdn.microsoft.com/en-us/library/system.io.file.setlastaccesstime.aspx)  
  
-   [System::IO::File::SetLastWriteTime](https://msdn.microsoft.com/en-us/library/system.io.file.setlastwritetime.aspx)  
  
-   [System::IO::File::SetCreationTime](https://msdn.microsoft.com/en-us/library/system.io.file.setcreationtime.aspx)  
  
## See Also  
 [Time Management](../vs140/time-management.md)