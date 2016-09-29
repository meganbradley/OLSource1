---
title: "Use &#39;FileGetObject&#39; instead of &#39;FileGet&#39; when using argument of type &#39;Object&#39;"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 090b8088-895a-482a-9362-606596bac304
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Use &#39;FileGetObject&#39; instead of &#39;FileGet&#39; when using argument of type &#39;Object&#39;
The `FileGet` method includes an argument of type `Object`. `FileGetObject` should be used in place of `FileGet` to avoid ambiguities.  
  
 Notice that the functionality offered by `My.Computer.Filesystem` offers greater ease of use and performance than either `FileGet` or `FileGetObject`.  
  
### To correct this error  
  
1.  Replace `FileGet` with `FileGetObject`.  
  
2.  Cast the `Object` argument to a more specific type.  
  
## See Also  
 [NOT IN BUILD: FileGetObject Function](assetId:///3eda786b-d1ee-4b44-9dd7-0ea6bff072c0)   
 [My.Computer.FileSystem Object](../vs140/my.computer.filesystem-object.md)