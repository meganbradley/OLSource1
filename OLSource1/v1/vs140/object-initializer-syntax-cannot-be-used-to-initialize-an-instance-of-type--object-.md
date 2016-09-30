---
title: "Object initializer syntax cannot be used to initialize an instance of type &#39;Object&#39;"
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
  - "bc30994"
  - "vbc30994"
helpviewer_keywords: 
  - "BC30994"
ms.assetid: 2ef65965-f014-4fc1-8c7d-c603f0a764df
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Object initializer syntax cannot be used to initialize an instance of type &#39;Object&#39;
You cannot initialize an instance of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> by using object initializer syntax. An instance of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> has no properties or fields to assign a value to, and object initializer syntax requires at least one such property or field.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Error ID:** BC30994  
  
### To correct this error  
  
1.  Declare instances of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> without using an initializer list:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Object Initializers](../vs140/object-initializers--named-and-anonymous-types--visual-basic-.md)   
 [Object Data Type](../vs140/object-data-type.md)