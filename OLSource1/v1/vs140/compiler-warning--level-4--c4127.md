---
title: "Compiler Warning (level 4) C4127"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "C4127"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4127"
ms.assetid: f59ded9e-5227-45bd-ac43-2aa861581363
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4127
conditional expression is constant  
  
 The controlling expression of an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> statement or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> loop evaluates to a constant. Because of their common idiomatic usage, trivial constants such as 1 or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> do not trigger the warning, unless they are the result of an operation in an expression. If the controlling expression of a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> loop is a constant because the loop exits in the middle, consider replacing the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> loop with a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> loop. You can omit the initialization, termination test and loop increment of a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> loop, which causes the loop to be infinite, just like <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and you can exit the loop from the body of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> statement.  
  
 The following sample shows two ways C4127 is generated, and shows how to use a for loop to avoid the warning:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>