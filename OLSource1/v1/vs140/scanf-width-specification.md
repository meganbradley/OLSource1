---
title: "scanf Width Specification"
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
  - "msvcr100.dll"
  - "msvcr120.dll"
  - "msvcr80.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr110.dll"
  - "msvcr90.dll"
apitype: "DLLExport"
f1_keywords: 
  - "scanf"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "scanf function, width specification"
ms.assetid: 94b4e8fe-c4a2-4799-8b6c-a2cf28ffb09c
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# scanf Width Specification
This information applies to the interpretation of format strings in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> family of functions, including the secure versions such as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. These functions normally assume the input stream is divided into a sequence of tokens. Tokens are separated by whitespace (space, tab, or newline), or in the case of numerical types, by the natural end of a numerical data type as indicated by the first character that cannot be converted into numerical text. However, the width specification may be used to cause parsing of the input to stop before the natural end of a token.  
  
 The *width* specification consists of characters between the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and the type field specifier, which may include a positive integer called the *width* field and one or more characters indicating the size of the field, which may also be considered as modifiers of the type of the field, such as an indication of whether the integer type is **short** or **long**. Such characters are referred to as the size prefix.  
  
## The Width Field  
 *The width* field is a positive decimal integer controlling the maximum number of characters to be read for that field. No more than *width* characters are converted and stored at the corresponding <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Fewer than *width* characters may be read if a whitespace character (space, tab, or newline) or a character that cannot be converted according to the given format occurs before *width* is reached.  
  
 The width specification is separate and distinct from the buffer size argument required by the secure versions of these functions (i.e., <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, etc.). In the following example, the width specification is 20, indicating that up to 20 characters are to be read from the input stream. The buffer length is 21, which includes room for the possible 20 characters plus the null terminator:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If the *width* field is not used, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> will attempt to read the entire token into the string. If the size specified is not large enough to hold the entire token, nothing will be written to the destination string. If the *width* field is specified, then the first *width* characters in the token will be written to the destination string along with the null terminator.  
  
## The Size Prefix  
 The optional prefixes **h**, **l**, **ll**, **I64**, and **L** indicate the size of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> (long or short, single-byte character or wide character, depending upon the type character that they modify). These format-specification characters are used with type characters in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> functions to specify interpretation of arguments as shown in the following table. The type prefix **I64** is a Microsoft extension and is not ANSI compatible. The type characters and their meanings are described in the "Type Characters for scanf functions" table in [scanf Type Field Characters](../vs140/scanf-type-field-characters.md).  
  
> [!NOTE]
>  The **h**, **l**, and **L** prefixes are Microsoft extensions when used with data of type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
### Size Prefixes for scanf and wscanf Format-Type Specifiers  
  
|To specify|Use prefix|With type specifier|  
|----------------|----------------|-------------------------|  
|**double**|**l**|**e**, **E**, **f**, **g**, or **G**|  
|**long double** (same as double)|**L**|**e**, **E**, **f**, **g**, or **G**|  
|**long int**|**l**|**d**, **i**, **o**, **x**, or **X**|  
|**long unsigned int**|**l**|**u**|  
|**long long**|**ll**|**d**, **i**, **o**, **x**, or **X**|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|**h**|**d**, **i**, **o**, **x**, or **X**|  
|**short unsigned int**|**h**|**u**|  
|__**int64**|**I64**|**d**, **i**, **o**, **u**, **x**, or **X**|  
|Single-byte character with <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|**h**|**c** or **C**|  
|Single-byte character with <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|**h**|**c** or **C**|  
|Wide character with <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|**l**|**c** or **C**|  
|Wide character with <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|**l**|**c**, or **C**|  
|Single-byte – character string with <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|**h**|**s** or **S**|  
|Single-byte – character string with <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|**h**|**s** or **S**|  
|Wide-character string with <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|**l**|**s** or **S**|  
|Wide-character string with <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|**l**|**s** or **S**|  
  
 The following examples use **h** and **l** with <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> functions and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> functions:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If using an unsecure function in the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> family, omit the size parameter indicating the buffer length of the preceding argument.  
  
## Reading Undelimited strings  
 To read strings not delimited by whitespace characters, a set of characters in brackets (**[ ]**) can be substituted for the **s** (string) type character. The set of characters in brackets is referred to as a control string. The corresponding input field is read up to the first character that does not appear in the control string. If the first character in the set is a caret (**^**), the effect is reversed: The input field is read up to the first character that does appear in the rest of the character set.  
  
 Note that **%[a-z]** and **%[z-a]** are interpreted as equivalent to **%[abcde...z]**. This is a common <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> function extension, but note that the ANSI standard does not require it.  
  
## Reading Unterminated strings  
 To store a string without storing a terminating null character ('\0'), use the specification <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>*n***c** where *n* is a decimal integer. In this case, the **c** type character indicates that the argument is a pointer to a character array. The next *n* characters are read from the input stream into the specified location, and no null character ('\0') is appended. If *n* is not specified, its default value is 1.  
  
## When scanf stops reading a field  
 The <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> function scans each input field, character by character. It may stop reading a particular input field before it reaches a space character for a variety of reasons:  
  
-   The specified width has been reached.  
  
-   The next character cannot be converted as specified.  
  
-   The next character conflicts with a character in the control string that it is supposed to match.  
  
-   The next character fails to appear in a given character set.  
  
 For whatever reason, when the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> function stops reading an input field, the next input field is considered to begin at the first unread character. The conflicting character, if there is one, is considered unread and is the first character of the next input field or the first character in subsequent read operations on the input stream.  
  
## See Also  
 [scanf, _scanf_l, wscanf, _wscanf_l](../vs140/scanf--_scanf_l--wscanf--_wscanf_l.md)   
 [scanf_s, wscanf_s](../vs140/scanf_s--_scanf_s_l--wscanf_s--_wscanf_s_l.md)   
 [Format Specification Fields: scanf and wscanf Functions](../vs140/format-specification-fields--scanf-and-wscanf-functions.md)   
 [scanf Type Field Characters](../vs140/scanf-type-field-characters.md)