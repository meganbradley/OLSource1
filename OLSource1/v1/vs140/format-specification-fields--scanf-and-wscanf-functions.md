---
title: "Format Specification Fields: scanf and wscanf Functions"
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
  - "msvcr80.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
  - "msvcr100.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr120.dll"
apitype: "DLLExport"
f1_keywords: 
  - "wscanf"
  - "scanf"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "width, specifications in scanf function"
  - "scanf format specifications"
  - "scanf width specifications"
  - "scanf type field characters"
  - "type fields, scanf function"
  - "format specification fields for scanf function"
  - "type fields"
ms.assetid: 7e95de1b-0b71-4de3-9f81-c9560c78e039
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Format Specification Fields: scanf and wscanf Functions
The information here applies to the entire <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> family of functions, including the secure versions and describes the symbols used to tell the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> functions how to parse the input stream, such as the input stream <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, into values that are inserted into program variables.  
  
 A format specification has the following form:  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>] [[width](../vs140/scanf-width-specification.md)] [{[h &#124; l &#124; ll &#124; I64 &#124; L](../vs140/scanf-width-specification.md)}][type](../vs140/scanf-type-field-characters.md)  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> argument specifies the interpretation of the input and can contain one or more of the following:  
  
-   White-space characters: blank (' '); tab ('\t'); or newline ('\n'). A white-space character causes <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to read, but not store, all consecutive white-space characters in the input up to the next non–white-space character. One white-space character in the format matches any number (including 0) and combination of white-space characters in the input.  
  
-   Non–white-space characters, except for the percent sign (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>). A non–white-space character causes <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to read, but not store, a matching non–white-space character. If the next character in the input stream does not match, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> terminates.  
  
-   Format specifications, introduced by the percent sign (<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>). A format specification causes <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to read and convert characters in the input into values of a specified type. The value is assigned to an argument in the argument list.  
  
 The format is read from left to right. Characters outside format specifications are expected to match the sequence of characters in the input stream; the matching characters in the input stream are scanned but not stored. If a character in the input stream conflicts with the format specification, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> terminates, and the character is left in the input stream as if it had not been read.  
  
 When the first format specification is encountered, the value of the first input field is converted according to this specification and stored in the location that is specified by the first <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. The second format specification causes the second input field to be converted and stored in the second <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and so on through the end of the format string.  
  
 An input field is defined as all characters up to the first white-space character (space, tab, or newline), or up to the first character that cannot be converted according to the format specification, or until the field width (if specified) is reached. If there are too many arguments for the given specifications, the extra arguments are evaluated but ignored. The results are unpredictable if there are not enough arguments for the format specification.  
  
 Each field of the format specification is a single character or a number signifying a particular format option. The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> character, which appears after the last optional format field, determines whether the input field is interpreted as a character, a string, or a number.  
  
 The simplest format specification contains only the percent sign and a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> character (for example, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>). If a percent sign (<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>) is followed by a character that has no meaning as a format-control character, that character and the following characters (up to the next percent sign) are treated as an ordinary sequence of characters, that is, a sequence of characters that must match the input. For example, to specify that a percent-sign character is to be input, use <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 An asterisk (<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>) following the percent sign suppresses assignment of the next input field, which is interpreted as a field of the specified type. The field is scanned but not stored.  
  
 The secure versions (those with the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> suffix) of the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> family of functions require that a buffer size parameter be passed immediately following each parameter of type <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. For more information on the secure versions of the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> family of functions, see [scanf_s, wscanf_s](../vs140/scanf_s--_scanf_s_l--wscanf_s--_wscanf_s_l.md).  
  
## See Also  
 [scanf Width Specification](../vs140/scanf-width-specification.md)   
 [scanf Type Field Characters](../vs140/scanf-type-field-characters.md)   
 [scanf, wscanf](../vs140/scanf--_scanf_l--wscanf--_wscanf_l.md)   
 [scanf_s, wscanf_s](../vs140/scanf_s--_scanf_s_l--wscanf_s--_wscanf_s_l.md)