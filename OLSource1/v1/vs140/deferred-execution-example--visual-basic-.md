---
title: "Deferred Execution Example (Visual Basic)"
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
ms.assetid: 9a22bea1-c755-4aac-800a-fcd9e5107ace
caps.latest.revision: 7
---
# Deferred Execution Example (Visual Basic)
This topic shows how deferred execution and lazy evaluation affect the execution of your LINQ to XML queries.  
  
## Example  
 The following example shows the order of execution when using an extension method that uses deferred execution. The example declares an array of three strings. It then iterates through the collection returned by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example produces the following output:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Notice that when iterating through the collection returned by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, each item is retrieved from the source string array and converted to uppercase before the next item is retrieved from the source string array.  
  
 You can see that the entire array of strings is not converted to uppercase before each item in the returned collection is processed in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> loop in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## See Also  
 [Tutorial: Deferred Execution (Visual Basic)](../vs140/tutorial--deferred-execution--visual-basic-.md)