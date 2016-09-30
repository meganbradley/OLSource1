---
title: "C-C++ Building Reference"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "C/C++ Building Reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "compiling source code [C++], additional information"
  - "cl.exe compiler [C++], building programs"
  - "linker [C++], building reference"
  - "builds [C++], additional information"
ms.assetid: 100b4ccf-572c-4d1f-970c-fa0bc0cc0d2d
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# C-C++ Building Reference
Visual C++ provides two ways of building a C/C++ program. The easiest (and most common) way is to [build within the Visual C++ development environment](../vs140/building-c---projects-in-visual-studio.md). The other way is to [build from a command prompt using command-line tools](../vs140/building-on-the-command-line.md). In either case, you can create your source files using the Visual C++ source editor or a third-party editor of your choice.  
  
 If your program uses a makefile rather than a .vcxproj file, you can still build it in the development environment as an [external project](../vs140/building-external-projects.md).  
  
## In This Section  
 [Compiling a C/C++ Program](../vs140/compiling-a-c-c---program.md)  
 Describes the compiler, which creates an object file containing machine code, linker directives, sections, external references, and function/data names.  
  
 [Linking](../vs140/linking.md)  
 Describes the linker, which combines code from the object files created by the compiler and from statically linked libraries, resolves the name references, and creates an executable file.  
  
 [Release Builds](../vs140/release-builds.md)  
 Presents information on why and when you would want to change from a debug build to a release build and also discusses some of the problems you may encounter when changing from a debug to a release build.  
  
 [Optimizing Your Code](../vs140/optimizing-your-code.md)  
 Provides links to topics discussing the mechanisms for optimizing code:  
  
 [C/C++ Build Tools](../vs140/c-c---build-tools.md)  
 Provides the following command-line tools for viewing or manipulating build output:  
  
 [C/C++ Build Errors](../vs140/c-c---build-errors.md)  
 Introduces the build errors section in the table of contents.  
  
## Related Sections  
 [C/C++ Preprocessor Reference](../vs140/c-c---preprocessor-reference.md)  
 Discusses the preprocessor, which prepares source files for the compiler by translating macros, operators, and directives.  
  
 [Understanding Custom Build Steps and Build Events](../vs140/understanding-custom-build-steps-and-build-events.md)  
 Discusses customizing the build process.  
  
 [Building a C/C++ Program](../vs140/building-c-c---programs.md)  
 Provides links to topics describing building your program from the command line or from the integrated development environment of Visual Studio.  
  
 [Setting Compiler Options](../vs140/setting-compiler-options.md)  
 Describes setting compiler options in the development environment or on the command line.  
  
 [Compiler Options](../vs140/compiler-options.md)  
 Provides links to topics discussing using compiler options.  
  
 [Setting Linker Options](../vs140/setting-linker-options.md)  
 Describes setting linker options inside or outside the integrated development environment.  
  
 [Linker Options](../vs140/linker-options.md)  
 Provides links to topics discussing using linker options.  
  
 [BSCMAKE Reference](../vs140/bscmake-reference.md)  
 Describes the Microsoft Browse Information Maintenance Utility (BSCMAKE.EXE), which builds a browse information file (.bsc) from .sbr files created during compilation.  
  
 [LIB Reference](../vs140/lib-reference.md)  
 Describes the Microsoft Library Manager (LIB.exe), which creates and manages a library of Common Object File Format (COFF) object files.  
  
 [EDITBIN Reference](../vs140/editbin-reference.md)  
 Describes the Microsoft COFF Binary File Editor (EDITBIN.EXE), which modifies Common Object File Format (COFF) binary files.  
  
 [DUMPBIN Reference](../vs140/dumpbin-reference.md)  
 Describes the Microsoft COFF Binary File Dumper (DUMPBIN.EXE), which displays information about Common Object File Format (COFF) binary files.  
  
 [NMAKE Reference](../vs140/nmake-reference.md)  
 Describes the Microsoft Program Maintenance Utility (NMAKE.EXE), which is a tool that builds projects based on commands contained in a description file.