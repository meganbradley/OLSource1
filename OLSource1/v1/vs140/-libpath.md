---
title: "-libpath"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/libpath"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "libpath compiler option [Visual Basic]"
  - "/libpath compiler option [Visual Basic]"
  - "-libpath compiler option [Visual Basic]"
ms.assetid: 5f1c26c9-3455-4e89-bdf3-b12d6c2e655b
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -libpath
Specifies the location of referenced assemblies.  
  
## Syntax  
  
```  
/libpath:dirList  
```  
  
## Arguments  
  
|||  
|-|-|  
|Term|Definition|  
|`dirList`|Required. Semicolon-delimited list of directories for the compiler to look in if a referenced assembly is not found in either the current working directory (the directory from which you are invoking the compiler) or the common language runtime's system directory. If the directory name contains a space, enclose the name in quotation marks (" ").|  
  
## Remarks  
 The `/libpath` option specifies the location of assemblies referenced by the [/reference](../vs140/-reference--visual-basic-.md) option.  
  
 The compiler searches for assembly references that are not fully qualified in the following order:  
  
1.  Current working directory. This is the directory from which the compiler is invoked.  
  
2.  The common language runtime system directory.  
  
3.  Directories specified by `/libpath`.  
  
4.  Directories specified by the LIB environment variable.  
  
 The `/libpath` option is additive; specifying it more than once appends to any prior values.  
  
 Use `/reference` to specify an assembly reference.  
  
||  
|-|  
|To set /libpath in the Visual Studio integrated development environment|  
|1.  Have a project selected in **Solution Explorer**. On the **Project** menu, click **Properties**. For more information, see [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7).<br />2.  Click the **References** tab.<br />3.  Click the **Reference Paths...** button.<br />4.  In the **Reference Paths** dialog box, enter the directory name in the **Folder:** box.<br />5.  Click **Add Folder**.|  
  
## Example  
 The following code compiles `T2.vb` to create an .exe file. The compiler looks in the working directory, in the root directory of the C: drive, and in the New Assemblies directory of the C: drive for assembly references.  
  
```  
vbc /libpath:c:\;"c:\New Assemblies" /reference:t2.dll t2.vb  
```  
  
## See Also  
 [Assemblies and the Global Assembly Cache (C# and Visual Basic)](../vs140/assemblies-and-the-global-assembly-cache--csharp-and-visual-basic-.md)   
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)