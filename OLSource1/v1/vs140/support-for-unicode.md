---
title: "Support for Unicode"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "globalization [C++], character sets"
  - "portable data types [MFC]"
  - "Unicode [C++]"
  - "wide characters [C++], about wide characters"
  - "character sets [C++], Unicode"
  - "localization [C++], character sets"
  - "Unicode [C++], installing support"
ms.assetid: 180f1d10-8543-4f79-85ce-293d3cb443bb
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Support for Unicode
Unicode is a specification for supporting all character sets, including those that cannot be represented in just one byte. If you are programming for an international market, we recommend that you use either Unicode or [multibyte character sets](../vs140/support-for-multibyte-character-sets--mbcss-.md) (MBCSs), or enable your program so you can build it for either by changing a switch.  
  
 A wide character is a 2-byte multilingual character code. Most characters used in modern computing worldwide, including technical symbols and special publishing characters, can be represented according to the Unicode specification as a wide character. Characters that cannot be represented in just one wide character can be represented in a Unicode pair by using the Unicode surrogate feature. Because every wide character is represented in a fixed size of 16 bits, using wide characters simplifies programming with international character sets.  
  
 A wide-character string is represented as a **wchar_t[]** array and is pointed to by a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> pointer. Any ASCII character can be represented as a wide character by prefixing the letter L to the character. For example, L'\0' is the terminating wide (16-bit) **NULL** character. Similarly, any ASCII string literal can be represented as a wide-character string literal by prefixing the letter L to the ASCII literal (L"Hello").  
  
 Generally, wide characters take more space in memory than multibyte characters but are faster to process. In addition, only one locale can be represented at a time in multibyte encoding, whereas all character sets in the world are represented simultaneously by the Unicode representation.  
  
 The MFC framework is Unicode-enabled throughout, and MFC accomplishes Unicode enabling by using portable macros, as shown in the following table.  
  
### Portable Data Types in MFC  
  
|Non-portable data type|Replaced by this macro|  
|-----------------------------|----------------------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|_**TCHAR**|  
|**char\***, **LPSTR (Win32 data type)**|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|  
|**const char\*, LPCSTR (Win32 data type)**|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|  
  
 Class <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> uses **_TCHAR** as its base and provides constructors and operators for easy conversions. Most string operations for Unicode can be written by using the same logic used for handling the Windows ANSI character set, except that the basic unit of operation is a 16-bit character instead of an 8-bit byte. Unlike working with multibyte character sets, you do not have to (and should not) treat a Unicode character as if it were two distinct bytes.  
  
## What do you want to do?  
  
-   [Install Unicode support via MFC](../vs140/unicode-in-mfc.md)  
  
-   [Enable Unicode in my program](../vs140/international-enabling.md)  
  
-   [Enable both Unicode and MBCS in my program](../vs140/internationalization-strategies.md)  
  
-   [Use Unicode to create an internationalized program](../vs140/unicode-programming-summary.md)  
  
-   [Learn the benefits of Unicode, including how using Unicode makes my program more efficient on Windows 2000](../vs140/benefits-of-character-set-portability.md)  
  
-   [Use wmain so I can pass wide-character arguments to my program](../vs140/support-for-using-wmain.md)  
  
-   [See a summary of Unicode programming](../vs140/unicode-programming-summary.md)  
  
-   [Learn about generic-text mappings for byte-width portability](../vs140/generic-text-mappings-in-tchar.h.md)  
  
## See Also  
 [Text and Strings](../vs140/text-and-strings-in-visual-c--.md)   
 [Support for Using wmain](../vs140/support-for-using-wmain.md)