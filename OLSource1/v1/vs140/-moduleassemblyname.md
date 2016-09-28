---
title: "-moduleassemblyname"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/moduleassemblyname"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "moduleassemblyname compiler option [Visual Basic]"
  - "/moduleassemblyname compiler option [Visual Basic]"
  - "-moduleassemblyname compiler option [Visual Basic]"
ms.assetid: 013a57b6-f425-4dd3-b333-512d72c42f55
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -moduleassemblyname
Specifies the name of the assembly that this module will be a part of.  
  
## Syntax  
  
```  
/moduleassemblyname:assembly_name  
```  
  
## Arguments  
  
|||  
|-|-|  
|Term|Definition|  
|`assembly_name`|The name of the assembly that this module will be a part of.|  
  
## Remarks  
 The compiler processes the `/moduleassemblyname` option only if the `/target:module` option has been specified. This causes the compiler to create a module. The module created by the compiler is valid only for the assembly specified with the `/moduleassemblyname` option. If you place the module in a different assembly, run-time errors will occur.  
  
 The `/moduleassemblyname` option is needed only when the following are true:  
  
-   A data type in the module needs access to a `Friend` type in a referenced assembly.  
  
-   The referenced assembly has granted friend assembly access to the assembly into which the module will be built.  
  
 For more information about creating a module, see [/target (Visual Basic)](../vs140/-target--visual-basic-.md). For more information about friend assemblies, see [Friend Assemblies (C# and Visual Basic)](../vs140/friend-assemblies--csharp-and-visual-basic-.md).  
  
> [!NOTE]
>  The `/moduleassemblyname` option is not available from within the Visual Studio development environment; it is available only when you compile from a command prompt.  
  
## See Also  
 [How to: Build a Multifile Assembly](assetId:///261c5583-8a76-412d-bda7-9b8ee3b131e5)   
 [Visual Basic Command-Line Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [/target (Visual Basic)](../vs140/-target--visual-basic-.md)   
 [/main](../vs140/-main.md)   
 [/reference (Visual Basic)](../vs140/-reference--visual-basic-.md)   
 [/addmodule](../vs140/-addmodule.md)   
 [Assemblies and the Global Assembly Cache (C# and Visual Basic)](../vs140/assemblies-and-the-global-assembly-cache--csharp-and-visual-basic-.md)   
 [Sample Compilation Command Lines](../vs140/sample-compilation-command-lines--visual-basic-.md)   
 [Friend Assemblies (C# and Visual Basic)](../vs140/friend-assemblies--csharp-and-visual-basic-.md)