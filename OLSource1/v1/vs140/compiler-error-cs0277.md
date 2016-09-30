---
title: "Compiler Error CS0277"
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
  - "CS0277"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0277"
ms.assetid: 8abec3eb-4d4c-4aab-87cc-d0444ab23535
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0277
'class' does not implement interface member 'accessor'. 'class accessor' is not public  
  
 This error occurs when you try to implement a property of an interface, but the implementation of the property accessor in the class is not public. Methods that implement interface members need to have public accessibility. To resolve, remove the access modifier on the property accessor.  
  
## Example  
 The following example generates CS0277:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>