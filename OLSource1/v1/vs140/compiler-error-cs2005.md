---
title: "Compiler Error CS2005"
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
  - "CS2005"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS2005"
ms.assetid: 03535d2a-ae30-4272-ab45-e277df5ee8e1
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS2005
Missing file specification for 'option' option  
  
 A [compiler option](../vs140/csharp-compiler-options.md) was only partially specified.  
  
 For example, when using [/recurse](../vs140/-recurse--csharp-compiler-options-.md), you must specify the file to search: **/recurse:***filename***.cs**.  
  
## Example  
 The following sample generates CS2005.  
  
```  
// CS2005.cs  
// compile with: /recurse:  
// CS2005 expected  
class x  
{  
   public static void Main() {}  
}  
```