---
title: "__delegate"
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
  - "__delegate_cpp"
  - "__delegate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "delegates, _delegate keyword"
  - "function pointers, managed"
  - "__delegate keyword"
ms.assetid: a41d2211-b79b-4509-a4c2-cc91f3d4fc9d
caps.latest.revision: 12
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# __delegate
**Note** This topic applies only to version 1 of Managed Extensions for C++. This syntax should only be used to maintain version 1 code. See [delegate (Managed Extensions for C++ Programming)](../vs140/delegate---c---component-extensions-.md) for information on using the equivalent functionality in the new syntax.  
  
 Defines a reference type that can be used to encapsulate a method with a specific signature.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 A delegate is roughly equivalent to a C++ function pointer except for the following difference:  
  
-   A delegate can only be bound to one or more methods within a __gc class.  
  
 When the compiler encounters the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword, a definition of a __gc class is generated. This \__gc class has the following characteristics:  
  
-   It inherits from **System::MulticastDelegate**.  
  
-   It has a constructor that takes two arguments: a pointer to a __gc class or **NULL** (in the case of binding to a static method) and a fully qualified method of the specified type.  
  
-   It has a method called <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, whose signature matches the declared signature of the delegate.  
  
## Example  
 In the following example, a __gc class (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) and a delegate (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>) are declared. The delegate is then bound to the different methods of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, invoking each in turn:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>