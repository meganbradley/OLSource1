---
title: "_mktemp_s, _wmktemp_s"
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
  - "_mktemp_s"
  - "_wmktemp_s"
apilocation: 
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wmktemp_s"
  - "mktemp_s"
  - "_mktemp_s"
  - "_wmktemp_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_tmktemp_s function"
  - "mktemp_s function"
  - "_wmktemp_s function"
  - "_mktemp_s function"
  - "files [C++], temporary"
  - "tmktemp_s function"
  - "wmktemp_s function"
  - "temporary files [C++]"
ms.assetid: 92a7e269-7f3d-4c71-bad6-14bc827a451d
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mktemp_s, _wmktemp_s
Creates a unique file name. These are versions of [_mktemp, _wmktemp](../vs140/_mktemp--_wmktemp.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 File name pattern.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Size of the buffer in single-byte characters in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>; wide characters in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, including the null terminator.  
  
## Return Value  
 Both of these functions return zero on success; an error code on failure.  
  
### Error Conditions  
  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|**return value**|**new value in template**|  
|----------------|-------------------|----------------------|-------------------------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|any|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|  
|Incorrect format (see <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> section for correct format)|any|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|empty string|  
|any|<= number of X's|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|empty string|  
  
 If any of the above error conditions occurs, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and the functions returns <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> function creates a unique file name by modifying the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> argument, so that after the call, the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> pointer points to a string containing the new file name. <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> automatically handles multibyte-character string arguments as appropriate, recognizing multibyte-character sequences according to the multibyte code page currently in use by the run-time system. <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>; the argument of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is a wide-character string. <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> behave identically otherwise, except that <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> does not handle multibyte-character strings.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|  
  
 The <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> argument has the form <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is the part of the new file name that you supply and each X is a placeholder for a character supplied by <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>. Each placeholder character in <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> must be an uppercase X. <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> preserves <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> and replaces the first trailing X with an alphabetic character. <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> replaces the following trailing X's with a five-digit value; this value is a unique number identifying the calling process, or in multithreaded programs, the calling thread.  
  
 Each successful call to <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> modifies <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. In each subsequent call from the same process or thread with the same <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> argument, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> checks for file names that match names returned by <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> in previous calls. If no file exists for a given name, <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> returns that name. If files exist for all previously returned names, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> creates a new name by replacing the alphabetic character it used in the previously returned name with the next available lowercase letter, in order, from 'a' through 'z'. For example, if <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> is:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 and the five-digit value supplied by <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> is 12345, the first name returned is:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If this name is used to create file FNA12345 and this file still exists, the next name returned on a call from the same process or thread with the same <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 If FNA12345 does not exist, the next name returned is again:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> can create a maximum of 26 unique file names for any given combination of base and template values. Therefore, FNZ12345 is the last unique file name <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> can create for the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> values used in this example.  
  
 In C++, using these functions is simplified by template overloads; the overloads can infer buffer length automatically (eliminating the need to specify a size argument) and they can automatically replace older, non-secure functions with their newer, secure counterparts. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|\<io.h>|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|\<io.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [File Handling](../vs140/file-handling.md)   
 [fopen, _wfopen](../vs140/fopen--_wfopen.md)   
 [_getmbcp](../vs140/_getmbcp.md)   
 [_getpid](../vs140/_getpid.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)   
 [_setmbcp](../vs140/_setmbcp.md)   
 [_tempnam, _wtempnam, tmpnam, _wtmpnam](../vs140/_tempnam--_wtempnam--tmpnam--_wtmpnam.md)   
 [tmpfile_s](../vs140/tmpfile_s.md)