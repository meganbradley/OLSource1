---
title: "__try_cast"
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
  - "__try_cast"
  - "__try_cast_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__try_cast keyword"
  - "casting failures"
  - "exceptions, unsuccessful casts"
  - "throwing exceptions, unsuccessful casts"
ms.assetid: e9e5da3a-f5b9-4915-b30a-a432e8574d03
caps.latest.revision: 14
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# __try_cast
**Note** This topic applies only to version 1 of Managed Extensions for C++. This syntax should only be used to maintain version 1 code. See [safe_cast](../vs140/safe_cast--c---component-extensions-.md) for information on using the equivalent functionality in the new syntax.  
  
 Performs the specified cast or throws an exception if the cast fails.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword (similar in behavior to [dynamic_cast](../vs140/dynamic_cast-operator.md)) provides support for automatically throwing an exception (of type **System::InvalidCastException**) whenever the specified casting operation fails.  
  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword can be used during the testing phase of your application, automatically alerting you to possible casting failures.  
  
 When porting Managed Extensions for C++, replace <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> calls with [safe_cast](../vs140/safe_cast--c---component-extensions-.md).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> does not work on casts of pointer to value types ([__value](../vs140/__value.md)), since it is not possible to check the types at runtime.  
  
## Example  
 In the following example, an attempt to cast a pointer (of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> type) to another pointer (of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> type) is made. If the cast fails, it is caught and reported by the catch block:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>