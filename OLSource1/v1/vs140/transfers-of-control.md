---
title: "Transfers of Control"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "control flow, branching"
  - "control flow, transferring control"
ms.assetid: aa51e7f2-060f-4106-b0fe-331f04357423
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Transfers of Control
You can use the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement or a **case** label in a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement to specify a program that branches past an initializer. Such code is illegal unless the declaration that contains the initializer is in a block enclosed by the block in which the jump statement occurs.  
  
 The following example shows a loop that declares and initializes the objects <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. There is also an erroneous <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement that transfers control past an initializer.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In the preceding example, the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement tries to transfer control past the initialization of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. However, if <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> were declared but not initialized, the transfer would be legal.  
  
 The objects <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, declared in the block that serves as the *statement* of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> statement, are destroyed when that block is exited using the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> statement.  
  
## See Also  
 [(NOTINBUILD) Declaration of Automatic Objects](assetId:///81f941e9-c1b1-4d1c-a28d-70b6ee9765db)