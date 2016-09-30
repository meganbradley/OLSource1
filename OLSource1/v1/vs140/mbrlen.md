---
title: "mbrlen"
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
  - "mbrlen"
apilocation: 
  - "msvcr100.dll"
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcrt.dll"
apitype: "DLLExport"
f1_keywords: 
  - "mbrlen"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "mbrlen function"
ms.assetid: dde8dee9-e091-4c4c-81b3-639808885ae1
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# mbrlen
Determine the number of bytes that are required to complete a multibyte character in the current locale, with the capability of restarting in the middle of a multibyte character.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the next byte to inspect in a multibyte character string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The maximum number of bytes to inspect.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to the current shift state of the initial byte of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Return Value  
 One of the following values:  
  
 0  
 The next <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or fewer bytes complete the multibyte character that represents the wide null character.  
  
 1 to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, inclusive  
 The next <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or fewer bytes complete a valid multibyte character. The value returned is the number of bytes that complete the multibyte character.  
  
 (size_t)(-2)  
 The next <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> bytes contribute to an incomplete but potentially valid multibyte character and all <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> bytes have been processed.  
  
 (size_t)(-1)  
 An encoding error occurred. The next <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or fewer bytes do not contribute to a complete and valid multibyte character. In this case, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is set to EILSEQ and the conversion state in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is unspecified.  
  
## Remarks  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> function inspects at most <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> bytes starting with the byte pointed to by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to determine the number of bytes that are required to complete the next multibyte character, including any shift sequences. It is equivalent to the call <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> where <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is either a user-provided <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object, or a static internal object provided by the library.  
  
 The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> function saves and uses the shift state of an incomplete multibyte character in the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> parameter. This gives <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> the capability of restarting in the middle of a multibyte character if need be, examining at most <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> bytes. If <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is a null pointer, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> uses an internal, static <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object to store the shift state. Because the internal <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object is not thread-safe, we recommend that you always allocate and pass your own <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> parameter.  
  
 The <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> function differs from [mblen](../vs140/_mbclen--mblen--_mblen_l.md) by its restartability. The shift state is stored in <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> for subsequent calls to the same or other restartable functions. Results are undefined when mixing the use of restartable and nonrestartable functions.  For example, an application should use <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> if a subsequent call to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is used instead of <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
### Generic-Text Routine Mappings  
  
|TCHAR.H routine|_UNICODE & _MBCS not defined|_MBCS defined|_UNICODE defined|  
|---------------------|------------------------------------|--------------------|-----------------------|  
|not applicable|not applicable|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|not applicable|  
  
## Requirements  
  
|Routine|Required header|  
|-------------|---------------------|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|\<wchar.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md) in the Introduction.  
  
## Example  
 This example shows how the interpretation of multibyte characters depends on the current code page, and demonstrates the resuming capability of <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **Code page: 0**  
**é╨éτé¬é╚: Shift-jis hiragana.**  
**Character count: 29**  
**Code page: 932**  
**????: Shift-jis hiragana.**  
**Character count: 25**   
## .NET Framework Equivalent  
 [System::String::Length](https://msdn.microsoft.com/en-us/library/system.string.length.aspx)  
  
## See Also  
 [String Manipulation](../vs140/string-manipulation--crt-.md)   
 [Locale](../vs140/locale.md)