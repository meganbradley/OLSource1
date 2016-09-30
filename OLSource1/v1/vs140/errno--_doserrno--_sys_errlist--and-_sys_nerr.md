---
title: "errno, _doserrno, _sys_errlist, and _sys_nerr"
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
  - "_errno"
apilocation: 
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_sys_errlist"
  - "errno"
  - "_sys_nerr"
  - "_doserrno"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "error codes, printing"
  - "sys_errlist global variable"
  - "doserrno global variable"
  - "errno global variable"
  - "_doserrno global variable"
  - "_sys_errlist global variable"
  - "_sys_nerr global variable"
  - "sys_nerr global variable"
ms.assetid: adbec641-6d91-4e19-8398-9a34046bd369
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# errno, _doserrno, _sys_errlist, and _sys_nerr
Global macros that hold error codes that are set during program execution, and string equivalents of the error codes for display.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Both <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> are set to 0 by the runtime during program startup. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is set on an error in a system-level call. Because <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> holds the value for the last call that set it, this value may be changed by succeeding calls. Run-time library calls that set <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> on an error do not clear <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> on success. Always clear <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> by calling <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> immediately before a call that may set it, and check it immediately after the call.  
  
 On an error, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is not necessarily set to the same value as the error code returned by a system call. For I/O operations, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> stores the operating-system error-code equivalents of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> codes. For most non-I/O operations, the value of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is not set.  
  
 Each <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> value is associated with an error message in <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> that can be printed by using one of the [perror](../vs140/perror--_wperror.md) functions, or stored in a string by using one of the [strerror](../vs140/strerror--_strerror--_wcserror--__wcserror.md) or [strerror_s](../vs140/strerror_s--_strerror_s--_wcserror_s--__wcserror_s.md) functions. The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> functions use the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> array and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>—the number of elements in <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>—to process error information. Direct access to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is deprecated for code-security reasons. We recommend that you use the more secure, functional versions instead of the global macros, as shown here:  
  
|Global Macro|Functional Equivalents|  
|------------------|----------------------------|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|[_get_doserrno](../vs140/_get_doserrno.md), [_set_doserrno](../vs140/_set_doserrno.md)|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|[_get_errno](../vs140/_get_errno.md), [_set_errno](../vs140/_set_errno.md)|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|[strerror_s, _strerror_s, _wcserror_s, \__wcserror_s](../vs140/strerror_s--_strerror_s--_wcserror_s--__wcserror_s.md)|  
  
 Library math routines set <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> by calling [_matherr](../vs140/_matherr.md). To handle math errors differently, write your own routine according to the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> reference description and name it <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
 All <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> values in the following table are predefined constants in \<errno.h>, and are UNIX-compatible. Only <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> are specified in the ISO C99 standard.  
  
|Constant|System error message|Value|  
|--------------|--------------------------|-----------|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Operation not permitted|1|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|No such file or directory|2|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|No such process|3|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|Interrupted function|4|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|I/O error|5|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|No such device or address|6|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|Argument list too long|7|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|Exec format error|8|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|Bad file number|9|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|No spawned processes|10|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|No more processes or not enough memory or maximum nesting level reached|11|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|Not enough memory|12|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|Permission denied|13|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|Bad address|14|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|Device or resource busy|16|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|File exists|17|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|Cross-device link|18|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|No such device|19|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|Not a directory|20|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|Is a directory|21|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|Invalid argument|22|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|Too many files open in system|23|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|Too many open files|24|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|Inappropriate I/O control operation|25|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|File too large|27|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|No space left on device|28|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|Invalid seek|29|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|Read-only file system|30|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|Too many links|31|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|Broken pipe|32|  
|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|Math argument|33|  
|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|Result too large|34|  
|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|Resource deadlock would occur|36|  
|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|Same as EDEADLK for compatibility with older Microsoft C versions|36|  
|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|Filename too long|38|  
|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|No locks available|39|  
|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|Function not supported|40|  
|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|Directory not empty|41|  
|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|Illegal byte sequence|42|  
|<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>|String was truncated|80|  
  
## Requirements  
  
|Global macro|Required header|Optional header|  
|------------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>|\<errno.h> or \<stdlib.h>, \<cerrno> or \<cstdlib> (C++)||  
|<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>|\<stdlib.h>, \<cstdlib> (C++)|\<errno.h>, \<cerrno> (C++)|  
  
 The <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> macros are Microsoft extensions. For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Global Variables](../vs140/global-variables.md)   
 [errno Constants](../vs140/errno-constants.md)   
 [perror, _wperror](../vs140/perror--_wperror.md)   
 [strerror, _strerror, _wcserror, \__wcserror](../vs140/strerror--_strerror--_wcserror--__wcserror.md)   
 [strerror_s, _strerror_s, _wcserror_s, \__wcserror_s](../vs140/strerror_s--_strerror_s--_wcserror_s--__wcserror_s.md)   
 [_get_doserrno](../vs140/_get_doserrno.md)   
 [_set_doserrno](../vs140/_set_doserrno.md)   
 [_get_errno](../vs140/_get_errno.md)   
 [_set_errno](../vs140/_set_errno.md)