---
title: "__box"
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
  - "__box"
  - "__box_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__box keyword"
  - "boxing"
  - "unboxing"
  - "boxing, __box keyword"
ms.assetid: 935b4a4d-fc45-484c-87c6-d95cfc67cc9d
caps.latest.revision: 14
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# __box
> [!NOTE]
>  This topic applies only to version 1 of Managed Extensions for C++. This syntax should only be used to maintain version 1 code. See [Implicit Boxing](../vs140/boxing---c---component-extensions-.md) for information on using the equivalent functionality in the new syntax.  
  
 Creates a managed copy of a __value class object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword is used to create a managed object (derived from **System::ValueType**) from an existing __value class object. When the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword is applied to a \__value class:  
  
-   A managed object is allocated on the common language runtime heap.  
  
-   The current value of the __value class object is bit-wise copied into the managed object.  
  
-   The address of the new managed object is returned.  
  
 This process is known as boxing. This enables any __value class object to be used in generic routines that work for any managed object because the managed object indirectly inherits from **System::Object** (since **System::ValueType** inherits from **System::Object**).  
  
> [!NOTE]
>  The newly created boxed object is a copy of the __value class object. Therefore, modifications to the value of the boxed object do not affect the contents of the \__value class object.  
  
## Example  
 Here's is an example that does boxing and unboxing:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In the following example, an unmanaged value type (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) is boxed and passed as a managed parameter to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **10**  
**20**