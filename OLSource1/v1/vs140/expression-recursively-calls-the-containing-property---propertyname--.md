---
title: "Expression recursively calls the containing property &#39;&lt;propertyname&gt;&#39;"
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
  - "vbc42026"
  - "BC42026"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC42026"
ms.assetid: 4fde9db6-3bf3-48dc-8e05-981bf08969da
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Expression recursively calls the containing property &#39;&lt;propertyname&gt;&#39;
A statement in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> procedure of a property definition stores a value into the name of the property.  
  
 The recommended approach to holding the value of a property is to define a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> variable in the property's container and use it in both the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> procedures. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> procedure should then store the incoming value in this <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> variable.  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> procedure behaves like a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> procedure, so it can assign a value to the property name and return control by encountering the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statement. The recommended approach, however, is to include the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> variable as the value in a [Return Statement (Visual Basic)](../vs140/return-statement--visual-basic-.md).  
  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> procedure behaves like a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> procedure, which does not return a value. Therefore, the procedure or property name has no special meaning within a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> procedure, and you cannot store a value into it.  
  
 The following example illustrates the approach that can cause this error, followed by the recommended approach.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 By default, this message is a warning. For more information about hiding warnings or treating warnings as errors, please see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC42026  
  
### To correct this error  
  
-   Rewrite the property definition to use the recommended approach as illustrated in the preceding example.  
  
## See Also  
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)   
 [Property Statement](../vs140/property-statement.md)   
 [Set Statement (Visual Basic)](../vs140/set-statement--visual-basic-.md)