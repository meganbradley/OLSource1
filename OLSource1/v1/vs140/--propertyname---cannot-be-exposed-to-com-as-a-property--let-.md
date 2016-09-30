---
title: "&#39;&lt;propertyname&gt;&#39; cannot be exposed to COM as a property &#39;Let&#39;"
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
  - "bc42102"
  - "vbc42102"
helpviewer_keywords: 
  - "BC42102"
ms.assetid: b77c5b7c-ac43-4b2d-b8bc-582e65e6f7e7
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;propertyname&gt;&#39; cannot be exposed to COM as a property &#39;Let&#39;
'\<propertyname>' cannot be exposed to COM as a property 'Let'. You will not be able to assign non-object values (such as numbers or strings) to this property from Visual Basic 6.0 using a 'Let' statement.  
  
 A class using a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> attribute block declares a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> property with data type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. A Visual Basic 6.0 program can access this property as a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, but can assign only an object reference to it with the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement. It cannot assign a value type with the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement.  
  
 By default, this message is a warning. For more information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC42102  
  
### To address this warning  
  
-   Consider informing potential Visual Basic 6.0 users of this class that they cannot use this property with the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement.  
  
## See Also  
 [Default Property Changes in Visual Basic](assetId:///9b8cfad7-40ac-4b83-affb-1ff781755a4c)   
 [Property Statement](../vs140/property-statement.md)   
 [Public](../vs140/public--visual-basic-.md)   
 [Object Data Type](../vs140/object-data-type.md)   
 [NOT IN BUILD: Attributes Used in Visual Basic](assetId:///22231318-8a40-49af-9245-e0aab723563b)   
 [NOT IN BUILD: Application of Attributes](assetId:///2b1703ed-4437-49b3-bc0b-568094324f47)   
 [ComClassAttribute Class](assetId:///5c2f0835-9210-47dc-bc59-5c1769953574)