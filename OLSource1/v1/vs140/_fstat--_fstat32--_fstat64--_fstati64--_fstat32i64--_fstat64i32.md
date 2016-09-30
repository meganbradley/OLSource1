---
title: "_fstat, _fstat32, _fstat64, _fstati64, _fstat32i64, _fstat64i32"
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
  - "_fstat32"
  - "_fstat64"
  - "_fstati64"
  - "_fstat"
  - "_fstat64i32"
  - "_fstat32i64"
apilocation: 
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_fstat32i64"
  - "fstat"
  - "fstat64i32"
  - "_fstat64"
  - "_fstati64"
  - "fstat64"
  - "_fstat32"
  - "fstat32i64"
  - "fstati64"
  - "_fstat"
  - "fstat32"
  - "_fstat64i32"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_fstat64 function"
  - "fstati64 function"
  - "_fstat64i32 function"
  - "_fstat32i64 function"
  - "_fstat32 function"
  - "file information"
  - "fstat64i32 function"
  - "fstat32 function"
  - "fstat function"
  - "fstat64 function"
  - "_fstat function"
  - "_fstati64 function"
  - "fstat32i64 function"
ms.assetid: 088f5e7a-9636-4cf7-ab8e-e28d2aa4280a
caps.latest.revision: 25
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# _fstat, _fstat32, _fstat64, _fstati64, _fstat32i64, _fstat64i32
Gets information about an open file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 File descriptor of the open file.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to the structure to store results.  
  
## Return Value  
 Returns 0 if the file-status information is obtained. A return value of –1 indicates an error. If the file descriptor is invalid or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, in the case of an invalid file descriptor, or to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, if <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function obtains information about the open file associated with <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and stores it in the structure pointed to by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> structure, defined in SYS\Stat.h, contains the following fields.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Time of the last file access.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Time of the creation of the file.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 If a device, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>; otherwise 0.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Bit mask for file-mode information. The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> bit is set if <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> refers to a device. The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> bit is set if <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> refers to an ordinary file. The read/write bits are set according to the file's permission mode. <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and other constants are defined in SYS\Stat.h.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Time of the last modification of the file.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Always 1 on non-NTFS file systems.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 If a device, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>; otherwise 0.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Size of the file in bytes.  
  
 If <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> refers to a device, the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> fields are not meaningful.  
  
 Because Stat.h uses the [_dev_t](../vs140/standard-types.md) type, which is defined in Types.h, you must include Types.h before Stat.h in your code.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, which uses the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> structure, allows file-creation dates to be expressed up through 23:59:59, December 31, 3000, UTC; whereas the other functions only represent dates through 23:59:59 January 18, 2038, UTC. Midnight, January 1, 1970, is the lower bound of the date range for all these functions.  
  
 Variations of these functions support 32-bit or 64-bit time types and 32-bit or 64-bit file lengths. The first numerical suffix (<CodeContentPlaceHolder>37\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>) indicates the size of the time type used; the second suffix is either <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, indicating whether the file size is represented as a 32-bit or 64-bit integer.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is equivalent to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> contains a 64-bit time. This is true unless <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is defined, in which case the old behavior is in effect; <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> uses a 32-bit time, and <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> contains a 32-bit time. The same is true for <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
### Time Type and File Length Type Variations of _stat  
  
|Functions|_USE_32BIT_TIME_T defined?|Time type|File length type|  
|---------------|------------------------------------|---------------|----------------------|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|Not defined|64-bit|32-bit|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|Defined|32-bit|32-bit|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|Not affected by the macro definition|32-bit|32-bit|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|Not affected by the macro definition|64-bit|64-bit|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|Not defined|64-bit|64-bit|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|Defined|32-bit|64-bit|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|Not affected by the macro definition|32-bit|64-bit|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|Not affected by the macro definition|64-bit|32-bit|  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|\<sys/stat.h> and \<sys/types.h>|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|\<sys/stat.h> and \<sys/types.h>|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|\<sys/stat.h> and \<sys/types.h>|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|\<sys/stat.h> and \<sys/types.h>|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|\<sys/stat.h> and \<sys/types.h>|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|\<sys/stat.h> and \<sys/types.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **File size     : 16**  
**Time modified : Wed May 07 15:25:11 2003**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [File Handling](../vs140/file-handling.md)   
 [_access, _waccess](../vs140/_access--_waccess.md)   
 [_chmod, _wchmod](../vs140/_chmod--_wchmod.md)   
 [_filelength, _filelengthi64](../vs140/_filelength--_filelengthi64.md)   
 [_stat, _wstat Functions](../vs140/99a75ae6-ff26-47ad-af70-5ea7e17226a5.md)