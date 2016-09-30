---
title: "final Specifier"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "final"
  - "final_CPP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "final Identifier"
ms.assetid: 649866d0-79d4-449f-ab74-f84b911b79a3
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# final Specifier
You can use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword to designate virtual functions that cannot be overridden in a derived class. You can also use it to designate classes that cannot be inherited.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Remarks  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is context-sensitive and has special meaning only when it's used after a function declaration or class name; otherwise, it's not a reserved keyword.  
  
 When <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is used in class declarations, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is an optional part of the declaration.  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> keyword to specify that a virtual function cannot be overridden.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 For information about how to specify that member functions can be overridden, see [override Specifier](../vs140/override-specifier.md).  
  
 The next example uses the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> keyword to specify that a class cannot be inherited.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Keywords](../vs140/keywords--c---.md)   
 [(NOTINBUILD) C++ Type Names](assetId:///b53ba470-e583-4e5c-b634-6018f6110674)   
 [override Specifier](../vs140/override-specifier.md)