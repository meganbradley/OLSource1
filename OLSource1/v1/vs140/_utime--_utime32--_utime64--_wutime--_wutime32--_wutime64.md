---
title: "_utime, _utime32, _utime64, _wutime, _wutime32, _wutime64"
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
  - "_utime64"
  - "_utime"
  - "_wutime"
  - "_wutime64"
  - "_wutime32"
  - "_utime32"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_tutime"
  - "_utime64"
  - "wutime"
  - "utime32"
  - "wutime64"
  - "_utime"
  - "wutime32"
  - "_wutime"
  - "utime"
  - "utime64"
  - "_wutime64"
  - "_utime32"
  - "_tutime64"
  - "_wutime32"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "tutime function"
  - "utime32 function"
  - "utime64 function"
  - "_utime function"
  - "_tutime32 function"
  - "time [C++], file modification"
  - "wutime function"
  - "_wutime function"
  - "_wutime32 function"
  - "_tutime64 function"
  - "_tutime function"
  - "files [C++], modification time"
  - "_wutime64 function"
  - "_utime32 function"
  - "utime function"
  - "_utime64 function"
  - "wutime64 function"
  - "wutime32 function"
  - "tutime64 function"
  - "tutime32 function"
ms.assetid: 8d482d40-19b9-4591-bfee-5d7f601d1a9e
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _utime, _utime32, _utime64, _wutime, _wutime32, _wutime64
Set the file modification time.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to a string that contains the path or filename.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to stored time values.  
  
## Return Value  
 Each of these functions returns 0 if the file-modification time was changed. A return value of –1 indicates an error. If an invalid parameter is passed, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, these functions return -1 and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is set to one of the following values:  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Path specifies directory or read-only file  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Invalid <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> argument  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Too many open files (the file must be opened to change its modification time)  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Path or filename not found  
  
 See [_doserrno, errno, _sys_errlist, and _sys_nerr](../vs140/errno--_doserrno--_sys_errlist--and-_sys_nerr.md) for more information on these, and other, return codes.  
  
 The date can be changed for a file if the change date is after midnight, January 1, 1970, and before the end date of the function used. <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> use a 64-bit time value, so the end date is 23:59:59, December 31, 3000, UTC. If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is defined to force the old behavior, the end date is 23:59:59 January 18, 2038, UTC. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> use a 32-bit time type regardless of whether <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is defined, and always have the earlier end date. <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> always use the 64-bit time type, so these functions always support the later end date.  
  
## Remarks  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> function sets the modification time for the file specified by <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>*.* The process must have write access to the file in order to change the time. In the Windows operating system, you can change the access time and the modification time in the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> structure. If <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> pointer, the modification time is set to the current local time. Otherwise, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> must point to a structure of type <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, defined in SYS\UTIME.H.  
  
 The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> structure stores file access and modification times used by <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to change file-modification dates. The structure has the following fields, which are both of type <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>:  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Time of file access  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Time of file modification  
  
 Specific versions of the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> structure (<CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>) are defined using the 32-bit and 64-bit versions of the time type. These are used in the 32-bit and 64-bit specific versions of this function. <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> itself by default uses a 64-bit time type unless <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is defined.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is identical to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> except that the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> argument of <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is a filename or a path to a file, rather than a file descriptor of an open file.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>; the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> argument to <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is a wide-character string. These functions behave identically otherwise.  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required headers|Optional headers|  
|-------------|----------------------|----------------------|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|\<sys/utime.h>|\<errno.h>|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|\<sys/utime.h>|\<errno.h>|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|\<utime.h> or \<wchar.h>|\<errno.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 This program uses <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> to set the file-modification time to the current time.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Time Management](../vs140/time-management.md)   
 [asctime, _wasctime](../vs140/asctime--_wasctime.md)   
 [ctime, _ctime32, _ctime64, _wctime, _wctime32, _wctime64](../vs140/ctime--_ctime32--_ctime64--_wctime--_wctime32--_wctime64.md)   
 [_fstat, _fstat32, _fstat64, _fstati64, _fstat32i64, _fstat64i32](../vs140/_fstat--_fstat32--_fstat64--_fstati64--_fstat32i64--_fstat64i32.md)   
 [_ftime, _ftime32, _ftime64](../vs140/_ftime--_ftime32--_ftime64.md)   
 [_futime, _futime32, _futime64](../vs140/_futime--_futime32--_futime64.md)   
 [gmtime, _gmtime32, _gmtime64](../vs140/gmtime--_gmtime32--_gmtime64.md)   
 [localtime, _localtime32, _localtime64](../vs140/localtime--_localtime32--_localtime64.md)   
 [_stat, _wstat Functions](../vs140/99a75ae6-ff26-47ad-af70-5ea7e17226a5.md)   
 [time, _time32, _time64](../vs140/time--_time32--_time64.md)