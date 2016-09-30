---
title: "__property"
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
  - "__property_cpp"
  - "__property"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__property keyword"
  - "managed classes"
  - "properties [C++], managed classes"
ms.assetid: 235e3574-6882-4c52-8301-270277b9216d
caps.latest.revision: 13
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# __property
> [!NOTE]
>  This topic applies only to version 1 of Managed Extensions for C++. This syntax should only be used to maintain version 1 code. See [property (Managed Extensions for C++ Programming)](../vs140/property---c---component-extensions-.md) for information on using the equivalent functionality in the new syntax.  
  
 Declares either a scalar or indexed property for the managed class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword introduces the declaration of a property and can appear in a class, interface, or value type. A property can have a getter function (read only), a setter function (write only), or both (read-write).  
  
> [!NOTE]
>  A property name cannot match the name of the managed class containing it. The return type of the getter function must match the type of the last parameter of a corresponding setter function.  
  
## Example  
 In the following example, a scalar property (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) is added to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> declaration. The property is then implicitly set and retrieved using the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> functions:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>