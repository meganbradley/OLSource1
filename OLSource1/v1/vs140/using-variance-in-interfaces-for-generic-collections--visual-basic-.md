---
title: "Using Variance in Interfaces for Generic Collections (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: c867fcea-7462-4995-b9c5-542feec74036
caps.latest.revision: 5
---
# Using Variance in Interfaces for Generic Collections (Visual Basic)
A covariant interface allows its methods to return more derived types than those specified in the interface. A contravariant interface allows its methods to accept parameters of less derived types than those specified in the interface.  
  
 In .NET Framework 4, several existing interfaces became covariant and contravariant. These include <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>1*>. This enables you to reuse methods that operate with generic collections of base types for collections of derived types.  
  
 For a list of variant interfaces in the .NET Framework, see [Variance in Generic Interfaces (Visual Basic)](../vs140/variance-in-generic-interfaces--visual-basic-.md).  
  
## Converting Generic Collections  
 The following example illustrates the benefits of covariance support in the <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>PrintFullName<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>IEnumerable(Of Person)<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>IEnumerable(Of Person)<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>Employee<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>Person<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>1*> interface. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class implements the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> interface. However, you can reuse this class to compare a sequence of objects of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> type because <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> inherits <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Variance in Generic Interfaces (Visual Basic)](../vs140/variance-in-generic-interfaces--visual-basic-.md)