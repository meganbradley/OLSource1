---
title: "Accessibility Levels (C# Reference)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 19
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Accessibility Levels (C# Reference)
Use the access modifiers, [public](../VS_csharp/public--csharp-reference-.md), [protected](../VS_csharp/protected--csharp-reference-.md), [internal](../VS_csharp/internal--csharp-reference-.md), or [private](../VS_csharp/private--csharp-reference-.md), to specify one of the following declared accessibility levels for members.  
  
|Declared accessibility|Meaning|  
|----------------------------|-------------|  
|`public`|Access is not restricted.|  
|`protected`|Access is limited to the containing class or types derived from the containing class.|  
|`internal`|Access is limited to the current assembly.|  
|`protected` `internal`|Access is limited to the current assembly or types derived from the containing class.|  
|`private`|Access is limited to the containing type.|  
  
 Only one access modifier is allowed for a member or type, except when you use the `protected` `internal` combination.  
  
 Access modifiers are not allowed on namespaces. Namespaces have no access restrictions.  
  
 Depending on the context in which a member declaration occurs, only certain declared accessibilities are permitted. If no access modifier is specified in a member declaration, a default accessibility is used.  
  
 Top-level types, which are not nested in other types, can only have `internal` or `public` accessibility. The default accessibility for these types is `internal`.  
  
 Nested types, which are members of other types, can have declared accessibilities as indicated in the following table.  
  
|Members of|Default member accessibility|Allowed declared accessibility of the member|  
|----------------|----------------------------------|--------------------------------------------------|  
|`enum`|`public`|None|  
|`class`|`private`|`public`<br /><br /> `protected`<br /><br /> `internal`<br /><br /> `private`<br /><br /> `protected` `internal`|  
|`interface`|`public`|None|  
|`struct`|`private`|`public`<br /><br /> `internal`<br /><br /> `private`|  
  
 The accessibility of a nested type depends on its [accessibility domain](../VS_csharp/accessibility-domain--csharp-reference-.md), which is determined by both the declared accessibility of the member and the accessibility domain of the immediately containing type. However, the accessibility domain of a nested type cannot exceed that of the containing type.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [Access Modifiers](../VS_csharp/access-modifiers--csharp-reference-.md)   
 [Accessibility Domain](../VS_csharp/accessibility-domain--csharp-reference-.md)   
 [Restrictions on Using Accessibility Levels](../VS_csharp/restrictions-on-using-accessibility-levels--csharp-reference-.md)   
 [Access Modifiers](../VS_csharp/access-modifiers--csharp-programming-guide-.md)   
 [public](../VS_csharp/public--csharp-reference-.md)   
 [private](../VS_csharp/private--csharp-reference-.md)   
 [protected](../VS_csharp/protected--csharp-reference-.md)   
 [internal](../VS_csharp/internal--csharp-reference-.md)