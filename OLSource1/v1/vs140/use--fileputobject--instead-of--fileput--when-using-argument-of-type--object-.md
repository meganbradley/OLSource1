---
title: "Use &#39;FilePutObject&#39; instead of &#39;FilePut&#39; when using argument of type &#39;Object&#39;"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vbrUseFilePutObject
ms.assetid: d207b9b7-5898-4c13-8b03-9feefac5f726
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Use &#39;FilePutObject&#39; instead of &#39;FilePut&#39; when using argument of type &#39;Object&#39;
The `FilePut` method includes an argument of type`Object`. `FilePutObject` should be used in place of `FilePut` to avoid ambiguities.  
  
### To correct this error  
  
-   Replace `FilePut` with `FilePutObject`.  
  
-   Cast the `Object` argument to a more specific type.  
  
-   Use the functionality available in the `My.Computer.FileSystem` object.  
  
## See Also  
 [NOT IN BUILD: FilePutObject Function](assetId:///a0f52a1c-5ecc-4945-b18c-03147af61d6b)   
 [My.Computer.FileSystem Object](../vs140/my.computer.filesystem-object.md)   
 [My.Computer.FileSystem.WriteAllBytes Method](assetId:///b1a24dc1-eac8-4e22-8ffa-cc3bacbaf826)