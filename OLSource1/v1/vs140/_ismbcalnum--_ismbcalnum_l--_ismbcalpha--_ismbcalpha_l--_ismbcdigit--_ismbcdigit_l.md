---
title: "_ismbcalnum, _ismbcalnum_l, _ismbcalpha, _ismbcalpha_l, _ismbcdigit, _ismbcdigit_l"
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
  - "_ismbcalpha"
  - "_ismbcalnum"
  - "_ismbcdigit"
  - "_ismbcalnum_l"
  - "_ismbcdigit_l"
  - "_ismbcalpha_l"
apilocation: 
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_ismbcdigit"
  - "ismbcalnum_l"
  - "_ismbcdigit_l"
  - "_ismbcalpha"
  - "ismbcalnum"
  - "ismbcdigit"
  - "ismbcalpha"
  - "_ismbcalnum_l"
  - "_ismbcalnum"
  - "ismbcdigit_l"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "ismbcalpha function"
  - "_ismbcalnum function"
  - "ismbcdigit_l function"
  - "_ismbcalnum_l function"
  - "_ismbcdigit function"
  - "ismbcalnum function"
  - "_ismbcalpha_l function"
  - "ismbcdigit function"
  - "_ismbcalpha function"
  - "_ismbcdigit_l function"
  - "ismbcalnum_l function"
  - "ismbcalpha_l function"
ms.assetid: 12d57925-aebe-46e0-80b0-82b84c4c31ec
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ismbcalnum, _ismbcalnum_l, _ismbcalpha, _ismbcalpha_l, _ismbcdigit, _ismbcdigit_l
Checks whether a multibyte character is an alphanumeric, alpha, or digit character.  
  
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
 Each of these routines returns a nonzero value if the character satisfies the test condition or 0 if it does not. If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder><= 255 and there is a corresponding <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> routine (for example, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> corresponds to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>), the result is the return value of the corresponding <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> routine.  
  
## Remarks  
 Each of these routines tests a given multibyte character for a given condition.  
  
 The versions of these functions with the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> suffix are identical except that they use the locale passed in instead of the current locale for their locale-dependent behavior. For more information, see [Locale](../vs140/locale.md).  
  
|Routine|Test condition|Code page 932 example|  
|-------------|--------------------|---------------------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Alphanumeric|Returns nonzero if and only if <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is a single-byte representation of an ASCII English letter: See examples for <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Alphabetic|Returns nonzero if and only if <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is a single-byte representation of an ASCII English letter: 0x41<=<CodeContentPlaceHolder>15\</CodeContentPlaceHolder><=0x5A or 0x61<=<CodeContentPlaceHolder>16\</CodeContentPlaceHolder><=0x7A; or a katakana letter: 0xA6<=<CodeContentPlaceHolder>17\</CodeContentPlaceHolder><=0xDF.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Digit|Returns nonzero if and only if <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is a single-byte representation of an ASCII digit: 0x30<=<CodeContentPlaceHolder>20\</CodeContentPlaceHolder><=0x39.|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
  
-   [System::Char::IsLetter](https://msdn.microsoft.com/en-us/library/system.char.isletter.aspx)  
  
-   [System::Char::IsDigit](https://msdn.microsoft.com/en-us/library/system.char.isdigit.aspx)  
  
-   For <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>: Not applicable. To call the standard C function, use <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Character Classification](../vs140/character-classification.md)   
 [_ismbc Routines](../vs140/_ismbc-routines.md)   
 [is, isw Routines](../vs140/is--isw-routines.md)   
 [_ismbb Routines](../vs140/_ismbb-routines.md)