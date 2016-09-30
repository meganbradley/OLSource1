---
title: "Using TCHAR.H Data Types with _MBCS Code"
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
  - ""tchar.h""
  - "TCHAR"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "mapping generic-text"
  - "generic-text data types [C++]"
  - "generic-text mappings [C++]"
  - "MBCS [C++], generic-text mappings"
  - "TCHAR.H data types, mapping"
  - "mappings [C++], TCHAR.H"
ms.assetid: 298583c5-22c3-40f6-920e-9ec96d42abd8
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using TCHAR.H Data Types with _MBCS Code
When the manifest constant **_MBCS** is defined, a given generic-text routine maps to one of the following kinds of routines:  
  
-   An SBCS routine that handles multibyte bytes, characters, and strings appropriately. In this case, the string arguments are expected to be of type **char\***. For example, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> maps to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; the string arguments to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> are of type **char\***. If you use the **_TCHAR** generic-text data type for your string types, the formal and actual parameter types for <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> match because **_TCHAR**\* maps to **char\***.  
  
-   An MBCS-specific routine. In this case, the string arguments are expected to be of type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> **char\***. For example, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> maps to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, which expects and returns a string of type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> **char\***. If you use the **_TCHAR** generic-text data type for your string types, there is a potential type conflict because **_TCHAR** maps to type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 Following are three solutions for preventing this type conflict (and the C compiler warnings or C++ compiler errors that would result):  
  
-   Use the default behavior. Tchar.h provides generic-text routine prototypes for routines in the run-time libraries, as in the following example.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     In the default case, the prototype for <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> maps to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> through a thunk in Libc.lib. This changes the types of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> incoming parameters and outgoing return value from **_TCHAR \*** (that is, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> **\***) to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> **\***. This method ensures type matching when you are using **_TCHAR**, but it is relatively slow due to the function call overhead.  
  
-   Use function inlining by incorporating the following preprocessor statement in your code.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     This method causes an inline function thunk, provided in Tchar.h, to map the generic-text routine directly to the appropriate MBCS routine. The following code excerpt from Tchar.h provides an example of how this is done.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     If you can use inlining, this is the best solution, because it guarantees type matching and has no additional time cost.  
  
-   Use direct mapping by incorporating the following preprocessor statement in your code.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     This approach provides a fast alternative if you do not want to use the default behavior or cannot use inlining. It causes the generic-text routine to be mapped by a macro directly to the MBCS version of the routine, as in the following example from Tchar.h.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     When you take this approach, you must be careful to ensure use of appropriate data types for string arguments and string return values. You can use type casting to ensure proper type matching or you can use the **_TXCHAR** generic-text data type. **_TXCHAR** maps to type <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> in SBCS code but maps to type <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> in MBCS code. For more information about generic-text macros, see [Generic-Text Mappings](../vs140/generic-text-mappings.md) in the *Run-Time Library Reference*.  
  
## See Also  
 [Generic-Text Mappings in Tchar.h](../vs140/generic-text-mappings-in-tchar.h.md)