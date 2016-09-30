---
title: "_mbctohira, _mbctohira_l, _mbctokata, _mbctokata_l"
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
  - "_mbctohira"
  - "_mbctohira_l"
  - "_mbctokata"
  - "_mbctokata_l"
apilocation: 
  - "msvcr110.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_mbctokata"
  - "mbctohira"
  - "_mbctohira"
  - "_mbctohira_l"
  - "mbctokata"
  - "mbctokata_l"
  - "mbctohira_l"
  - "_mbctokata_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_mbctokata function"
  - "_mbctokata_l function"
  - "_mbctohira_l function"
  - "mbctohira_l function"
  - "mbctohira function"
  - "mbctokata_l function"
  - "_mbctohira function"
  - "mbctokata function"
ms.assetid: f949afd7-44d4-4f08-ac8f-1fef2c915a1c
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mbctohira, _mbctohira_l, _mbctokata, _mbctokata_l
Converts between hiragana and katakana characters.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Multibyte character to convert.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Each of these functions returns the converted character <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, if possible. Otherwise it returns the character <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> unchanged.  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> functions test a character <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and, if possible, apply one of the following conversions.  
  
|Routines|Converts|  
|--------------|--------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Multibyte katakana to multibyte hiragana.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Multibyte hiragana to multibyte katakana.|  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> category setting of the locale; see [setlocale](../vs140/setlocale--_wsetlocale.md) for more information. The versions of these functions are identical, except that the ones that don't have the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> suffix use the current locale for this locale-dependent behavior and the ones that do have the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> suffix instead use the locale parameter that's passed in. For more information, see [Locale](../vs140/locale.md).  
  
 In earlier versions, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> was named <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> was named <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. For new code, use the new names.  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [_mbcjistojms, _mbcjistojms_l, _mbcjmstojis, _mbcjmstojis_l](../vs140/_mbcjistojms--_mbcjistojms_l--_mbcjmstojis--_mbcjmstojis_l.md)   
 [_mbctolower, _mbctolower_l, _mbctoupper, _mbctoupper_l](../vs140/_mbctolower--_mbctolower_l--_mbctoupper--_mbctoupper_l.md)   
 [_mbctombb, _mbctombb_l](../vs140/_mbctombb--_mbctombb_l.md)