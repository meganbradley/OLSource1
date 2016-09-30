---
title: "Using Generic-Text Mappings"
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
  - "_UNICODE"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "_TXCHAR type"
  - "TINT type"
  - "_TCHAR type"
  - "TSCHAR type"
  - "TEXT type"
  - "TCHAR type"
  - "TCHAR.H data types, mappings defined in"
  - "generic-text data types"
  - "_TINT type"
  - "TUCHAR type"
  - "_UNICODE constant"
  - "TXCHAR type"
  - "generic-text mappings"
  - "_TSCHAR type"
  - "T type"
  - "mappings, generic-text"
  - "_TUCHAR type"
  - "MBCS data type"
  - "_MBCS data type"
  - "_TEXT type"
  - "UNICODE constant"
  - "_T type"
ms.assetid: 2848121c-e51f-4b9b-a2e6-833ece4b0cb3
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Generic-Text Mappings
**Microsoft Specific**  
  
 To simplify code development for various international markets, the Microsoft run-time library provides Microsoft-specific "generic-text" mappings for many data types, routines, and other objects. These mappings are defined in TCHAR.H. You can use these name mappings to write generic code that can be compiled for any of the three kinds of character sets: ASCII (SBCS), MBCS, or Unicode, depending on a manifest constant you define using a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement. Generic-text mappings are Microsoft extensions that are not ANSI compatible.  
  
### Preprocessor Directives for Generic-Text Mappings  
  
|#define|Compiled version|Example|  
|--------------|----------------------|-------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Unicode (wide-character)|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> maps to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Multibyte-character|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> maps to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
|None (the default: neither <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> nor <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> defined)|SBCS (ASCII)|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> maps to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|  
  
 For example, the generic-text function <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, defined in TCHAR.H, maps to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> has been defined in your program, or to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> has been defined. Otherwise <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> maps to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 The generic-text data type <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, also defined in TCHAR.H, maps to type <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is defined, to type <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is defined, and to type <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> if neither constant is defined. Other data type mappings are provided in TCHAR.H for programming convenience, but <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is the type that is most useful.  
  
### Generic-Text Data Type Mappings  
  
|Generic-text data type name|SBCS (_UNICODE, _MBCS not defined)|_MBCS defined|_UNICODE defined|  
|----------------------------------|--------------------------------------------|--------------------|-----------------------|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|No effect (removed by preprocessor)|No effect (removed by preprocessor)|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder> (converts following character or string to its Unicode counterpart)|  
  
 For a complete list of generic-text mappings of routines, variables, and other objects, see [Generic-Text Mappings](../vs140/generic-text-mappings.md).  
  
 The following code fragments illustrate the use of <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> for mapping to the MBCS, Unicode, and SBCS models.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> has been defined, the preprocessor maps the preceding fragment to the following code:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> has been defined, the preprocessor maps the same fragment to the following code:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If neither <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> nor <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> has been defined, the preprocessor maps the fragment to single-byte ASCII code, as follows:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Thus you can write, maintain, and compile a single source code file to run with routines that are specific to any of the three kinds of character sets.  
  
 **END Microsoft Specific**  
  
## See Also  
 [Generic-Text Mappings](../vs140/generic-text-mappings.md)   
 [Data Type Mappings](../vs140/data-type-mappings.md)   
 [Constant and Global Variable Mappings](../vs140/constant-and-global-variable-mappings.md)   
 [Routine Mappings](../vs140/routine-mappings.md)   
 [A Sample Generic-Text Program](../vs140/a-sample-generic-text-program.md)