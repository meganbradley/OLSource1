---
title: "-keycontainer"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/keycontainer"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "-keycontainer compiler option [Visual Basic]"
  - "keycontainer compiler option [Visual Basic]"
  - "/keycontainer compiler option [Visual Basic]"
ms.assetid: 6a9bc861-1752-4db1-9f64-b5252f0482cc
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -keycontainer
Specifies a key container name for a key pair to give an assembly a strong name.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
  
|||  
|-|-|  
|Term|Definition|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Required. Container file that contains the key. Enclose the file name in quotation marks ("") if the name contains a space.|  
  
## Remarks  
 The compiler creates the sharable component by inserting a public key into the assembly manifest and by signing the final assembly with the private key. To generate a key file, type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> at the command line. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> option installs the key pair into a container. For more information, see [Strong Name Tool (Sn.exe)](assetId:///c1d2b532-1b8e-4c7a-8ac5-53b801135ec6).  
  
 If you compile with <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the name of the key file is held in the module and incorporated into the assembly that is created when you compile an assembly with [/addmodule](../vs140/-addmodule.md).  
  
 You can also specify this option as a custom attribute (\<xref:System.Reflection.AssemblyKeyNameAttribute*>) in the source code for any Microsoft intermediate language (MSIL) module.  
  
 You can also pass your encryption information to the compiler with [/keyfile](../vs140/-keyfile.md). Use [/delaysign](../vs140/-delaysign.md) if you want a partially signed assembly.  
  
 See [Creating and Using Strong-Named Assemblies](assetId:///ffbf6d9e-4a88-4a8a-9645-4ce0ee1ee5f9) for more information on signing an assembly.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> option is not available from within the Visual Studio development environment; it is available only when compiling from the command line.  
  
## Example  
 The following code compiles source file <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and specifies a key container.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Assemblies and the Global Assembly Cache (C# and Visual Basic)](../vs140/assemblies-and-the-global-assembly-cache--csharp-and-visual-basic-.md)   
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [/keyfile](../vs140/-keyfile.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)