---
title: "Sealing a Virtual Function"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sealed keyword [C++]"
  - "derived classes, virtual functions"
  - "virtual functions, sealing"
  - "__sealed keyword"
ms.assetid: 0e9fae03-6425-4512-9a24-8ccb6dc8a0d4
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Sealing a Virtual Function
The syntax for sealing a virtual function has changed from Managed Extensions for C++ to [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)].  
  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword is used in Managed Extensions to modify either a reference type, disallowing subsequent derivation from it (see [Declaration of a Managed Class Type](../vs140/declaration-of-a-managed-class-type.md)), or to modify a virtual function, disallowing subsequent overriding of the method in a derived class. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In this example, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> overrides the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> instance based on the exact match of the function prototype. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> keyword indicates that a subsequent class inherited from the derived class cannot provide an override of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 In the new syntax, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is placed after the signature rather than being allowed to appear anywhere before the actual function prototype, as was previously allowed. In addition, the use of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> requires an explicit use of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> keyword as well. That is, the correct translation of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, above, is as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The absence of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> keyword in this instance results in an error. In the new syntax, the contextual keyword <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> can be used in place of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to indicate a pure virtual function. This was not supported within Managed Extensions. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 can be rewritten as  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Member Declarations within a Class or Interface](../vs140/member-declarations-within-a-class-or-interface--c---cli-.md)   
 [sealed](../vs140/sealed---c---component-extensions-.md)