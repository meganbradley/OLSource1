---
title: "SECTIONS (C-C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "SECTIONS (C/C++)"
f1_keywords: 
  - "SECTIONS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SECTIONS .def file statement"
ms.assetid: 7b974366-9ef5-4e57-bbcc-73a1df6f8857
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SECTIONS (C-C++)
Introduces a section of one or more <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> that are access specifiers on sections in your project's output file.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Each definition must be on a separate line. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword can be on the same line as the first definition or on a preceding line. The .def file can contain one or more <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statements.  
  
 This <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement sets attributes for one or more sections in the image file, and can be used to override the default attributes for each type of section.  
  
 The format for <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is:  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 where <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is the name of a section in your program image and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>is one or more of the following access modifiers:  
  
|Modifier|Description|  
|--------------|-----------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|The section is executable|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Allows read operations on data|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Shares the section among all processes that load the image|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Allows write operations on data|  
  
 Separate specifier names with a space. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> marks the beginning of a list of section <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. Each <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> must be on a separate line. The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> keyword can be on the same line as the first <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> or on a preceding line. The .def file can contain one or more <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> statements. The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> keyword is supported as a synonym for <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 Older versions of Visual C++ supported:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> keyword is supported for compatibility, but is ignored.  
  
 An equivalent way to specify section attributes is with the [/SECTION](../vs140/-section--specify-section-attributes-.md) option.  
  
## See Also  
 [Rules for Module-Definition Statements](../vs140/rules-for-module-definition-statements.md)