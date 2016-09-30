---
title: "_ismbclower, _ismbclower_l, _ismbcupper, _ismbcupper_l"
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
  - "_ismbclower"
  - "_ismbclower_l"
  - "_ismbcupper_l"
  - "_ismbcupper"
apilocation: 
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "_ismbcupper"
  - "_ismbclower"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_ismbcupper function"
  - "ismbclower function"
  - "_ismbclower_l function"
  - "ismbcupper_l function"
  - "_ismbclower function"
  - "ismbcupper function"
  - "ismbclower_l function"
  - "_ismbcupper_l function"
ms.assetid: 17d89587-65bc-477c-ba8f-a84e63cf59e7
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ismbclower, _ismbclower_l, _ismbcupper, _ismbcupper_l
Checks whether a multibyte character is lowercase or uppercase.  
  
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
 Each of these functions tests a given multibyte character for a given condition.  
  
 The versions of these functions with the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> suffix are identical except that they use the locale passed in instead of the current locale for their locale-dependent behavior. For more information, see [Locale](../vs140/locale.md).  
  
|Routine|Test condition|Code page 932 example|  
|-------------|--------------------|---------------------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Lowercase alphabetic|Returns nonzero if and only if <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is a single-byte representation of an ASCII lowercase English letter: 0x61<=<CodeContentPlaceHolder>11\</CodeContentPlaceHolder><=0x7A.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Lowercase alphabetic|Returns nonzero if and only if <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is a single-byte representation of an ASCII lowercase English letter: 0x61<=<CodeContentPlaceHolder>14\</CodeContentPlaceHolder><=0x7A.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Uppercase alphabetic|Returns nonzero if and only if <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is a single-byte representation of an ASCII uppercase English letter: 0x41<=<CodeContentPlaceHolder>17\</CodeContentPlaceHolder><=0x5A.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Uppercase alphabetic|Returns nonzero if and only if <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is a single-byte representation of an ASCII uppercase English letter: 0x41<=<CodeContentPlaceHolder>20\</CodeContentPlaceHolder><=0x5A.|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
  
-   [System::Char::IsLower](https://msdn.microsoft.com/en-us/library/system.char.islower.aspx)  
  
-   [System::Char::IsUpper](https://msdn.microsoft.com/en-us/library/system.char.isupper.aspx)  
  
## See Also  
 [Character Classification](../vs140/character-classification.md)   
 [_ismbc Routines](../vs140/_ismbc-routines.md)   
 [Locale](../vs140/locale.md)   
 [Interpretation of Multibyte-Character Sequences](../vs140/interpretation-of-multibyte-character-sequences.md)   
 [is, isw Routines](../vs140/is--isw-routines.md)   
 [_ismbb Routines](../vs140/_ismbb-routines.md)