---
title: "-Fe (Name EXE File)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Fe (Name EXE File)"
f1_keywords: 
  - "/fe"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-Fe compiler option [C++]"
  - "executable files, renaming"
  - "rename file compiler option [C++]"
  - "/Fe compiler option [C++]"
  - "Fe compiler option [C++]"
ms.assetid: 49f594fd-5e94-45fe-a1bf-7c9f2abb6437
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Fe (Name EXE File)
Specifies a name and a directory for the .exe file or DLL created by the compiler.  
  
## Syntax  
  
```  
/Fepathname  
```  
  
## Remarks  
 Without this option, the compiler gives the file a default name using the base name of the first source or object file specified on the command line and the extension .exe or .dll.  
  
 If you specify the[/c (Compile Without Linking)](../VS_csharp/-c--compile-without-linking-.md), to compile without linking, **/Fe** has no effect.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../Topic/How%20to:%20Open%20Project%20Property%20Pages.md).  
  
2.  Click the **Linker** folder.  
  
3.  Click the **General**property page.  
  
4.  Modify the **Output File** property.  
  
### To set this compiler option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.OutputFile*>.  
  
## Example  
 The following command line compiles and links all C source files in the current directory. The resulting executable file is named PROCESS.exe and is created in the directory C:\BIN.  
  
```  
CL /FeC:\BIN\PROCESS *.C  
```  
  
## Example  
 The following command line creates an executable file in `C:\BIN` with the same base name as the first source or object file:  
  
```  
CL /FeC:\BIN\ *.C  
```  
  
## See Also  
 [Output-File (/F) Options](../VS_csharp/output-file---f--options.md)   
 [Compiler Options](../VS_csharp/compiler-options.md)   
 [Setting Compiler Options](../VS_csharp/setting-compiler-options.md)   
 [Specifying the Pathname](../VS_csharp/specifying-the-pathname.md)