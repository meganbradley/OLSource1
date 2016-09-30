---
title: "__interface"
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
  - "__interface"
  - "__interface_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__interface keyword [C++]"
ms.assetid: ca5d400b-d6d8-4ba2-89af-73f67e5ec056
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __interface
**Microsoft Specific**  
  
 A Visual C++ interface can be defined as follows:  
  
-   Can inherit from zero or more base interfaces.  
  
-   Cannot inherit from a base class.  
  
-   Can only contain public, pure virtual methods.  
  
-   Cannot contain constructors, destructors, or operators.  
  
-   Cannot contain static methods.  
  
-   Cannot contain data members; properties are allowed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 A C++ [class](../vs140/class--c---.md) or [struct](../vs140/struct--c---.md) could be implemented with these rules, but <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> enforces them.  
  
 For example, the following is a sample interface definition:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 For information on managed interfaces, see [interface class](../vs140/interface-class---c---component-extensions-.md).  
  
 Notice that you do not have to explicitly indicate that the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> functions are pure virtual. An equivalent declaration for the first function would be:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> implies the [novtable](../vs140/novtable.md) <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> modifier.  
  
## Example  
 The following sample shows how to use properties declared in an interface.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **p->int_data = 100**  
**bstr_data = Testing**   
## END Microsoft Specific  
  
## See Also  
 [Keywords](../vs140/keywords--c---.md)   
 [Interface Attributes](../vs140/interface-attributes.md)