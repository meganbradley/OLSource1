---
title: "Compiler Warning (level 3) C4373"
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
  - "C4373"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4373"
ms.assetid: 670c0ba3-b7d6-4aed-b207-1cb84da3bcde
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) C4373
'%$S': virtual function overrides '%$pS', previous versions of the compiler did not override when parameters only differed by const/volatile qualifiers  
  
 Your application contains a method in a derived class that overrides a virtual method in a base class, and the parameters in the overriding method differ by only a [const](../vs140/const--c---.md) or [volatile](../vs140/volatile--c---.md) qualifier from the parameters of the virtual method. This means the compiler must bind a function reference to the method in either the base or derived class.  
  
 Versions of the compiler prior to [!INCLUDE[cpp_orcas_long](../vs140/includes/cpp_orcas_long_md.md)] bind the function to the method in the base class, then issue a warning message. Subsequent versions of the compiler ignore the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> qualifier, bind the function to the method in the derived class, then issue warning <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. This latter behavior complies with the C++ standard.  
  
## Example  
 The following code example generates warning C4373.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **derived**