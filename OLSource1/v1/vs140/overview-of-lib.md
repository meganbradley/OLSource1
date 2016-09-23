---
title: "Overview of LIB"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - Lib
dev_langs: 
  - C++
helpviewer_keywords: 
  - LIB [C++], modes
ms.assetid: e997d423-f574-434f-8b56-25585d137ee0
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Overview of LIB
LIB creates standard libraries, import libraries, and export files you can use with [LINK](../vs140/linker-options.md) when building a program. LIB runs from a command prompt.  
  
 You can use LIB in the following modes:  
  
-   [Building or modifying a COFF library](../vs140/managing-a-library.md)  
  
-   [Extracting a member object to a file](../vs140/extracting-a-library-member.md)  
  
-   [Creating an export file and an import library](../vs140/working-with-import-libraries-and-export-files.md)  
  
 These modes are mutually exclusive; you can use LIB in only one mode at a time.  
  
## Lib Options  
 The following table lists the options for lib.exe, with a link to more information.  
  
 **/DEF**  
 Create an import library and an export file.  
  
 For more information see [Building an Import Library and Export File](../vs140/building-an-import-library-and-export-file.md).  
  
 **/ERRORREPORT**  
 Send information to Microsoft about internal errors with lib.exe.  
  
 For more information see [Running LIB](../vs140/running-lib.md).  
  
 **/EXPORT**  
 Exports a function from your program.  
  
 For more information see [Building an Import Library and Export File](../vs140/building-an-import-library-and-export-file.md).  
  
 **/EXTRACT**  
 Create an object (.obj) file that contains a copy of a member of an existing library.  
  
 For more information see [Extracting a Library Member](../vs140/extracting-a-library-member.md).  
  
 **/INCLUDE**  
 Adds a symbol to the symbol table.  
  
 For more information see [Building an Import Library and Export File](../vs140/building-an-import-library-and-export-file.md).  
  
 **/LIBPATH**  
 Overrides the environment library path.  
  
 For more information see [Managing a Library](../vs140/managing-a-library.md).  
  
 **/LIST**  
 Displays information about the output library to standard output.  
  
 For more information see [Managing a Library](../vs140/managing-a-library.md).  
  
 **/LTCG**  
 Causes the library to be built using link-time code generation.  
  
 For more information see [Running LIB](../vs140/running-lib.md).  
  
 **/MACHINE**  
 Specifies the target platform for the program.  
  
 For more information see [Running LIB](../vs140/running-lib.md).  
  
 **/NAME**  
 When building an import library, specifies the name of the DLL for which the import library is being built.  
  
 For more information see [Managing a Library](../vs140/managing-a-library.md).  
  
 **/NODEFAULTLIB**  
 Removes one or more default libraries from the list of libraries it searches when resolving external references.  
  
 For more information see [Managing a Library](../vs140/managing-a-library.md).  
  
 **/NOLOGO**  
 Suppresses display of the LIB copyright message and version number and prevents echoing of command files.  
  
 For more information see [Running LIB](../vs140/running-lib.md).  
  
 **/OUT**  
 Overrides the default output filename.  
  
 For more information see [Managing a Library](../vs140/managing-a-library.md).  
  
 **/REMOVE**  
 Omits an object from the output library.  
  
 For more information see [Managing a Library](../vs140/managing-a-library.md).  
  
 **/SUBSYSTEM**  
 Tells the operating system how to run a program created by linking to the output library.  
  
 For more information see [Managing a Library](../vs140/managing-a-library.md).  
  
 **/VERBOSE**  
 Displays details about the progress of the session, including names of the .obj files being added.  
  
 For more information see [Running LIB](../vs140/running-lib.md).  
  
 **/WX**  
 Treat warnings as errors.  
  
 For more information see [Running LIB](../vs140/running-lib.md).  
  
## See Also  
 [LIB Reference](../vs140/lib-reference.md)   
 [LIB Input Files](../vs140/lib-input-files.md)   
 [LIB Output Files](../vs140/lib-output-files.md)   
 [Other LIB Output](../vs140/other-lib-output.md)   
 [Structure of a Library](../vs140/structure-of-a-library.md)