---
title: "-keycontainer (C# Compiler Options)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 17
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
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
  
 If you compile with [/target:module](../VS_csharp/-target-module--csharp-compiler-options-.md), the name of the key file is held in the module and incorporated into the assembly when you compile this module into an assembly with [/addmodule](../VS_csharp/-addmodule--csharp-compiler-options-.md).  
  
 You can also specify this option as a custom attribute (\<xref:System.Reflection.AssemblyKeyNameAttribute?displayProperty=fullName>) in the source code for any Microsoft intermediate language (MSIL) module.  
  
 You can also pass your encryption information to the compiler with [/keyfile](../VS_csharp/-keyfile--csharp-compiler-options-.md). Use [/delaysign](../VS_csharp/-delaysign--csharp-compiler-options-.md) if you want the public key added to the assembly manifest but want to delay signing the assembly until it has been tested.  
  
 For more information, see [Creating and Using Strong-Named Assemblies](../Topic/Creating%20and%20Using%20Strong-Named%20Assemblies.md) and [Delay Signing an Assembly](../Topic/Delay%20Signing%20an%20Assembly.md).  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  This compiler option is not available in the Visual Studio development environment.  
  
 You can programmatically access this compiler option with \<xref:VSLangProj.ProjectProperties.AssemblyKeyContainerName*>.  
  
## See Also  
 [C# Compiler Options](../VS_csharp/csharp-compiler-options.md)   
 [NIB How to: Modify Project Properties and Configuration Settings](assetId:///e7184bc5-2f2b-4b4f-aa9a-3ecfcbc48b67)