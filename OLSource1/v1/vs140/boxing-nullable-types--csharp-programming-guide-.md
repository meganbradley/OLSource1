---
title: "Boxing Nullable Types (C# Programming Guide)"
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
  - "boxing [C#], nullable types"
  - "unboxing [C#], nullable types"
  - "nullable types [C#], boxing and unboxing"
ms.assetid: bdb5b626-abc0-405d-8f64-0f0a0bf883a4
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Boxing Nullable Types (C# Programming Guide)
Objects based on nullable types are only boxed if the object is non-null. If <xref:System.Nullable<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>false<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>null<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>1.HasValue*> is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> -- then boxing occurs, but only the underlying type that the nullable object is based on is boxed. Boxing a non-null nullable value type boxes the value type itself, not the \<xref:System.Nullable`1*?displayProperty=fullName> that wraps the value type. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The two boxed objects are identical to those created by boxing non-nullable types. And, just like non-nullable boxed types, they can be unboxed into nullable types, as in the following example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Remarks  
 The behavior of nullable types when boxed provides two advantages:  
  
1.  Nullable objects and their boxed counterpart can be tested for null:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
2.  Boxed nullable types fully support the functionality of the underlying type:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Nullable Types (C# Programming Guide)](../vs140/nullable-types--csharp-programming-guide-.md)   
 [How To: Identify a Nullable Type (C# Programming Guide)](../vs140/how-to--identify-a-nullable-type--csharp-programming-guide-.md)