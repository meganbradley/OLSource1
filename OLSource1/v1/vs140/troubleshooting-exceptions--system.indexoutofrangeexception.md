---
title: "Troubleshooting Exceptions: System.IndexOutOfRangeException"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "IndexOutOfRangeException class"
ms.assetid: 9e28623c-93fc-4111-a0cb-c380e0b5de0c
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.IndexOutOfRangeException
An \<xref:System.IndexOutOfRangeException*> exception is thrown when an attempt is made to access an element of an array or collection with an index that is outside the bounds of the array or less than zero.  
  
## Associated Tips  
 **Make sure that the maximum index on a list is less than the list size**  
 The maximum index on a list must be less than the list size.  
  
 **Make sure the index is not a negative number.**  
 This exception will be thrown if the index is less than zero.  
  
 **Make sure data column names are correct.**  
 This exception may be thrown if the data column name being supplied to the \<xref:System.Data.DataView.Sort*?displayProperty=fullName> property is not valid. For more information, see the \<xref:System.Data.DataView*> class.  
  
## Example  
  
### Description  
 The following example uses a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> block to trap the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> when index <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is outside the array bounds, 0 to 3. The example displays the following:  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
### Code  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.IndexOutOfRangeException*>   
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)   
 [Arrays in Visual Basic](../vs140/arrays-in-visual-basic.md)