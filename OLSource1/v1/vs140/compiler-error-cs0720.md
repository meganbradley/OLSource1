---
title: "Compiler Error CS0720"
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
  - "CS0720"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0720"
ms.assetid: 1a8e7613-6bfb-4178-a8b4-f4591316c0b8
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0720
'static class': cannot declare indexers in a static class  
  
 Indexers are not meaningful in static classes, since they can only be used with instances, and it is not possible to create instances of a static type.  
  
## Example  
 The following sample generates CS0720:  
  
```  
// CS0720.cs  
  
public static class Test  
{  
    public int this[int index]  // CS0720  
    {  
        get { return 1; }  
        set {}  
    }  
  
    static void Main() {}  
}  
```