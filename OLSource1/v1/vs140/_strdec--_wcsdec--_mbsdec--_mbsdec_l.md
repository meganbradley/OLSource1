---
title: "_strdec, _wcsdec, _mbsdec, _mbsdec_l"
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
  - "_wcsdec"
  - "_strdec"
  - "_mbsdec"
  - "_mbsdec_l"
apilocation: 
  - "msvcrt.dll"
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_strdec"
  - "mbsdec_l"
  - "strdec"
  - "_mbsdec"
  - "_mbsdec_l"
  - "mbsdec"
  - "wcsdec"
  - "_wcsdec"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "mbsdec_l function"
  - "mbsdec function"
  - "tcsdec function"
  - "_tcsdec function"
  - "_strdec function"
  - "_wcsdec function"
  - "_mbsdec_l function"
  - "strdec function"
  - "wcsdec function"
  - "_mbsdec function"
ms.assetid: ae37c223-800f-48a9-ae8e-38c8d20af2dd
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _strdec, _wcsdec, _mbsdec, _mbsdec_l
Moves a string pointer back one character.  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to any character (or for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and _<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the first byte of any multibyte character) in the source string; <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> must precede <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in the source string.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Pointer to any character (or for <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and _<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, the first byte of any multibyte character) in the source string; <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> must follow <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> in the source string.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, _<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> each return a pointer to the character that immediately precedes <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>; <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> if the value of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is greater than or equal to that of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> maps to one of these functions and its return value depends on the mapping.  
  
## Remarks  
 The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> functions return a pointer to the first byte of the multibyte character that immediately precedes <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> in the string that contains <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> category setting of the locale; see [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md) for more information.  <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> recognizes multibyte-character sequences according to the locale that's currently in use, while <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is identical except that it instead uses the locale parameter that's passed in. For more information, see [Locale](../vs140/locale.md).  
  
 If <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, this function returns <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> and sets <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
> [!IMPORTANT]
>  These functions might be vulnerable to buffer overrun threats. Buffer overruns can be used for system attacks because they can cause an unwarranted elevation of privilege. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> are single-byte-character and wide-character versions of <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> are provided only for this mapping and should not be used otherwise.  
  
 For more information, see [Using Generic-Text Mappings](../vs140/using-generic-text-mappings.md) and [Generic-Text Mappings](../vs140/generic-text-mappings.md).  
  
## Requirements  
  
|Routine|Required header|Optional header|  
|-------------|---------------------|---------------------|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|\<mbstring.h>|\<mbctype.h>|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|\<mbstring.h>|\<mbctype.h>|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|\<tchar.h>||  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|\<tchar.h>||  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
 The following example shows a use of <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following example shows a use of <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [_mbsinc, _mbsinc_l, _strinc, _wcsinc](../vs140/_strinc--_wcsinc--_mbsinc--_mbsinc_l.md)   
 [_mbsnextc, _mbsnextc_l, _strnextc, _wcsnextc](../vs140/_strnextc--_wcsnextc--_mbsnextc--_mbsnextc_l.md)   
 [_mbsninc, _mbsninc_l, _strninc, _wcsninc](../vs140/_strninc--_wcsninc--_mbsninc--_mbsninc_l.md)