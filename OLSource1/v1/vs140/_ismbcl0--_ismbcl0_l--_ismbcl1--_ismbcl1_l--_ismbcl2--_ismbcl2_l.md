---
title: "_ismbcl0, _ismbcl0_l, _ismbcl1, _ismbcl1_l, _ismbcl2, _ismbcl2_l"
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
  - "_ismbcl2"
  - "_ismbcl1"
  - "_ismbcl0"
  - "_ismbcl2_l"
  - "_ismbcl1_l"
  - "_ismbcl0_l"
apilocation: 
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "ismbcl0"
  - "_ismbcl1_l"
  - "_ismbcl0"
  - "ismbcl1"
  - "ismbcl0_l"
  - "_ismbcl2_l"
  - "ismbcl2"
  - "ismbcl1_l"
  - "_ismbcl1"
  - "_ismbcl0_l"
  - "_ismbcl2"
  - "ismbcl2_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_ismbcl0_l function"
  - "_ismbcl2 function"
  - "_ismbcl1_l function"
  - "ismbcl2 function"
  - "_ismbcl1 function"
  - "ismbcl0_l function"
  - "ismbcl2_l function"
  - "ismbcl1_l function"
  - "ismbcl0 function"
  - "ismbcl1 function"
  - "_ismbcl2_l function"
  - "_ismbcl0 function"
ms.assetid: ee15ebd1-462c-4a43-95f3-6735836d626a
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ismbcl0, _ismbcl0_l, _ismbcl1, _ismbcl1_l, _ismbcl2, _ismbcl2_l
**Code Page 932 Specific functions**, using the current locale or a specified LC_CTYPE conversion state category.  
  
> [!IMPORTANT]
>  This API cannot be used in applications that execute in the Windows Runtime. For more information, see [CRT functions not supported with /ZW](http://msdn.microsoft.com/library/windows/apps/jj606124.aspx).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Character to be tested.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Locale to use.  
  
## Return Value  
 Each of these routines returns a nonzero value if the character satisfies the test condition or 0 if it does not. If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> <= 255 and there is a corresponding <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> routine (for example, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> corresponds to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>), the result is the return value of the corresponding <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> routine.  
  
## Remarks  
 Each of these functions tests a given multibyte character for a given condition.  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> category setting of the locale; see [setlocale](../vs140/setlocale--_wsetlocale.md) for more information. The versions of these functions without the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> suffix use the current locale for this locale-dependent behavior; the versions with the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> suffix are identical except that they use the locale parameter passed in instead. For more information, see [Locale](../vs140/locale.md).  
  
|Routine|Test condition (code page 932 only)|  
|-------------|-------------------------------------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|JIS non-Kanji: 0x8140<=<CodeContentPlaceHolder>12\</CodeContentPlaceHolder><=0x889E.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|JIS non-Kanji: 0x8140<=<CodeContentPlaceHolder>14\</CodeContentPlaceHolder><=0x889E.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|JIS level-1: 0x889F<=<CodeContentPlaceHolder>16\</CodeContentPlaceHolder><=0x9872.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|JIS level-1: 0x889F<=<CodeContentPlaceHolder>18\</CodeContentPlaceHolder><=0x9872.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|JIS level-2: 0x989F<=<CodeContentPlaceHolder>20\</CodeContentPlaceHolder><=0xEAA4.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|JIS level-2: 0x989F<=<CodeContentPlaceHolder>22\</CodeContentPlaceHolder><=0xEAA4.|  
  
 The functions check that the specified value <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> matches the test conditions described above, but do not check that <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is a valid multibyte character. If the lower byte is in the ranges 0x00 – 0x3F, 0x7F, or 0xFD – 0xFF, these functions return a nonzero value, indicating that the character satisfies the test condition. Use [_ismbbtrail](../vs140/_ismbbtrail--_ismbbtrail_l.md) to test whether the multibyte character is defined.  
  
 **End Code Page 932 Specific**  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Character Classification](../vs140/character-classification.md)   
 [_ismbc Routines](../vs140/_ismbc-routines.md)   
 [is, isw Routines](../vs140/is--isw-routines.md)