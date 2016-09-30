---
title: "Method &#39;&lt;methodname1&gt;&#39; must be declared &#39;Private&#39; in order to implement partial method &#39;&lt;methodname2&gt;&#39;"
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
  - "vbc31441"
  - "bc31441"
helpviewer_keywords: 
  - "BC31441"
ms.assetid: 4d8d19ad-0c3b-4eba-ada8-2cfa6ae795c4
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Method &#39;&lt;methodname1&gt;&#39; must be declared &#39;Private&#39; in order to implement partial method &#39;&lt;methodname2&gt;&#39;
The implementation of a partial method must be declared <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. For example, the following code causes this error.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Error ID:** BC31441  
  
### To correct this error  
  
1.  Use the access modifier <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in the implementation of the partial method, as shown in the following example.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Partial Methods](../vs140/partial-methods--visual-basic-.md)   
 [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md)