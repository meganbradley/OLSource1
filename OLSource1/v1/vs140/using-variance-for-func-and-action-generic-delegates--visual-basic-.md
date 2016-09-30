---
title: "Using Variance for Func and Action Generic Delegates (Visual Basic)"
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
ms.assetid: 36c3012f-b39c-493b-b90f-079b5912ac1b
caps.latest.revision: 7
---
# Using Variance for Func and Action Generic Delegates (Visual Basic)
These examples demonstrate how to use covariance and contravariance in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> generic delegates to enable reuse of methods and provide more flexibility in your code.  
  
 For more information about covariance and contravariance, see [Variance in Delegates (Visual Basic)](../vs140/variance-in-delegates--visual-basic-.md).  
  
## Using Delegates with Covariant Type Parameters  
 The following example illustrates the benefits of covariance support in the generic <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> delegates. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method takes a parameter of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> type and returns an object of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> type. However, you can assign this method to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> delegate because <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> inherits <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Using Delegates with Contravariant Type Parameters  
 The following example illustrates the benefits of contravariance support in the generic <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> delegates. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method takes a parameter of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> type. However, you can assign this method to the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> delegate because <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> inherits <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Covariance and Contravariance (Visual Basic)](../vs140/covariance-and-contravariance--visual-basic-.md)   
 [Generics in the .NET Framework](assetId:///2994d786-c5c7-4666-ab23-4c83129fe39c)