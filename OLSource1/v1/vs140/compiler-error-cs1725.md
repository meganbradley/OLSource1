---
title: "Compiler Error CS1725"
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
  - "cs1725"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1725"
ms.assetid: baef9ae3-b036-41d6-972c-9f3cdae1e8bd
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1725
Friend assembly reference 'reference' is invalid. InternalsVisibleTo declarations cannot have a version, culture, public key token, or processor architecture specified.  
  
 You cannot add a version culture in a friend assembly reference. Partial classes should be visible to friend assemblies.  
  
## Example  
 The following sample generates CS1725.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [How to: Create Signed Friend Assemblies (C# and Visual Basic)](../vs140/how-to--create-signed-friend-assemblies--csharp-and-visual-basic-.md)