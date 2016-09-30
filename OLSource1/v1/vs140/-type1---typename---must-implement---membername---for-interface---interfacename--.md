---
title: "&lt;type1&gt;&#39;&lt;typename&gt;&#39; must implement &#39;&lt;membername&gt;&#39; for interface &#39;&lt;interfacename&gt;&#39;"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc30154"
  - "bc30154"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30154"
ms.assetid: 259afdfa-3608-4760-adcb-88ec0da5020d
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;type1&gt;&#39;&lt;typename&gt;&#39; must implement &#39;&lt;membername&gt;&#39; for interface &#39;&lt;interfacename&gt;&#39;
'\<typename>' must implement '\<membername>' for interface '\<interfacename>'. Implementing property must have matching 'ReadOnly'/'WriteOnly' specifiers.  
  
 A class or structure claims to implement an interface but does not implement a procedure, property, or event defined by the interface. Every member of the interface must be implemented.  
  
 **Error ID:** BC30154  
  
### To correct this error  
  
1.  Declare a member with the same name and signature as defined in the interface. Be sure to include at least the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement.  
  
2.  Add an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> clause to the end of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statement. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
3.  When implementing a property, make sure that <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is used in the same way as in the interface definition.  
  
4.  When implementing a property, declare <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> procedures, as appropriate.  
  
## See Also  
 [Implements Statement](../vs140/implements-statement.md)   
 [Interfaces (Visual Basic)](../vs140/interfaces--visual-basic-.md)