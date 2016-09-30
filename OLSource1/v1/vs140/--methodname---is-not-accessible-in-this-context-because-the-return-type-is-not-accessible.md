---
title: "&#39;&lt;methodname&gt;&#39; is not accessible in this context because the return type is not accessible"
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
  - "bc36665"
  - "vbc36666"
  - "bc36666"
  - "vbc36665"
helpviewer_keywords: 
  - "BC36666"
  - "BC36665"
ms.assetid: 8f29eb7e-351f-486c-9d1f-3556cc11b7c5
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;methodname&gt;&#39; is not accessible in this context because the return type is not accessible
You have called a function that has a return type that you cannot access from the calling statement. For example, in the following code, the call from <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> fails because the return type, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, is declared with the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> access modifier in class <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Therefore, the context within which <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> can be accessed is limited to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Error ID:** BC36665 and BC36666  
  
### To correct this error  
  
-   If the type definition is accessible, change the access modifier from <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
-   Change the return type of the function if you have access to it.  
  
-   Write a method or extension method that returns an accessible type.  
  
## See Also  
 [Access Levels in Visual Basic](../vs140/access-levels-in-visual-basic.md)