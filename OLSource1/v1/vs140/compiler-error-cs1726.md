---
title: "Compiler Error CS1726"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS1726"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1726"
ms.assetid: 02b71f22-72f5-42b5-bc9e-1d5dc480cce0
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1726
Friend assembly reference 'reference' is invalid. Strong-name signed assemblies must specify a public key in their InternalsVisibleTo declarations.  
  
 A strong name signed assembly can only grant friend assembly access, made with the \<xref:System.Runtime.CompilerServices.InternalsVisibleToAttribute*>, to other strongly signed assemblies.  
  
 To resolve CS1726, either sign (give a strong name to) the assembly to which you want to grant friend access, or don't grant friend access.  
  
 For more information, see [Friend Assemblies (C# Programming Guide)](../vs140/friend-assemblies--csharp-and-visual-basic-.md).  
  
## Example  
 The following sample generates CS1726.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [How to: Create Signed Friend Assemblies (C# and Visual Basic)](../vs140/how-to--create-signed-friend-assemblies--csharp-and-visual-basic-.md)