---
title: "comment (C-C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "comment (C/C++)"
f1_keywords: 
  - "vc-pragma.comment"
  - "comment_CPP"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "annotations [C++]"
  - "comments [C++], compiled files"
  - "pragmas, comment"
  - "comment pragma"
ms.assetid: 20f099ff-6303-49b3-9c03-a94b6aa69b85
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# comment (C-C++)
Places a comment record into an object file or executable file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The *comment-type* is one of the predefined identifiers, described below, that specifies the type of comment record. The optional <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is a string literal that provides additional information for some comment types. Because <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is a string literal, it obeys all the rules for string literals with respect to escape characters, embedded quotation marks (**"**), and concatenation.  
  
 **compiler**  
 Places the name and version number of the compiler in the object file. This comment record is ignored by the linker. If you supply a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter for this record type, the compiler generates a warning.  
  
 **exestr**  
 Places <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in the object file. At link time this string is placed in the executable file. The string is not loaded into memory when the executable file is loaded; however, it can be found with a program that finds printable strings in files. One use for this comment-record type is to embed a version number or similar information in an executable file.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is deprecated and will be removed in a future release; the linker does not process the comment record.  
  
 **lib**  
 Places a library-search record in the object file. This comment type must be accompanied by a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter containing the name (and possibly the path) of the library that you want the linker to search. The library name follows the default library-search records in the object file; the linker searches for this library just as if you had named it on the command line provided that the library is not specified with [/nodefaultlib](../vs140/-nodefaultlib--ignore-libraries-.md). You can place multiple library-search records in the same source file; each record appears in the object file in the same order in which it is encountered in the source file.  
  
 If the order of the default library and an added library is important, compiling with the [/Zl](../vs140/-zl--omit-default-library-name-.md) switch will prevent the default library name from being placed in the object module. A second comment pragma then can be used to insert the name of the default library after the added library. The libraries listed with these pragmas will appear in the object module in the same order they are found in the source code.  
  
 **linker**  
 Places a [linker option](../vs140/linker-options.md) in the object file. You can use this comment-type to specify a linker option instead of passing it to the command line or specifying it in the development environment. For example, you can specify the /include option to force the inclusion of a symbol:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Only the following (*comment-type*) linker options are available to be passed to the linker identifier:  
  
-   [/DEFAULTLIB](../vs140/-defaultlib--specify-default-library-.md)  
  
-   [/EXPORT](../vs140/-export--exports-a-function-.md)  
  
-   [/INCLUDE](../vs140/-include--force-symbol-references-.md)  
  
-   [/MANIFESTDEPENDENCY](../vs140/-manifestdependency--specify-manifest-dependencies-.md)  
  
-   [/MERGE](../vs140/-merge--combine-sections-.md)  
  
-   [/SECTION](../vs140/-section--specify-section-attributes-.md)  
  
 **user**  
 Places a general comment in the object file. The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter contains the text of the comment. This comment record is ignored by the linker.  
  
 The following pragma causes the linker to search for the EMAPI.LIB library while linking. The linker searches first in the current working directory and then in the path specified in the LIB environment variable.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The following pragma causes the compiler to place the name and version number of the compiler in the object file:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
> [!NOTE]
>  For comments that take a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter, you can use a macro in any place where you would use a string literal, provided that the macro expands to a string literal. You can also concatenate any combination of string literals and macros that expand to string literals. For example, the following statement is acceptable:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [Pragma Directives and the __Pragma Keyword](../vs140/pragma-directives-and-the-__pragma-keyword.md)