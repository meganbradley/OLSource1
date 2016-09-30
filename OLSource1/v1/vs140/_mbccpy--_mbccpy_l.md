---
title: "_mbccpy, _mbccpy_l"
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
  - "_mbccpy"
  - "_mbccpy_l"
apilocation: 
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_mbccpy"
  - "tccpy"
  - "ftccpy"
  - "mbccpy"
  - "_tccpy"
  - "_ftccpy"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_tccpy function"
  - "_tccpy_l function"
  - "tccpy_l function"
  - "tccpy function"
  - "mbccpy function"
  - "_mbccpy_l function"
  - "_mbccpy function"
  - "mbccpy_l function"
ms.assetid: 13f4de6e-7792-41ac-b319-dd9b135433aa
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mbccpy, _mbccpy_l
Copies a multibyte character from one string to another string. More secure versions of these functions are available; see [_mbccpy_s, _mbccpy_s_l](../vs140/_mbccpy_s--_mbccpy_s_l.md).  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Copy destination.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Multibyte character to copy.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function copies one multibyte character from <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 This function validates its parameters. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is passed a null pointer for <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, the invalid parameter handler is invoked, as described in [Parameter Validation](../vs140/parameter-validation.md). If execution is allowed to continue, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> uses the current locale for any locale-dependent behavior. <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is identical to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> except that <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> uses the locale passed in for any locale-dependent behavior. For more information, see [Locale](../vs140/locale.md).  
  
 **Security Note** Use a null-terminated string. The null-terminated string must not exceed the size of the destination buffer. For more information, see [Avoiding Buffer Overruns](http://msdn.microsoft.com/library/windows/desktop/ms717795). Buffer overrun problems are a frequent method of system attack, resulting in an unwarranted elevation of privilege.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Maps to macro or inline function|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Maps to macro or inline function|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|n/a|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|n/a|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|\<mbctype.h>|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|\<mbctype.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [_mbclen, mblen, _mblen_l, _mbsnlen, _mbsnlen_l](../vs140/_mbclen--mblen--_mblen_l.md)