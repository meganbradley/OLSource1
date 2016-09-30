---
title: "_ismbb Routines"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apilocation: 
  - "msvcr110.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_ismbb"
  - "ismbb"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "ismbb routines"
  - "_ismbb routines"
ms.assetid: d63c232e-3fe4-4844-aafd-2133846ece4b
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ismbb Routines
Tests the given integer value <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> for a particular condition, by using the current locale or a specified LC_CTYPE conversion state category.  
  
|||  
|-|-|  
|[_ismbbalnum, _ismbbalnum_l](../vs140/_ismbbalnum--_ismbbalnum_l.md)|[_ismbbkprint, _ismbbkprint_l](../vs140/_ismbbkprint--_ismbbkprint_l.md)|  
|[_ismbbalpha, _ismbbalpha_l](../vs140/_ismbbalpha--_ismbbalpha_l.md)|[_ismbbkpunct, _ismbbkpunct_l](../vs140/_ismbbkpunct--_ismbbkpunct_l.md)|  
|[_ismbbblank, _ismbbblank_l](../vs140/_ismbbblank--_ismbbblank_l.md)|[_ismbblead, _ismbblead_l](../vs140/_ismbblead--_ismbblead_l.md)|  
|[_ismbbgraph, _ismbbgraph_l](../vs140/_ismbbgraph--_ismbbgraph_l.md)|[_ismbbprint, _ismbbprint_l](../vs140/_ismbbprint--_ismbbprint_l.md)|  
|[_ismbbkalnum, _ismbbkalnum_l](../vs140/_ismbbkalnum--_ismbbkalnum_l.md)|[_ismbbpunct, _ismbbpunct_l](../vs140/_ismbbpunct--_ismbbpunct_l.md)|  
|[_ismbbkana, _ismbbkana_l](../vs140/_ismbbkana--_ismbbkana_l.md)|[_ismbbtrail, _ismbbtrail_l](../vs140/_ismbbtrail--_ismbbtrail_l.md)|  
  
## Remarks  
 Every routine in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> family tests the given integer value <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> for a particular condition. The test result depends on the multibyte code page that's in effect. By default, the multibyte code page is set to the ANSI code page that's obtained from the operating system at program startup. You can use [_getmbcp](../vs140/_getmbcp.md) to query for the multibyte code page that's in use, or [_setmbcp](../vs140/_setmbcp.md) to change it.  
  
 The output value is affected by the setting of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> category setting of the locale; for more information, see [setlocale, _wsetlocale](../vs140/setlocale--_wsetlocale.md). The versions of these functions that don't have the **_l** suffix use the current locale for this locale-dependent behavior; the versions that do have the **_l** suffix are identical except that instead they use the locale parameter that's passed in.  
  
 The routines in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> family test the given integer <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> as follows.  
  
|Routine|Byte test condition|  
|-------------|-------------------------|  
|[_ismbbalnum](../vs140/_ismbbalnum--_ismbbalnum_l.md)|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> &#124;&#124; <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
|[_ismbbalpha](../vs140/_ismbbalpha--_ismbbalpha_l.md)|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> &#124;&#124; <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.|  
|[_ismbbblank](../vs140/_ismbbblank--_ismbbblank_l.md)|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
|[_ismbbgraph](../vs140/_ismbbgraph--_ismbbgraph_l.md)|Same as <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, but <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> does not include the space character (0x20).|  
|[_ismbbkalnum](../vs140/_ismbbkalnum--_ismbbkalnum_l.md)|Non-ASCII text symbol other than punctuation. For example, in code page 932 only, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> tests for katakana alphanumeric.|  
|[_ismbbkana](../vs140/_ismbbkana--_ismbbkana_l.md)|Katakana (0xA1 – 0xDF). Specific to code page 932.|  
|[_ismbbkprint](../vs140/_ismbbkprint--_ismbbkprint_l.md)|Non-ASCII text or non-ASCII punctuation symbol. For example, in code page 932 only, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> tests for katakana alphanumeric or katakana punctuation (range: 0xA1 – 0xDF).|  
|[_ismbbkpunct](../vs140/_ismbbkpunct--_ismbbkpunct_l.md)|Non-ASCII punctuation. For example, in code page 932 only, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> tests for katakana punctuation.|  
|[_ismbblead](../vs140/_ismbblead--_ismbblead_l.md)|First byte of multibyte character. For example, in code page 932 only, valid ranges are 0x81 – 0x9F, 0xE0 – 0xFC.|  
|[_ismbbprint](../vs140/_ismbbprint--_ismbbprint_l.md)|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> &#124;&#124; <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. **ismbbprint** includes the space character (0x20).|  
|[_ismbbpunct](../vs140/_ismbbpunct--_ismbbpunct_l.md)|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder> &#124;&#124; <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.|  
|[_ismbbtrail](../vs140/_ismbbtrail--_ismbbtrail_l.md)|Second byte of multibyte character. For example, in code page 932 only, valid ranges are 0x40 – 0x7E, 0x80 – 0xEC.|  
  
 The following table shows the ORed values that compose the test conditions for these routines. The manifest constants <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> are defined in Ctype.h.  
  
|Routine|_BLANK|_DIGIT|LOWER|_PUNCT|UPPER|Non-\<br />\<br /> ASCII\<br />\<br /> text|Non-\<br />\<br /> ASCII\<br />\<br /> punct|  
|-------------|-------------|-------------|-----------|-------------|-----------|------------------------------|-------------------------------|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|—|x|x|—|x|x|—|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|—|—|x|—|x|x|—|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|x|—|—|—|—|—|—|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|—|x|x|x|x|x|x|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|—|—|—|—|—|x|—|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|—|—|—|—|—|x|x|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|—|—|—|—|—|—|x|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|x|x|x|x|x|x|x|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|—|—|—|x|—|—|x|  
  
 The <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> routines are implemented both as functions and as macros. For more information about how to choose either implementation, see [Recommendations for Choosing Between Functions and Macros](../vs140/recommendations-for-choosing-between-functions-and-macros.md).  
  
## .NET Framework Equivalent  
 Not applicable, but see [System::Globalization::CultureInfo](https://msdn.microsoft.com/en-us/library/system.globalization.cultureinfo.aspx).  
  
## See Also  
 [Byte Classification](../vs140/byte-classification.md)   
 [is, isw Routines](../vs140/is--isw-routines.md)   
 [_mbbtombc, _mbbtombc_l](../vs140/_mbbtombc--_mbbtombc_l.md)   
 [_mbctombb, _mbctombb_l](../vs140/_mbctombb--_mbctombb_l.md)