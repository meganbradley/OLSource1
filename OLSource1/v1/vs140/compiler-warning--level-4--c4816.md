---
title: "Compiler Warning (level 4) C4816"
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
  - "C4816"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4816"
ms.assetid: 60f730ae-d942-4db9-ab97-41d4a874d8da
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4816
'param' : parameter has a zero-sized array which will be truncated (unless the object is passed by reference)  
  
 A parameter to an object with a zero-size array was not passed by reference. The array will not get copied when the object is passed.  
  
## Example  
 The following sample generates C4816:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>