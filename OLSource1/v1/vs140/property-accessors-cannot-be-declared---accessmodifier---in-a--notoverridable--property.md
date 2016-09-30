---
title: "Property accessors cannot be declared &#39;&lt;accessmodifier&gt;&#39; in a &#39;NotOverridable&#39; property"
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
  - "vbc31106"
  - "bc31106"
helpviewer_keywords: 
  - "BC31106"
ms.assetid: 84bcb157-9c33-4e4f-89a9-c5e6cb73028b
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Property accessors cannot be declared &#39;&lt;accessmodifier&gt;&#39; in a &#39;NotOverridable&#39; property
A [Get Statement](../vs140/get-statement.md) or [Set Statement (Visual Basic)](../vs140/set-statement--visual-basic-.md) in a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> property includes the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword.  
  
 The following line of reasoning explains why <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> cannot be combined in a [Property Statement](../vs140/property-statement.md):  
  
1.  A property or procedure that does not override a base class property or procedure has a default setting of [NotOverridable](../vs140/notoverridable--visual-basic-.md).  
  
2.  However, a property or procedure in a derived class that overrides a base class property or procedure has a default setting of [Overridable](../vs140/overridable--visual-basic-.md). To terminate the hierarchy of overriding, you can declare it <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. This is the only context in which you can use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. That is, you can use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> only in combination with [Overrides](../vs140/overrides--visual-basic-.md).  
  
3.  If a base class property or procedure is declared [Private (Visual Basic)](../vs140/private--visual-basic-.md), a derived class cannot override that property or procedure because it cannot access it. Because of this, you cannot use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in combination with <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
4.  To override a property or procedure, the overriding property or procedure must have not only the identical signature but also the same access level. This means that an overriding property or procedure cannot specify <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, because an overridable property or procedure cannot specify <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
5.  Because you can specify <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> only on an overriding property or procedure, you cannot combine it with <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 By the same reasoning, the individual property procedures (<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>) of an overriding property cannot be <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 **Error ID:** BC31106  
  
### To correct this error  
  
-   Remove the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> keyword from the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> statement, or remove the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> keywords from the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> statement.  
  
## See Also  
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)   
 [Differences Between Shadowing and Overriding](../vs140/differences-between-shadowing-and-overriding--visual-basic-.md)   
 [How to: Declare a Property with Mixed Access Levels](../vs140/how-to--declare-a-property-with-mixed-access-levels--visual-basic-.md)