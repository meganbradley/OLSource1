---
title: "Module &lt;keyword&gt; (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.ModuleAttribute"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Module keyword"
  - "Module modifier"
  - "attribute blocks, Module keyword"
ms.assetid: d971b940-05ab-4d56-8485-e3b8a661906b
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
# Module &lt;keyword&gt; (Visual Basic)
Specifies that an attribute at the beginning of a source file applies to the current assembly module.  
  
## Remarks  
 Many attributes pertain to an individual programming element, such as a class or property. You apply such an attribute by attaching the attribute block, within angle brackets (`< >`), directly to the declaration statement.  
  
 If an attribute pertains not only to the following element but to the current assembly module, you place the attribute block at the beginning of the source file and identify the attribute with the `Module` keyword. If it applies to the entire assembly, you use the [Assembly](../VS_visualbasic/assembly--visual-basic-.md) keyword.  
  
 The `Module` modifier is not the same as the [Module Statement](../VS_visualbasic/module-statement.md).  
  
## See Also  
 [Assembly](../VS_visualbasic/assembly--visual-basic-.md)   
 [Module Statement](../VS_visualbasic/module-statement.md)   
 [Attributes](../Topic/Attributes%20\(C%23%20and%20Visual%20Basic\).md)