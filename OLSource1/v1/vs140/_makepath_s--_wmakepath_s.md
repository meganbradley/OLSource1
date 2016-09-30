---
title: "_makepath_s, _wmakepath_s"
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
  - "_wmakepath_s"
  - "_makepath_s"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr120_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_wmakepath_s"
  - "makepath_s"
  - "_makepath_s"
  - "wmakepath_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_makepath_s function"
  - "wmakepath_s function"
  - "paths"
  - "_wmakepath_s function"
  - "makepath_s function"
ms.assetid: 4405e43c-3d63-4697-bb80-9b8dcd21d027
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _makepath_s, _wmakepath_s
Creates a path name from components. These are versions of [_makepath, _wmakepath](../vs140/_makepath--_wmakepath.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Full path buffer.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Size of the buffer in words.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Size of the buffer in bytes.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Contains a letter (A, B, and so on) corresponding to the desired drive and an optional trailing colon. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> inserts the colon automatically in the composite path if it is missing. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or points to an empty string, no drive letter appears in the composite <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> string.  
  
 [in] <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Contains the path of directories, not including the drive designator or the actual file name. The trailing slash is optional, and either a forward slash (/) or a backslash (\\) or both might be used in a single <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> argument. If no trailing slash (/ or \\) is specified, it is inserted automatically. If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or points to an empty string, no directory path is inserted in the composite <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> string.  
  
 [in] <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Contains the base file name without any file name extensions. If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> or points to an empty string, no filename is inserted in the composite <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> string.  
  
 [in] <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 Contains the actual file name extension, with or without a leading period (.). <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> inserts the period automatically if it does not appear in <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> or points to an empty string, no extension is inserted in the composite <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> string.  
  
## Return Value  
 Zero if successful; an error code on failure.  
  
### Error Conditions  
  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder> / <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Return|Contents of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
|------------|------------------------------------|------------|------------------------|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|any|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|not modified|  
|any|<= 0|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|not modified|  
  
 If any of the above error conditions occurs, these functions invoke the invalid parameter handler, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is set to<CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and the functions returns<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>**.** <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is allowed for the parameters <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>. For information about the behavior when these parameters are null pointers or empty strings, see the Remarks section.  
  
## Remarks  
 The <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> function creates a composite path string from individual components, storing the result in <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> might include a drive letter, directory path, file name, and file name extension. <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>; the arguments to <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> are wide-character strings. <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> behave identically otherwise.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|  
  
 The <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> argument must point to an empty buffer large enough to hold the complete path. The composite <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> must be no larger than the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> constant, defined in Stdlib.h.  
  
 If path is <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). In addition, <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> values are allowed for all other parameters.  
  
 In C++, using these functions is simplified by template overloads; the overloads can infer buffer length automatically (eliminating the need to specify a size argument) and they can automatically replace older, non-secure functions with their newer, secure counterparts. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
 The debug versions of these functions first fill the buffer with 0xFD. To disable this behavior, use [_CrtSetDebugFillThreshold](../vs140/_crtsetdebugfillthreshold.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 [System::IO::File::Create](https://msdn.microsoft.com/en-us/library/system.io.file.create.aspx)  
  
## See Also  
 [File Handling](../vs140/file-handling.md)   
 [_fullpath, _wfullpath](../vs140/_fullpath--_wfullpath.md)   
 [_splitpath_s, _wsplitpath_s](../vs140/_splitpath_s--_wsplitpath_s.md)   
 [_makepath, _wmakepath](../vs140/_makepath--_wmakepath.md)