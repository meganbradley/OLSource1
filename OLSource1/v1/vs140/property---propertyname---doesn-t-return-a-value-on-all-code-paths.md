---
title: "Property &#39;&lt;propertyname&gt;&#39; doesn&#39;t return a value on all code paths"
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
  - "bc42107"
  - "vbc42107"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC42107"
ms.assetid: 06800966-9c3b-4844-9f13-83ac95607d32
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Property &#39;&lt;propertyname&gt;&#39; doesn&#39;t return a value on all code paths
Property '\<propertyname>' doesn't return a value on all code paths. A null reference exception could occur at run time when the result is used.  
  
 A property <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> procedure has at least one possible path through its code that does not return a value.  
  
 You can return a value from a property <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> procedure in any of the following ways:  
  
-   Assign the value to the property name and then perform an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement.  
  
-   Assign the value to the property name and then perform the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement.  
  
-   Include the value in a [Return Statement (Visual Basic)](../vs140/return-statement--visual-basic-.md).  
  
 If control passes to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and you have not assigned any value to the property name, the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> procedure returns the default value of the property's data type. For more information, see "Behavior" in [Function Statement (Visual Basic)](../vs140/function-statement--visual-basic-.md).  
  
 By default, this message is a warning. For more information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC42107  
  
### To correct this error  
  
-   Check your control flow logic and make sure you assign a value before every statement that causes a return.  
  
     It is easier to guarantee that every return from the procedure returns a value if you always use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement. If you do this, the last statement before <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> should be a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statement.  
  
## See Also  
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)   
 [Property Statement](../vs140/property-statement.md)   
 [Get Statement](../vs140/get-statement.md)