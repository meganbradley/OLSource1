---
title: "_ismbchira, _ismbchira_l, _ismbckata, _ismbckata_l"
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
  - "_ismbckata"
  - "_ismbchira_l"
  - "_ismbchira"
  - "_ismbckata_l"
apilocation: 
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr100.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "ismbckata_l"
  - "_ismbckata_l"
  - "ismbckata"
  - "ismbchira"
  - "_ismbckata"
  - "ismbchira_l"
  - "_ismbchira_l"
  - "_ismbchira"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_ismbckata function"
  - "_ismbchira function"
  - "_ismbckata_l function"
  - "Katakana"
  - "ismbchira function"
  - "_ismbchira_l function"
  - "ismbchira_l function"
  - "ismbdkata_l function"
  - "Hiragana"
  - "ismbckata function"
ms.assetid: 2db388a2-be31-489b-81c8-f6bf3f0582d3
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ismbchira, _ismbchira_l, _ismbckata, _ismbckata_l
**Code Page 932 Specific functions**  
  
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
  
 The versions of these functions with the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> suffix are identical except that they use the locale passed in instead of the current locale for their locale-dependent behavior. For more information, see [Locale](../vs140/locale.md).  
  
|Routine|Test condition (code page 932 only)|  
|-------------|-------------------------------------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Double-byte Hiragana: 0x829F<=<CodeContentPlaceHolder>10\</CodeContentPlaceHolder><=0x82F1.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Double-byte Hiragana: 0x829F<=<CodeContentPlaceHolder>12\</CodeContentPlaceHolder><=0x82F1.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Double-byte katakana: 0x8340<=<CodeContentPlaceHolder>14\</CodeContentPlaceHolder><=0x8396.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Double-byte katakana: 0x8340<=<CodeContentPlaceHolder>16\</CodeContentPlaceHolder><=0x8396.|  
  
 **End Code Page 932 Specific**  
  
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
 [Character Classification](../vs140/character-classification.md)   
 [_ismbc Routines](../vs140/_ismbc-routines.md)   
 [is, isw Routines](../vs140/is--isw-routines.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)