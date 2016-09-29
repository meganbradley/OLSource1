---
title: "-keycontainer (C# Compiler Options)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/keycontainer (C# Compiler Options)"
f1_keywords: 
  - "/keycontainer"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "/keycontainer compiler option [C#]"
  - "keycontainer compiler option [C#]"
  - "-keycontainer compiler option [C#]"
ms.assetid: b3982b6d-2382-4f7e-bebd-ce98eaa30763
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -keycontainer (C# Compiler Options)
Specifies the name of the cryptographic key container.  
  
## Syntax  
  
```  
/keycontainer:string  
```  
  
## Arguments  
 `string`  
 The name of the strong name key container.  
  
## Remarks  
 When the **/keycontainer** option is used, the compiler creates a sharable component by inserting a public key from the specified container into the assembly manifest and signing the final assembly with the private key. To generate a key file, type sn -k `file` at the command line. sn -i installs the key pair into a container.  
  
 If you compile with [/target:module](../vs140/-target-module--csharp-compiler-options-.md), the name of the key file is held in the module and incorporated into the assembly when you compile this module into an assembly with [/addmodule](../vs140/-addmodule--csharp-compiler-options-.md).  
  
 You can also specify this option as a custom attribute (<xref:System.Reflection.AssemblyKeyNameAttribute*?displayProperty=fullName>) in the source code for any Microsoft intermediate language (MSIL) module.  
  
 You can also pass your encryption information to the compiler with [/keyfile](../vs140/-keyfile--csharp-compiler-options-.md). Use [/delaysign](../vs140/-delaysign--csharp-compiler-options-.md) if you want the public key added to the assembly manifest but want to delay signing the assembly until it has been tested.  
  
 For more information, see [Creating and Using Strong-Named Assemblies](assetId:///ffbf6d9e-4a88-4a8a-9645-4ce0ee1ee5f9) and [Delay Signing an Assembly](assetId:///9d300e17-5bf1-4360-97da-2aa55efd9070).  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  This compiler option is not available in the Visual Studio development environment.  
  
 You can programmatically access this compiler option with <xref:VSLangProj.ProjectProperties.AssemblyKeyContainerName*>.  
  
## See Also  
 [C# Compiler Options](../vs140/csharp-compiler-options.md)   
 [NIB How to: Modify Project Properties and Configuration Settings](assetId:///e7184bc5-2f2b-4b4f-aa9a-3ecfcbc48b67)