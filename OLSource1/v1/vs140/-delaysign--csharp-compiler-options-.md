---
title: "-delaysign (C# Compiler Options)"
ms.custom: na
ms.date: "09/22/2016"
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
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -delaysign (C# Compiler Options)
This option causes the compiler to reserve space in the output file so that a digital signature can be added later.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Use **/delaysign-** if you want a fully signed assembly. Use **/delaysign+** if you only want to place the public key in the assembly. The default is **/delaysign-**.  
  
## Remarks  
 The **/delaysign** option has no effect unless used with [/keyfile](../vs140/-keyfile--csharp-compiler-options-.md) or [/keycontainer](../vs140/-keycontainer--csharp-compiler-options-.md).  
  
 When you request a fully signed assembly, the compiler hashes the file that contains the manifest (assembly metadata) and signs that hash with the private key. The resulting digital signature is stored in the file that contains the manifest. When an assembly is delay signed, the compiler does not compute and store the signature, but reserves space in the file so the signature can be added later.  
  
 For example, using **/delaysign+** allows a tester to put the assembly in the global cache. After testing, you can fully sign the assembly by placing the private key in the assembly using the [Assembly Linker](assetId:///b5382965-0053-47cf-b92f-862860275a01) utility.  
  
 For more information, see [Creating and Using Strong-Named Assemblies](assetId:///ffbf6d9e-4a88-4a8a-9645-4ce0ee1ee5f9) and [Delay Signing an Assembly](assetId:///9d300e17-5bf1-4360-97da-2aa55efd9070).  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the **Properties** page for the project.  
  
2.  Modify the **Delay sign only** property.  
  
 For information on how to set this compiler option programmatically, see \<xref:VSLangProj80.ProjectProperties3.DelaySign*>.  
  
## See Also  
 [C# Compiler Options](../vs140/csharp-compiler-options.md)   
 [NIB How to: Modify Project Properties and Configuration Settings](assetId:///e7184bc5-2f2b-4b4f-aa9a-3ecfcbc48b67)