---
title: "__typeof"
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
  - "__typeof_cpp"
  - "__typeof"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__typeof keyword"
ms.assetid: d71b9603-35d0-4c62-b5b4-90ffc2305a55
caps.latest.revision: 12
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# __typeof
**Note** This topic applies only to version 1 of Managed Extensions for C++. This syntax should only be used to maintain version 1 code. See [typeid<>](../vs140/typeid---c---component-extensions-.md) for information on using the equivalent functionality in the new syntax.  
  
 Returns the **System::Type** of a specified type.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 where:  
  
 *typename*  
 The name of a managed type for which you want the **System::Type** name. Note that in a managed program, some native types are aliased to types in the common language runtime. For example, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is an alias for **System::Int32**.  
  
## Remarks  
 The **__typeof** operator lets you get the **System::Type** type of a type that you specify. **__typeof** can also be used to return a value of **System::Type** in a custom attribute block. See [attribute](../vs140/attribute.md) for more information about creating your own attributes.  
  
## Example  
 In the following example, a custom attribute (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) is applied to a __gc class (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>). The value of the custom attribute is then retrieved with **\__typeof**:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>