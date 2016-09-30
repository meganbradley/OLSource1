---
title: "finally"
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
  - "finally keyword [C++]"
ms.assetid: b55f3c8e-1af0-43e8-bcfb-99c3685d2578
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# finally
In addition to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> clauses, CLR exception handling supports a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> clause. The semantics are identical to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> block in structured exception handling (SEH). A <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> block can follow a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> block.  
  
## Remarks  
 The purpose of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> block is to clean up any resources left after the exception occurred. Note that the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> block is always executed, even if no exception was thrown. The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> block is only executed if a managed exception is thrown within the associated <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> block.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is a context-sensitive keyword; see [Context-Sensitive Keywords](../vs140/context-sensitive-keywords---c---component-extensions-.md) for more information.  
  
## Example  
 The following example demonstrates a simple <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> block:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **in catch**  
**MyException**  
**in finally**   
## See Also  
 [Exception Handling under /clr](../vs140/exception-handling---c---component-extensions-.md)