---
title: "Using TCHAR.H Data Types with _MBCS"
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
  - "_mbcs"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "TCHAR.H data types"
  - "MBCS data type"
  - "_MBCS data type"
ms.assetid: 48f471e7-9d2b-4a39-b841-16a0e15c0a18
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using TCHAR.H Data Types with _MBCS
**Microsoft Specific**  
  
 As the table of generic-text routine mappings indicates (see [Generic-Text Mappings](../vs140/generic-text-mappings.md)), when the manifest constant <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is defined, a given generic-text routine maps to one of the following kinds of routines:  
  
-   An SBCS routine that handles multibyte bytes, characters, and strings appropriately. In this case, the string arguments are expected to be of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. For example, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> maps to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>; the string arguments to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> are of type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. If you use the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> generic-text data type for your string types, the formal and actual parameter types for <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> match because <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> maps to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
-   An MBCS-specific routine. In this case, the string arguments are expected to be of type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. For example, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> maps to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, which expects and returns a string of type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. Again, if you use the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> generic-text data type for your string types, there is a potential type conflict because <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> maps to type <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 Following are three solutions for preventing this type conflict (and the C compiler warnings or C++ compiler errors that would result):  
  
-   Use the default behavior. TCHAR.H provides generic-text routine prototypes for routines in the run-time libraries, as in the following example.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     In the default case, the prototype for <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> maps to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> through a thunk in LIBC.LIB. This changes the types of the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> incoming parameters and outgoing return value from <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> (such as <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>) to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. This method ensures type matching when you are using <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, but it is relatively slow because of the function call overhead.  
  
-   Use function inlining by incorporating the following preprocessor statement in your code.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     This method causes an inline function thunk, provided in TCHAR.H, to map the generic-text routine directly to the appropriate MBCS routine. The following code excerpt from TCHAR.H provides an example of how this is done.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     If you can use inlining, this is the best solution, because it guarantees type matching and has no additional time cost.  
  
-   Use "direct mapping" by incorporating the following preprocessor statement in your code.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     This approach provides a fast alternative if you do not want to use the default behavior or cannot use inlining. It causes the generic-text routine to be mapped by a macro directly to the MBCS version of the routine, as in the following example from TCHAR.H.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 When you take this approach, you must be careful to ensure that appropriate data types are used for string arguments and string return values. You can use type casting to ensure proper type matching or you can use the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> generic-text data type. <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> maps to type <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> in SBCS code but maps to type <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> in MBCS code. For more information about generic-text macros, see [Generic-Text Mappings](../vs140/generic-text-mappings.md).  
  
 **END Microsoft Specific**  
  
## See Also  
 [Internationalization](../vs140/internationalization.md)   
 [Run-Time Routines by Category](../vs140/run-time-routines-by-category.md)