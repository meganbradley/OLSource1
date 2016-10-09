---
title: "-delaysign (C# Compiler Options)"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/delaysign (C# Compiler Options)"
f1_keywords: 
  - "/delaysign"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "-delaysign compiler option [C#]"
  - "delaysign compiler option [C#]"
  - "/delaysign compiler option [C#]"
ms.assetid: bcb058eb-2933-4e7f-b356-5c941db4de75
caps.latest.revision: 16
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
# -delaysign (C# Compiler Options)
This option causes the compiler to reserve space in the output file so that a digital signature can be added later.  
  
## Syntax  
  
```  
/delaysign[ + | - ]  
```  
  
## Arguments  
 `+` &#124; `-`  
 Use **/delaysign-** if you want a fully signed assembly. Use **/delaysign+** if you only want to place the public key in the assembly. The default is **/delaysign-**.  
  
## Remarks  
 The **/delaysign** option has no effect unless used with [/keyfile](../VS_csharp/-keyfile--csharp-compiler-options-.md) or [/keycontainer](../VS_csharp/-keycontainer--csharp-compiler-options-.md).  
  
 When you request a fully signed assembly, the compiler hashes the file that contains the manifest (assembly metadata) and signs that hash with the private key. The resulting digital signature is stored in the file that contains the manifest. When an assembly is delay signed, the compiler does not compute and store the signature, but reserves space in the file so the signature can be added later.  
  
 For example, using **/delaysign+** allows a tester to put the assembly in the global cache. After testing, you can fully sign the assembly by placing the private key in the assembly using the [Assembly Linker](../Topic/Al.exe%20\(Assembly%20Linker\).md) utility.  
  
 For more information, see [Creating and Using Strong-Named Assemblies](../Topic/Creating%20and%20Using%20Strong-Named%20Assemblies.md) and [Delay Signing an Assembly](../Topic/Delay%20Signing%20an%20Assembly.md).  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the **Properties** page for the project.  
  
2.  Modify the **Delay sign only** property.  
  
 For information on how to set this compiler option programmatically, see \<xref:VSLangProj80.ProjectProperties3.DelaySign*>.  
  
## See Also  
 [C# Compiler Options](../VS_csharp/csharp-compiler-options.md)   
 [NIB How to: Modify Project Properties and Configuration Settings](assetId:///e7184bc5-2f2b-4b4f-aa9a-3ecfcbc48b67)