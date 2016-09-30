---
title: "Compiler Warning (level 4) C4764"
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
  - "C4764"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4764"
ms.assetid: 7bd4296f-966b-484c-bf73-8dbc8e85b4a9
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4764
Cannot align catch objects to greater than 16 bytes  
  
 An alignment greater than 16 was specified, but on some platforms, if the function throws an exception, the stack will force an alignment of not greater than 16.  
  
## Example  
 The following sample generates C4764:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>