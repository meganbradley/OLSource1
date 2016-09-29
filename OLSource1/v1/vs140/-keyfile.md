---
title: "-keyfile"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/keyfile"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "/keyfile compiler option [Visual Basic]"
  - "keyfile compiler option [Visual Basic]"
  - "-keyfile compiler option [Visual Basic]"
ms.assetid: ffa82a4b-517a-4c6c-9889-5bae7b534bb8
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -keyfile
Specifies a file containing a key or key pair to give an assembly a strong name.  
  
## Syntax  
  
```  
/keyfile:file  
```  
  
## Arguments  
 `file`  
 Required. File that contains the key. If the file name contains a space, enclose the name in quotation marks (" ").  
  
## Remarks  
 The compiler inserts the public key into the assembly manifest and then signs the final assembly with the private key. To generate a key file, type `sn -k file` at the command line. For more information, see [Strong Name Tool (Sn.exe)](assetId:///c1d2b532-1b8e-4c7a-8ac5-53b801135ec6).  
  
 If you compile with `/target:module`, the name of the key file is held in the module and incorporated into the assembly that is created when you compile an assembly with [/addmodule](../vs140/-addmodule.md).  
  
 You can also pass your encryption information to the compiler with [/keycontainer](../vs140/-keycontainer.md). Use [/delaysign](../vs140/-delaysign.md) if you want a partially signed assembly.  
  
 You can also specify this option as a custom attribute (<xref:System.Reflection.AssemblyKeyFileAttribute*>) in the source code for any Microsoft intermediate language module.  
  
 In case both `/keyfile` and [/keycontainer](../vs140/-keycontainer.md) are specified (either by command-line option or by custom attribute) in the same compilation, the compiler first tries the key container. If that succeeds, then the assembly is signed with the information in the key container. If the compiler does not find the key container, it tries the file specified with `/keyfile`. If this succeeds, the assembly is signed with the information in the key file, and the key information is installed in the key container (similar to `sn -i`) so that on the next compilation, the key container will be valid.  
  
 Note that a key file might contain only the public key.  
  
 See [Creating and Using Strong-Named Assemblies](assetId:///ffbf6d9e-4a88-4a8a-9645-4ce0ee1ee5f9) for more information on signing an assembly.  
  
> [!NOTE]
>  The `/keyfile` option is not available from within the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] development environment; it is available only when compiling from the command line.  
  
## Example  
 The following code compiles source file `Input.vb` and specifies a key file.  
  
```  
vbc /keyfile:myfile.sn input.vb  
```  
  
## See Also  
 [Assemblies and the Global Assembly Cache (C# and Visual Basic)](../vs140/assemblies-and-the-global-assembly-cache--csharp-and-visual-basic-.md)   
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [/reference (Visual Basic)](../vs140/-reference--visual-basic-.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)