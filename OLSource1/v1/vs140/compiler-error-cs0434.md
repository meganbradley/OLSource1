---
title: "Compiler Error CS0434"
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
  - "CS0434"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0434"
ms.assetid: 8f8871fc-a4bb-4a9e-ba19-999f4943001e
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0434
The namespace NamespaceName1 in NamespaceName2 conflicts with the type TypeName1 in NamespaceName3  
  
 This error occurs when an imported type and an imported nested namespace have the same fully qualified name. When that name is referenced, the compiler is unable to distinguish between the two. If you can change the imported source code, you can resolve the error by changing the name of either the type or the namespace so that both are unique within the assembly.  
  
 The following code generates error CS0434.  
  
## Example  
 This code creates the first copy of the type with the identical fully qualified name.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 This code creates the second copy of the type with the identical fully qualified name.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 This code references the type with the identical fully qualified name.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>