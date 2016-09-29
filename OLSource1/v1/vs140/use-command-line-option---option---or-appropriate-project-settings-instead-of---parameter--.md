---
title: "Use command line option &#39;&lt;option&gt;&#39; or appropriate project settings instead of &#39;&lt;parameter&gt;&#39;"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc41008"
  - "vbc41008"
helpviewer_keywords: 
  - "BC41008"
ms.assetid: 1c5d6d7a-b767-4dae-aa61-d7fa81d5aad1
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Use command line option &#39;&lt;option&gt;&#39; or appropriate project settings instead of &#39;&lt;parameter&gt;&#39;
The preferred way to specify a file that contains a public key for an assembly, a public-key container for an assembly, or a partial-signed assembly is to use the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler options. We do not recommend use of the <xref:System.Reflection.AssemblyKeyFileAttribute*>, <xref:System.Reflection.AssemblyKeyNameAttribute*>, or <xref:System.Reflection.AssemblyDelaySignAttribute*> attributes in your code.  
  
 **Error ID:** BC41008  
  
### To correct this error  
  
1.  Use the [/keyfile](../vs140/-keyfile.md), [/keycontainer](../vs140/-keycontainer.md), or [/delaysign](../vs140/-delaysign.md)[!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] compiler options instead of the <xref:System.Reflection.AssemblyKeyFileAttribute*>, <xref:System.Reflection.AssemblyKeyNameAttribute*>, or <xref:System.Reflection.AssemblyDelaySignAttribute*> attributes in your code.  
  
## See Also  
 [How to: Create Signed Friend Assemblies](../vs140/how-to--create-signed-friend-assemblies--csharp-and-visual-basic-.md)   
 [Visual Basic Compiler](../vs140/visual-basic-command-line-compiler.md)   
 [/keyfile](../vs140/-keyfile.md)   
 [/keycontainer](../vs140/-keycontainer.md)   
 [/delaysign](../vs140/-delaysign.md)