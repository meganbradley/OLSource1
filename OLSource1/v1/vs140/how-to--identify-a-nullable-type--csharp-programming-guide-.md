---
title: "How to: Identify a Nullable Type (C# Programming Guide)"
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
  - "nullable types [C#], identifying"
ms.assetid: d4b67ee2-66e8-40c1-ae9d-545d32c71387
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Identify a Nullable Type (C# Programming Guide)
You can use the C# [typeof](../vs140/typeof--csharp-reference-.md) operator to create a \<xref:System.Type*> object that represents a Nullable type:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 You can also use the classes and methods of the \<xref:System.Reflection*> namespace to generate \<xref:System.Type*> objects that represent Nullable types. However, if you try to obtain type information from Nullable variables at runtime by using the \<xref:System.Object.GetType*> method or the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operator, the result is a \<xref:System.Type*> object that represents the underlying type, not the Nullable type itself.  
  
 Calling <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> on a Nullable type causes a boxing operation to be performed when the type is implicitly converted to \<xref:System.Object*>. Therefore \<xref:System.Object.GetType*> always returns a \<xref:System.Type*> object that represents the underlying type, not the Nullable type.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The C# [is](../vs140/is--csharp-reference-.md) operator also operates on a Nullable's underlying type. Therefore you cannot use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to determine whether a variable is a Nullable type. The following example shows that the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> operator treats a Nullable\<int> variable as an int.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 Use the following code to determine whether a \<xref:System.Type*> object represents a Nullable type. Remember that this code always returns false if the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object was returned from a call to \<xref:System.Object.GetType*>, as explained earlier in this topic.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Nullable Types (C# Programming Guide)](../vs140/nullable-types--csharp-programming-guide-.md)   
 [Boxing Nullable Types (C# Programming Guide)](../vs140/boxing-nullable-types--csharp-programming-guide-.md)