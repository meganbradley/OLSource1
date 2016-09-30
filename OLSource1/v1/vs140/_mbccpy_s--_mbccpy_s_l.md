---
title: "_mbccpy_s, _mbccpy_s_l"
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
  - "_mbccpy_s"
  - "_mbccpy_s_l"
apilocation: 
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_mbccpy_s_l"
  - "mbccpy_s_l"
  - "mbccpy_s"
  - "_mbccpy_s"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "tccpy_s_l function"
  - "_tccpy_s function"
  - "_mbccpy_s function"
  - "mbccpy_s function"
  - "tccpy_s function"
  - "mbccpy_s_l function"
  - "_tccpy_s_l function"
  - "_mbccpy_s_l function"
ms.assetid: b6e965fa-53c1-4ec3-85ef-a1c4b4f2b2da
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mbccpy_s, _mbccpy_s_l
Copies one multibyte character from a string to another string. These versions of [_mbccpy](../vs140/_mbccpy--_mbccpy_l.md) have security enhancements, as described in [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md).  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Copy destination.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Size of the destination buffer.  
  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Filled with the number of bytes copied (1 or 2 if successful). Pass <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if you don't care about the number.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Multibyte character to copy.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Zero if successful; an error code on failure. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, or if more than <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> bytes would be copied to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, then the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, the functions return <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> function copies one multibyte character from <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> does not point to the lead byte of a multibyte character as determined by an implicit call to [_ismbblead](../vs140/_ismbblead--_ismbblead_l.md), then the single byte that <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> points to is copied. If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> points to a lead byte but the following byte is 0 and thus invalid, then 0 is copied to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, and the function returns <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> does not append a null terminator; however, if <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> points to a null character, then that null is copied to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> (this is just a regular single-byte copy).  
  
 The value in <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is filled with the number of bytes copied. Possible values are 1 and 2 if the operation is successful. If <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is passed in, this parameter is ignored.  
  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|copied to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Return value|  
|-----------|----------------------|---------------|------------------|  
|non-lead-byte|non-lead-byte|1|0|  
|0|0|1|0|  
|lead-byte followed by non-0|lead-byte followed by non-0|2|0|  
|lead-byte followed by 0|0|1|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|  
  
 Note that the second row is just a special case of the first. Also note that the table assumes <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> >= <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> uses the current locale for any locale-dependent behavior. <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is identical to <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> except that <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> uses the locale passed in for any locale-dependent behavior.  
  
 In C++, using these functions is simplified by template overloads; the overloads can infer buffer length automatically, eliminating the need to specify a size argument. For more information, see [Secure Template Overloads](../vs140/secure-template-overloads.md).  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|Maps to macro or inline function.|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|Maps to macro or inline function.|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [_mbclen, mblen, _mblen_l, _mbsnlen, _mbsnlen_l](../vs140/_mbclen--mblen--_mblen_l.md)