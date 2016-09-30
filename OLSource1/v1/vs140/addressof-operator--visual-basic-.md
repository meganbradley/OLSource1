---
title: "AddressOf Operator (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AddressOf"
  - "vb.AddressOf"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "AddressOf operator"
  - "addresses, passing to API procedures"
ms.assetid: 8105a59d-60d8-4ab5-b221-5899cdfacbf4
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AddressOf Operator (Visual Basic)
Creates a procedure delegate instance that references the specific procedure.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Required. Specifies the procedure to be referenced by the newly created procedure delegate.  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> operator creates a function delegate that points to the function specified by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. When the specified procedure is an instance method then the function delegate refers to both the instance and the method. Then, when the function delegate is invoked the specified method of the specified instance is called.  
  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operator can be used as the operand of a delegate constructor or it can be used in a context in which the type of the delegate can be determined by the compiler.  
  
## Example  
 This example uses the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> operator to designate a delegate to handle the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> event of a button.  
  
 [!code[VbVbalrDelegates#8](../vs140/codesnippet/VisualBasic/addressof-operator--visual-basic-_1.vb)]  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> operator to designate the startup function for a thread.  
  
 [!code[VbVbalrDelegates#9](../vs140/codesnippet/VisualBasic/addressof-operator--visual-basic-_2.vb)]  
  
## See Also  
 [Declare Statement](../vs140/declare-statement.md)   
 [Function Statement](../vs140/function-statement--visual-basic-.md)   
 [Sub Statement](../vs140/sub-statement--visual-basic-.md)   
 [Delegates (Visual Basic)](../vs140/delegates--visual-basic-.md)