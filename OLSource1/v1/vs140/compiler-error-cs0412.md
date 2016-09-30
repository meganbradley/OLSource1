---
title: "Compiler Error CS0412"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS0412"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0412"
ms.assetid: eeb2afbc-9416-4bcf-b116-d6adc5cfd4ca
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0412
'generic': a parameter or local variable cannot have the same name as a method type parameter  
  
 There is a name conflict between the type parameter of a generic method and a local variable in the method or one of the method's parameters. To avoid this error, rename any conflicting parameters or local variables.  
  
## Example  
 The following sample generates CS0412:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>