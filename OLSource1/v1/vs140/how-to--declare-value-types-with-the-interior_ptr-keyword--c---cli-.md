---
title: "How to: Declare Value Types with the interior_ptr Keyword (C++-CLI)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
H1: "How to: Declare Value Types with the interior_ptr Keyword (C++/CLI)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_ptr keyword"
  - "value types, declaring"
ms.assetid: 49eea66e-eeba-49bd-95b0-ba297be436e3
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Declare Value Types with the interior_ptr Keyword (C++-CLI)
An <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> can be used with a value type.  
  
> [!IMPORTANT]
>  This language feature is supported by the **/clr** compiler option, but not by the **/ZW** compiler option.  
  
## Example  
  
### Description  
 The following [!INCLUDE[cppcli](../vs140/includes/cppcli_md.md)] sample shows how to use an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> with a value type.  
  
### Code  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
  
### Description  
 In a value type, the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> pointer evaluates to an interior_ptr.  
  
 In the body of a non-static member-function of a value type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is an expression of type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> whose value is the address of the object for which the function is called.  
  
### Code  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
  
### Description  
 The following sample shows how to use the address-of operator with static members.  
  
 The address of a static Visual C++ type member yields a native pointer.  The address of a static value type member is a managed pointer because value type member is allocated on the runtime heap and can be moved by the garbage collector.  
  
### Code  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [interior_ptr (C++/CLI)](../vs140/interior_ptr--c---cli-.md)