---
title: "Storage of Unions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "storage, union"
  - "union keyword [C], storage"
  - "union keyword [C]"
ms.assetid: b33d246a-8d20-41c4-89b2-ab05f1428792
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Storage of Unions
The storage associated with a union variable is the storage required for the largest member of the union. When a smaller member is stored, the union variable can contain unused memory space. All members are stored in the same memory space and start at the same address. The stored value is overwritten each time a value is assigned to a different member. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The members of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> union are, in order of their declaration, a pointer to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> value, a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> value, and an array of **float** values. The storage allocated for <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is the storage required for the 20-element array <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, since <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is the longest member of the union. Because no tag is associated with the union, its type is unnamed or "anonymous."  
  
## See Also  
 [Union Declarations](../vs140/union-declarations.md)