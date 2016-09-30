---
title: "Accessibility Levels (C# Reference)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "access modifiers [C#], accessibility levels"
  - "accessibility levels"
ms.assetid: dc083921-0073-413e-8936-a613e8bb7df4
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Accessibility Levels (C# Reference)
Use the access modifiers, [public](../vs140/public--csharp-reference-.md), [protected](../vs140/protected--csharp-reference-.md), [internal](../vs140/internal--csharp-reference-.md), or [private](../vs140/private--csharp-reference-.md), to specify one of the following declared accessibility levels for members.  
  
|Declared accessibility|Meaning|  
|----------------------------|-------------|  
|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>|Access is not restricted.|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Access is limited to the containing class or types derived from the containing class.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Access is limited to the current assembly.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Access is limited to the current assembly or types derived from the containing class.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Access is limited to the containing type.|  
  
 Only one access modifier is allowed for a member or type, except when you use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> combination.  
  
 Access modifiers are not allowed on namespaces. Namespaces have no access restrictions.  
  
 Depending on the context in which a member declaration occurs, only certain declared accessibilities are permitted. If no access modifier is specified in a member declaration, a default accessibility is used.  
  
 Top-level types, which are not nested in other types, can only have <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> accessibility. The default accessibility for these types is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 Nested types, which are members of other types, can have declared accessibilities as indicated in the following table.  
  
|Members of|Default member accessibility|Allowed declared accessibility of the member|  
|----------------|----------------------------------|--------------------------------------------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|None|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|None|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|  
  
 The accessibility of a nested type depends on its [accessibility domain](../vs140/accessibility-domain--csharp-reference-.md), which is determined by both the declared accessibility of the member and the accessibility domain of the immediately containing type. However, the accessibility domain of a nested type cannot exceed that of the containing type.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Access Modifiers](../vs140/access-modifiers--csharp-reference-.md)   
 [Accessibility Domain](../vs140/accessibility-domain--csharp-reference-.md)   
 [Restrictions on Using Accessibility Levels](../vs140/restrictions-on-using-accessibility-levels--csharp-reference-.md)   
 [Access Modifiers (Visual C#)](../vs140/access-modifiers--csharp-programming-guide-.md)   
 [public (C# Programmer's Reference)](../vs140/public--csharp-reference-.md)   
 [private (C# Programmer's Reference)](../vs140/private--csharp-reference-.md)   
 [protected (C# Programmer's Reference)](../vs140/protected--csharp-reference-.md)   
 [internal (C# Programmer's Reference)](../vs140/internal--csharp-reference-.md)