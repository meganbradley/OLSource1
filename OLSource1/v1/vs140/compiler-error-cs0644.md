---
title: "Compiler Error CS0644"
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
  - "CS0644"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0644"
ms.assetid: 835f3ee2-f897-4ba2-ad13-af629a9ab7fe
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0644
'class1' cannot derive from special class 'class2'  
  
 Classes cannot explicitly inherit from any of the following base classes:  
  
-   **System.Enum**  
  
-   **System.ValueType**  
  
-   **System.Delegate**  
  
-   **System.Array**  
  
 These are used as implicit base classes by the compiler. For example, **System.ValueType** is the implicit base class of structs.  
  
 The following sample generates CS0644:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>