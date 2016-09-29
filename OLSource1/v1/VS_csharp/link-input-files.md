---
title: "LINK Input Files"
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
  - "link"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "files [C++], LINK"
  - "module definition files"
  - "resources [C++], linker files"
  - "LINK tool [C++], input files"
  - "module definition files, linker files"
  - "input files [C++], LINK"
  - "linker [C++], input files"
  - "import libraries [C++], linker files"
  - "command input to linker files [C++]"
ms.assetid: bb26fcc5-509a-4620-bc3e-b6c6e603a412
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# LINK Input Files
You provide the linker with files that contain objects, import and standard libraries, resources, module definitions, and command input. LINK does not use file extensions to make assumptions about the contents of a file. Instead, LINK examines each input file to determine what kind of file it is.  
  
 Object files on the command line are processed in the order they appear on the command line. Libraries are searched in command line order as well, with the following caveat: Symbols that are unresolved when bringing in an object file from a library are searched for in that library first, and then the following libraries from the command line and [/DEFAULTLIB (Specify Default Library)](../VS_csharp/-defaultlib--specify-default-library-.md) directives, and then to any libraries at the beginning of the command line.  
  
> [!NOTE]
>  LINK no longer accepts a semicolon (or any other character) as the start of a comment in response files and order files. Semicolons are recognized only as the start of comments in module-definition files (.def).  
  
 LINK uses the following types of input files:  
  
-   [.obj files](../VS_csharp/.obj-files-as-linker-input.md)  
  
-   [.netmodule files](../VS_csharp/.netmodule-files-as-linker-input.md)  
  
-   [.lib files](../VS_csharp/.lib-files-as-linker-input.md)  
  
-   [.exp files](../VS_csharp/.exp-files-as-linker-input.md)  
  
-   [.def files](../VS_csharp/.def-files-as-linker-input.md)  
  
-   [.pdb files](../VS_csharp/.pdb-files-as-linker-input.md)  
  
-   [.res files](../VS_csharp/.res-files-as-linker-input.md)  
  
-   [.exe files](../VS_csharp/.exe-files-as-linker-input.md)  
  
-   [.txt files](../VS_csharp/.txt-files-as-linker-input.md)  
  
-   [.ilk files](../VS_csharp/.ilk-files-as-linker-input.md)  
  
## See Also  
 [Setting Linker Options](../VS_csharp/setting-linker-options.md)   
 [Linker Options](../VS_csharp/linker-options.md)