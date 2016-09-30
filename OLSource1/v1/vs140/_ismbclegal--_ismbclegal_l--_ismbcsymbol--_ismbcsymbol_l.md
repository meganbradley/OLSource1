---
title: "_ismbclegal, _ismbclegal_l, _ismbcsymbol, _ismbcsymbol_l"
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
  - "_ismbclegal_l"
  - "_ismbclegal"
  - "_ismbcsymbol"
  - "_ismbcsymbol_l"
apilocation: 
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcrt.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "ismbcsymbol_l"
  - "_ismbcsymbol_l"
  - "_ismbcsymbol"
  - "_ismbclegal_l"
  - "_ismbclegal"
  - "ismbclegal_l"
  - "ismbcsymbol"
  - "ismbclegal"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "ismbcsymbol function"
  - "ismbclegal_l function"
  - "_istlegal_l function"
  - "istlegal function"
  - "_istlegal function"
  - "_ismbcsymbol function"
  - "_ismbclegal_l function"
  - "ismbclegal function"
  - "ismbcsymbol_l function"
  - "_ismbclegal function"
  - "_ismbcsymbol_l function"
  - "istlegal_l function"
ms.assetid: 31bf1ea5-b56f-4e28-b21e-b49a2cf93ffc
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ismbclegal, _ismbclegal_l, _ismbcsymbol, _ismbcsymbol_l
Checks whether a multibyte character is a legal or symbol character.  
  
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
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Valid multibyte|Returns nonzero if and only if the first byte of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is within ranges 0x81 – 0x9F or 0xE0 – 0xFC, while the second byte is within ranges 0x40 - 0x7E or 0x80 - FC.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Multibyte symbol|Returns nonzero if and only if 0x8141<=<CodeContentPlaceHolder>12\</CodeContentPlaceHolder><=0x81AC.|  
  
### Generic-Text Routine Mappings  
  
|Tchar.h routine|_UNICODE and _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|--------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Always returns false|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Always returns false.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Always returns false|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Always returns false.|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|\<mbstring.h>|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|\<mbstring.h>|  
  
 For more compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Character Classification](../vs140/character-classification.md)   
 [_ismbc Routines](../vs140/_ismbc-routines.md)   
 [is, isw Routines](../vs140/is--isw-routines.md)   
 [_ismbb Routines](../vs140/_ismbb-routines.md)