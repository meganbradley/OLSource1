---
title: "__nogc"
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
  - "__nogc_cpp"
  - "__nogc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__nogc type declarations"
  - "classes [C++], unmanaged type"
  - "unmanaged classes, declaration of"
  - "unmanaged classes"
ms.assetid: 3e7f1b09-0fc3-4a8f-9458-a22f7a38ce45
caps.latest.revision: 15
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# __nogc
> [!NOTE]
>  This topic applies only to version 1 of Managed Extensions for C++. This syntax should only be used to maintain version 1 code. In the new syntax, you do not need to explicitly mark a type as unmanaged.  
  
 Explicitly declares an unmanaged type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword is used to explicitly specify that an object is allocated on the standard C++ heap. This keyword is optional. If you don't specify <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in front of a class declaration, it defaults to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 Objects of this type are similar to standard C++ objects in that they are allocated from the standard C++ heap and are not subject to the restrictions of a managed object.  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> keyword is also used when an object of a __value type is explicitly allocated on the standard C++ heap:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
> [!NOTE]
>  The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> keyword can also be applied to array and pointer types.  
  
 A gc pointer cannot be a member of a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class. See [__value](../vs140/__value.md) for guidelines on embedding a value type in a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class.  
  
## Example  
 In the following example, an unmanaged class is declared (<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>) and an object is instantiated and modified:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **48378256**  
**4**