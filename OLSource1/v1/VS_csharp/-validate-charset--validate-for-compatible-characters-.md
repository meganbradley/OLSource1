---
title: "-validate-charset (Validate for compatible characters)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "cpp"
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/validate-charset (Validate for compatible characters)"
f1_keywords: 
  - "/validate-charset"
  - "validate-charset"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "/validate-charset compiler option"
ms.assetid: 50360fd0-4d32-4a4f-95d0-53d38c12ad4c
caps.latest.revision: 7
---
# -validate-charset (Validate for compatible characters)
Validates that the source file text contains only characters representable as UTF-8.  
  
## Syntax  
  
```  
/validate-charset[-]  
```  
  
## Remarks  
 You can use the **/validate-charset** option to validate that the source code contains only characters that can be represented in both the source character set and the execution character set. This check is enabled automatically when you specify **/source-charset**, **/execution-charset**, or **/utf-8** compiler options. You can explicitly disable this check by specifying the **/validate-charset-** option.  
  
 By default, Visual Studio detects a byte-order mark to determine if the source file is in an encoded Unicode format, for example, UTF-16 or UTF-8. If no byte-order mark is found, it assumes the source file is encoded using the current user code page, unless you have specified a code page by using **/utf-8** or the **/source-charset** option. Visual Studio allows you to save your C++ source code by using any of several character encodings. For information about source and execution character sets, see [Character Sets](../VS_csharp/character-sets2.md) in the language documentation. For a list of supported code page identifiers and character set names, see [Code Page Identifiers](assetId:///5d6fc86a-f205-4d14-bb7c-ecd71682e0fe).  
  
 Visual Studio uses UTF-8 as the internal character encoding during conversion between the source character set and the execution character set. If a character in the source file cannot be represented in the execution character set, the UTF-8 conversion substitutes a question mark '?' character. The **/validate-charset** option causes the compilation to report a warning if this occurs.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project **Property Pages** dialog box. For more information, see [How to: Open Project Property Pages](../Topic/How%20to:%20Open%20Project%20Property%20Pages.md).  
  
2.  Expand the **Configuration Properties**, **C/C++**, **Command Line** folder.  
  
3.  In **Advanced Options**, add the **/validate-charset** option, and specify your preferred encoding.  
  
4.  Choose **OK** to save your changes.  
  
## See Also  
 [Compiler Options](../VS_csharp/compiler-options.md)   
 [Setting Compiler Options](../VS_csharp/setting-compiler-options.md)   
 [/execution-charset](../VS_csharp/-execution-charset--set-execution-character-set-.md)   
 [/source-charset](../VS_csharp/-source-charset--set-source-character-set-.md)   
 [/utf-8](../VS_csharp/-utf-8--set-source-and-executable-character-sets-to-utf-8-.md)