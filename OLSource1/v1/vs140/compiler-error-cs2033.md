---
title: "Compiler Error CS2033"
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
  - "CS2033"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS2033"
ms.assetid: edb5784a-5195-4f72-b73d-d1ec9ed3766e
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS2033
Cannot create short filename 'filename' when a long filename with the same short filename already exists  
  
 Compile any C# file with a name longer than eight characters. Then compile another file with the short version of the preceding file name, such as the first six characters of the name plus "~1." The second compile will generate this error.  
  
 To resolve this error, rename the short file name to one that does not conflict with the long file name.