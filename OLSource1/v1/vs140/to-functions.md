---
title: "to Functions"
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
  - "msvcr120.dll"
  - "msvcr90.dll"
  - "msvcr110.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr80.dll"
  - "msvcr100.dll"
apitype: "DLLExport"
f1_keywords: 
  - "To"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "to functions"
  - "string conversion, to different characters"
  - "string conversion, case"
  - "lowercase, converting strings"
  - "uppercase, converting strings"
  - "case, converting"
  - "characters, converting"
ms.assetid: f636a4c6-8c9f-4be2-baac-064f9dbae300
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# to Functions
Each of the **to** functions and its associated macro, if any, converts a single character to another character.  
  
|||  
|-|-|  
|[__toascii](../vs140/toascii--__toascii.md)|[toupper, _toupper, towupper](../vs140/toupper--_toupper--towupper--_toupper_l--_towupper_l.md)|  
|[tolower, _tolower, towlower](../vs140/tolower--_tolower--towlower--_tolower_l--_towlower_l.md)||  
  
## Remarks  
 The **to** functions and macro conversions are as follows.  
  
|Routine|Macro|Description|  
|-------------|-----------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Converts <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to ASCII character|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Converts <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to lowercase if appropriate|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Converts <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to lowercase|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|None|Converts <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to corresponding wide-character lowercase letter|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Converts <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to uppercase if appropriate|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Converts <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to uppercase|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|None|Converts c to corresponding wide-character uppercase letter|  
  
 To use the function versions of the **to** routines that are also defined as macros, either remove the macro definitions with <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> directives or do not include CTYPE.H. If you use the /Za compiler option, the compiler uses the function version of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. Declarations of the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> functions are in STDLIB.H.  
  
 The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> routine sets all but the low-order 7 bits of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> to 0, so that the converted value represents a character in the ASCII character set. If <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> already represents an ASCII character, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is unchanged.  
  
 The <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> routines:  
  
-   Are dependent on the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> category of the current locale (<CodeContentPlaceHolder>31\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>).  
  
-   Convert <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> represents a convertible letter of the appropriate case in the current locale and the opposite case exists for that locale. Otherwise, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is unchanged.  
  
 The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> routines:  
  
-   Are locale-independent, much faster versions of <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> and **toupper.**  
  
-   Can be used only when **isascii(**<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>**)** and either **isupper(**<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>**)** or **islower(**<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>**)**, respectively, are nonzero.  
  
-   Have undefined results if <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is not an ASCII letter of the appropriate case for converting.  
  
 The <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> functions return a converted copy of <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> if and only if both of the following conditions are nonzero. Otherwise, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> is unchanged.  
  
-   <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is a wide character of the appropriate case (that is, for which <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> or **iswlower,** respectively, is nonzero).  
  
-   There is a corresponding wide character of the target case (that is, for which <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> or **iswupper,** respectively, is nonzero).  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Some of THESE letters are Capitals.**  
**sOME OF these LETTERS ARE cAPITALS.**   
## See Also  
 [Data Conversion](../vs140/data-conversion.md)   
 [Locale](../vs140/locale.md)   
 [is, isw Routines](../vs140/is--isw-routines.md)