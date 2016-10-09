---
title: "Compiler Error CS1548"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS1548"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1548"
ms.assetid: 63a467fa-d85f-4876-a8c9-2ae5fdebebab
caps.latest.revision: 13
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
# Compiler Error CS1548
Cryptographic failure while signing assembly 'assembly' — 'reason'  
  
 CS1548 occurs when assembly signing fails. This is usually due to an invalid key file name, an invalid key file path, or a corrupt key file.  
  
 To fully sign an assembly, you must provide a valid key file that contains information about the public and private keys. To delay sign an assembly, you must select the **Delay sign only** check box and provide a valid key file that contains information about the public key information. The private key is not necessary when an assembly is delay-signed.  
  
 For more information, see [How to: Sign an Assembly (Visual Studio)](assetId:///f468a7d3-234c-4353-924d-8e0ae5896564), [/keyfile (C# Compiler Options)](../VS_csharp/-keyfile--csharp-compiler-options-.md) and [/delaysign (C# Compiler Options)](../VS_csharp/-delaysign--csharp-compiler-options-.md).  
  
 When creating an assembly, the C# compiler calls into a utility called al.exe. If there is a failure in the assembly creation, the reason for the failure is reported by al.exe. See [Al.exe Tool Errors and Warnings](assetId:///7f125d49-0a03-47a6-9ba9-d61a679a7d4b) and search that topic for the text reported by the compiler in 'reason'.  
  
## See Also  
 [How to: Sign an Assembly (Visual Studio)](assetId:///f468a7d3-234c-4353-924d-8e0ae5896564)