---
title: "_mktemp, _wmktemp"
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
  - "_wmktemp"
  - "_mktemp"
apilocation: 
  - "msvcr80.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_tmktemp"
  - "wmktemp"
  - "tmktemp"
  - "_wmktemp"
  - "_mktemp"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_wmktemp function"
  - "_mktemp function"
  - "files [C++], temporary"
  - "tmktemp function"
  - "_tmktemp function"
  - "wmktemp function"
  - "mktemp function"
  - "temporary files [C++]"
ms.assetid: 055eb539-a8c2-4a7d-be54-f5b6d1eb5c85
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mktemp, _wmktemp
Creates a unique file name. More secure versions of these functions are available; see [_mktemp_s, _wmktemp_s](../vs140/_mktemp_s--_wmktemp_s.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 File name pattern.  
  
## Return Value  
 Each of these functions returns a pointer to the modified template. The function returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is badly formed or no more unique names can be created from the given template.  
  
## Remarks  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function creates a unique file name by modifying the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> argument. <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> automatically handles multibyte-character string arguments as appropriate, recognizing multibyte-character sequences according to the multibyte code page currently in use by the run-time system. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>; the argument and return value of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> are wide-character strings. <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> behave identically otherwise, except that <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> does not handle multibyte-character strings.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
  
 The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> argument has the form <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>XXXXXX, where <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is the part of the new file name that you supply and each X is a placeholder for a character supplied by <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. Each placeholder character in <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> must be an uppercase X. <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> preserves <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and replaces the first trailing X with an alphabetic character. <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> replaces the following trailing X's with a five-digit value; this value is a unique number identifying the calling process, or in multithreaded programs, the calling thread.  
  
 Each successful call to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> modifies <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. In each subsequent call from the same process or thread with the same <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> argument, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> checks for file names that match names returned by <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> in previous calls. If no file exists for a given name, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> returns that name. If files exist for all previously returned names, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> creates a new name by replacing the alphabetic character it used in the previously returned name with the next available lowercase letter, in order, from 'a' through 'z'. For example, if <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 and the five-digit value supplied by <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is 12345, the first name returned is:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If this name is used to create file FNA12345 and this file still exists, the next name returned on a call from the same process or thread with the same <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 If FNA12345 does not exist, the next name returned is again:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> can create a maximum of 26 unique file names for any given combination of base and template values. Therefore, FNZ12345 is the last unique file name <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> can create for the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> values used in this example.  
  
 On failure, <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> is set. If <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> has an invalid format (for example, fewer than 6 X's), <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is unable to create a unique name because all 26 possible file names already exist, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> sets template to an empty string and returns <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
 In C++, these functions have template overloads that invoke the newer, secure counterparts of these functions. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|\<io.h>|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|\<io.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 **Unique filename is fna03912**  
**Unique filename is fnb03912**  
**Unique filename is fnc03912**  
**Unique filename is fnd03912**  
**Unique filename is fne03912**  
**Unique filename is fnf03912**  
**Unique filename is fng03912**  
**Unique filename is fnh03912**  
**Unique filename is fni03912**  
**Unique filename is fnj03912**  
**Unique filename is fnk03912**  
**Unique filename is fnl03912**  
**Unique filename is fnm03912**  
**Unique filename is fnn03912**  
**Unique filename is fno03912**  
**Unique filename is fnp03912**  
**Unique filename is fnq03912**  
**Unique filename is fnr03912**  
**Unique filename is fns03912**  
**Unique filename is fnt03912**  
**Unique filename is fnu03912**  
**Unique filename is fnv03912**  
**Unique filename is fnw03912**  
**Unique filename is fnx03912**  
**Unique filename is fny03912**  
**Unique filename is fnz03912**  
**Problem creating the template.**  
**Out of unique filenames.**   
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [File Handling](../vs140/file-handling.md)   
 [fopen, _wfopen](../vs140/fopen--_wfopen.md)   
 [_getmbcp](../vs140/_getmbcp.md)   
 [_getpid](../vs140/_getpid.md)   
 [_open, _wopen](../vs140/_open--_wopen.md)   
 [_setmbcp](../vs140/_setmbcp.md)   
 [_tempnam, _wtempnam, tmpnam, _wtmpnam](../vs140/_tempnam--_wtempnam--tmpnam--_wtmpnam.md)   
 [tmpfile](../vs140/tmpfile.md)