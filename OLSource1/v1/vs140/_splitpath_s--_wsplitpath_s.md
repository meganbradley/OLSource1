---
title: "_splitpath_s, _wsplitpath_s"
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
  - "_wsplitpath_s"
  - "_splitpath_s"
apilocation: 
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcr120_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_wsplitpath_s"
  - "splitpath_s"
  - "_splitpath_s"
  - "wsplitpath_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "splitpath_s function"
  - "pathnames"
  - "_splitpath_s function"
  - "_wsplitpath_s function"
  - "path names"
  - "wsplitpath_s function"
ms.assetid: 30fff3e2-cd00-4eb6-b5a2-65db79cb688b
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _splitpath_s, _wsplitpath_s
Breaks a path name into components. These are versions of [_splitpath, _wsplitpath](../vs140/_splitpath--_wsplitpath.md) with security enhancements as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Full path.  
  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Drive letter, followed by a colon (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>). You can pass <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for this parameter if you do not need the drive letter.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The size of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> buffer in single-byte or wide characters. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, this value must be 0.  
  
 [out] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Directory path, including trailing slash. Forward slashes ( <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> ), backslashes ( <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> ), or both may be used. You can pass <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> for this parameter if you do not need the directory path.  
  
 [in] <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The size of the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> buffer in single-byte or wide characters. If <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, this value must be 0.  
  
 [out] <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Base filename (without extension). You can pass <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> for this parameter if you do not need the filename.  
  
 [in] <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The size of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> buffer in single-byte or wide characters. If <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, this value must be 0.  
  
 [out] <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Filename extension, including leading period (**.**).You can pass <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> for this parameter if you do not need the filename extension.  
  
 [in] <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 The size of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> buffer in single-byte or wide characters. If <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, this value must be 0.  
  
## Return Value  
 Zero if successful; an error code on failure.  
  
### Error Conditions  
  
|Condition|Return Value|  
|---------------|------------------|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is non-zero|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is non-<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is zero|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is non-zero|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is non-<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> is zero|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> is non-zero|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder> is non-<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is zero|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> is non-zero|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder> is non-<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> is zero|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|  
  
 If any of the above conditions occurs, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md) . If execution is allowed to continue, these functions set <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> and return <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>.  
  
 If any of the buffers is too short to hold the result, these functions clear all the buffers to empty strings, set <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, and return <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> function breaks a path into its four components. <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> automatically handles multibyte-character string arguments as appropriate, recognizing multibyte-character sequences according to the multibyte code page currently in use. <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> is a wide-character version of <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>; the arguments to <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>are wide-character strings. These functions behave identically otherwise  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>|  
  
 Each component of the full path is stored in a separate buffer; the manifest constants <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> (defined in STDLIB.H) specify the maximum allowable size for each file component. File components larger than the corresponding manifest constants cause heap corruption.  
  
 The following table lists the values of the manifest constants.  
  
|Name|Value|  
|----------|-----------|  
|_MAX_DRIVE|3|  
|_MAX_DIR|256|  
|_MAX_FNAME|256|  
|_MAX_EXT|256|  
  
 If the full path does not contain a component (for example, a filename), <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> assigns an empty string to the corresponding buffer.  
  
 In C++, using these functions is simplified by template overloads; the overloads can infer buffer length automatically, eliminating the need to specify a size argument. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
 The debug versions of these functions first fill the buffer with 0xFD. To disable this behavior, use [_CrtSetDebugFillThreshold](../vs140/_crtsetdebugfillthreshold.md).  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>|\<stdlib.h>|  
|<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>|\<stdlib.h> or \<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 See the example for [_makepath_s](../vs140/_makepath_s--_wmakepath_s.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [File Handling](../vs140/file-handling.md)   
 [_splitpath, _wsplitpath](../vs140/_splitpath--_wsplitpath.md)   
 [_fullpath, _wfullpath](../vs140/_fullpath--_wfullpath.md)   
 [_getmbcp](../vs140/_getmbcp.md)   
 [_makepath, _wmakepath](../vs140/_makepath--_wmakepath.md)   
 [_setmbcp](../vs140/_setmbcp.md)