---
title: "Using Variance in Delegates (Visual Basic)"
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
ms.assetid: 7b5c20f1-6416-46a3-94b6-f109c31c842c
caps.latest.revision: 7
---
# Using Variance in Delegates (Visual Basic)
When you assign a method to a delegate, *covariance* and *contravariance* provide flexibility for matching a delegate type with a method signature. Covariance permits a method to have return type that is more derived than that defined in the delegate. Contravariance permits a method that has parameter types that are less derived than those in the delegate type.  
  
## Example 1: Covariance  
  
### Description  
 This example demonstrates how delegates can be used with methods that have return types that are derived from the return type in the delegate signature. The data type returned by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, which derives from the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> type that is defined in the delegate.  
  
### Code  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example 2: Contravariance  
  
### Description  
 This example demonstrates how delegates can be used with methods that have parameters of a type that are base types of the delegate signature parameter type. With contravariance, you can use one event handler instead of separate handlers. For example, you can create an event handler that accepts an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> input parameter and use it with a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> event that sends a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> type as a parameter, and also with a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> event that sends a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter.  
  
### Code  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Variance in Delegates (Visual Basic)](../vs140/variance-in-delegates--visual-basic-.md)   
 [Using Variance for Func and Action Generic Delegates (Visual Basic)](../vs140/using-variance-for-func-and-action-generic-delegates--visual-basic-.md)