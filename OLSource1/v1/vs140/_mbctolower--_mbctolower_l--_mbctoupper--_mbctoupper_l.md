---
title: "_mbctolower, _mbctolower_l, _mbctoupper, _mbctoupper_l"
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
  - "_mbctolower_l"
  - "_mbctoupper_l"
  - "_mbctoupper"
  - "_mbctolower"
apilocation: 
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "mbctoupper_l"
  - "mbctolower_l"
  - "_mbctolower"
  - "_mbctolower_l"
  - "_mbctoupper"
  - "mbctoupper"
  - "mbctolower"
  - "_mbctoupper_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_mbctolower function"
  - "mbctolower_l function"
  - "totupper function"
  - "_mbctoupper function"
  - "totlower function"
  - "_mbctoupper_l function"
  - "mbctolower function"
  - "_totupper function"
  - "_mbctolower_l function"
  - "mbctoupper_l function"
  - "_totlower function"
  - "mbctoupper function"
ms.assetid: 787fab71-3224-4ed7-bc93-4dcd8023fc54
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _mbctolower, _mbctolower_l, _mbctoupper, _mbctoupper_l
Tests and converts the case of a multibyte character.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
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
 The functions test a character <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and, if possible, apply one of the following conversions.  
  
|Routines|Converts|  
|--------------|--------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Uppercase character to lowercase character.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Lowercase character to uppercase character.|  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> category setting of the locale; see [setlocale](../vs140/setlocale--_wsetlocale.md) for more information. The version of this function without the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> suffix uses the current locale for this locale-dependent behavior; the version with the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> suffix is identical except that it uses the locale parameter passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
 In previous versions, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> was called<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> was called <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. For new code, use the new names instead.  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
  
## Requirements  
  
|Routines|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [_mbbtombc, _mbbtombc_l](../vs140/_mbbtombc--_mbbtombc_l.md)   
 [_mbcjistojms, _mbcjistojms_l, _mbcjmstojis, _mbcjmstojis_l](../vs140/_mbcjistojms--_mbcjistojms_l--_mbcjmstojis--_mbcjmstojis_l.md)   
 [_mbctohira, _mbctohira_l, _mbctokata, _mbctokata_l](../vs140/_mbctohira--_mbctohira_l--_mbctokata--_mbctokata_l.md)   
 [_mbctombb, _mbctombb_l](../vs140/_mbctombb--_mbctombb_l.md)