---
title: "SBCS and MBCS Data Types"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "MBCS"
  - "SBCS"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "SBCS and MBCS data types"
  - "data types [C], MBCS and SBCS"
ms.assetid: 4c3ef9da-e397-48d4-800e-49dba36db171
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SBCS and MBCS Data Types
Any Microsoft <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> run-time library routine that handles only one multibyte character or one byte of a multibyte character expects an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> argument (where 0x00 <= character value <= 0xFFFF and 0x00 <= byte value <= 0xFF ). An <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> routine that handles multibyte bytes or characters in a string context expects a multibyte-character string to be represented as an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> pointer.  
  
> [!CAUTION]
>  Each byte of a multibyte character can be represented in an 8-bit <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. However, an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> single-byte character of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> with a value greater than 0x7F is negative. When such a character is converted directly to an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, the result is sign-extended by the compiler and can therefore yield unexpected results.  
  
 Therefore it is best to represent a byte of a multibyte character as an 8-bit <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. Or, to avoid a negative result, simply convert a single-byte character of type <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to an <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> before converting it to an <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 Because some <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> string-handling functions take (signed) <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> parameters, a type mismatch compiler warning will result when <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is defined. There are three ways to avoid this warning, listed in order of efficiency:  
  
1.  Use the "type-safe" inline functions in TCHAR.H. This is the default behavior.  
  
2.  Use the "direct" macros in TCHAR.H by defining <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> on the command line. If you do this, you must manually match types. This is the fastest method but is not type-safe.  
  
3.  Use the "type-safe" statically linked library functions in TCHAR.H. To do so, define the constant <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> on the command line. This is the slowest method, but the most type-safe.  
  
## See Also  
 [Internationalization](../vs140/internationalization.md)   
 [Run-Time Routines by Category](../vs140/run-time-routines-by-category.md)