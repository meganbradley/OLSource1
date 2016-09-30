---
title: "Troubleshooting Arrays (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "troubleshooting arrays"
  - "arrays [Visual Basic], initialization errors"
  - "troubleshooting Visual Basic, arrays"
  - "arrays [Visual Basic], compilation errors"
  - "arrays [Visual Basic], declaration errors"
  - "arrays [Visual Basic], troubleshooting"
ms.assetid: f4e971c7-c0a4-4ed7-a77a-8d71039f266f
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Arrays (Visual Basic)
This page lists some common problems that can occur when working with arrays.  
  
## Compilation Errors Declaring and Initializing an Array  
 Compilation errors can arise from misunderstanding of the rules for declaring, creating, and initializing arrays. The most common causes of errors are the following:  
  
-   Supplying a [New (Visual Basic)](../vs140/new-operator--visual-basic-.md) clause after specifying dimension lengths in the array variable declaration. The following code lines show invalid declarations of this type.  
  
     <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
-   Specifying dimension lengths for more than the top-level array of a jagged array. The following code line shows an invalid declaration of this type.  
  
     <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
-   Omitting the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword when specifying the element values. The following code line shows an invalid declaration of this type.  
  
     <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
-   Supplying a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> clause without braces (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>). The following code lines show invalid declarations of this type.  
  
     <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
## Accessing an Array Out of Bounds  
 The process of initializing an array assigns an upper bound and a lower bound to each dimension. Every access to an element of the array must specify a valid index, or subscript, for every dimension. If any index is below its lower bound or above its upper bound, an \<xref:System.IndexOutOfRangeException*> exception results. The compiler cannot detect such an error, so an error occurs at run time.  
  
### Determining Bounds  
 If another component passes an array to your code, for example as a procedure argument, you do not know the size of that array or the lengths of its dimensions. You should always determine the upper bound for every dimension of an array before you attempt to access any elements. If the array has been created by some means other than a [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> clause, the lower bound might be something other than 0, and it is safest to determine that lower bound as well.  
  
### Specifying the Dimension  
 When determining the bounds of a multidimensional array, take care how you specify the dimension. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameters of the \<xref:System.Array.GetLowerBound*> and \<xref:System.Array.GetUpperBound*> methods are 0-based, while the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameters of the [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] \<xref:Microsoft.VisualBasic.Information.LBound*> and \<xref:Microsoft.VisualBasic.Information.UBound*> functions are 1-based.  
  
## See Also  
 [Arrays](../vs140/arrays-in-visual-basic.md)   
 [How to: Initialize Array Variables](../vs140/how-to--initialize-an-array-variable-in-visual-basic.md)