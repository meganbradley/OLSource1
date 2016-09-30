---
title: "_mbsnbset, _mbsnbset_l"
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
  - "_mbsnbset"
  - "_mbsnbset_l"
apilocation: 
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "mbsnbset"
  - "mbsnbset_l"
  - "_mbsnbset"
  - "_mbsnbset_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "tcsnset function"
  - "_tcsnset_l function"
  - "_mbsnbset function"
  - "_tcsnset function"
  - "_mbsnbset_l function"
  - "mbsnbset_l function"
  - "tcsnset_l function"
  - "mbsnbset function"
ms.assetid: 8e46ef75-9a56-42d2-a522-a08450c67c19
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mbsnbset, _mbsnbset_l
Sets the first <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> bytes of a multibyte-character string to a specified character. More secure versions of these functions are available; see [_mbsnbset_s, _mbsnbset_s_l](../vs140/_mbsnbset_s--_mbsnbset_s_l.md).  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 String to be altered.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Single-byte or multibyte-character setting.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Number of bytes to be set.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> returns a pointer to the altered string.  
  
## Remarks  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> functions set, at most, the first <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> bytes of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is greater than the length of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, the length of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is used instead of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is a multibyte character and cannot be set entirely into the last byte specified by <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, the last byte is padded with a blank character. <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>does not place a terminating null at the end of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>is similar to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, except that it sets <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> bytes rather than <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> characters of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is zero, this function generates an invalid parameter exception as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and the function returns <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. Also, if <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is not a valid multibyte character, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and a space is used instead.  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> category setting of the locale; see [setlocale](../vs140/setlocale--_wsetlocale.md) for more information. The <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> version of this function uses the current locale for this locale-dependent behavior; the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> version is identical except that it use the locale parameter passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 **Security Note** This API incurs a potential threat brought about by a buffer overrun problem. Buffer overrun problems are a frequent method of system attack, resulting in an unwarranted elevation of privilege. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [_mbsnbcat, _mbsnbcat_l](../vs140/_mbsnbcat--_mbsnbcat_l.md)   
 [_strnset, _wcsnset, _mbsnset, _mbsnset_l](../vs140/_strnset--_strnset_l--_wcsnset--_wcsnset_l--_mbsnset--_mbsnset_l.md)   
 [_strset, _wcsset, _mbsset, _mbsset_l](../vs140/_strset--_strset_l--_wcsset--_wcsset_l--_mbsset--_mbsset_l.md)