---
title: "Compiler Warning (level 3) C4800"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C4800"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4800"
ms.assetid: 4f409799-a250-45ed-bb5f-657691b0d9f7
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) C4800
'type' : forcing value to bool 'true' or 'false' (performance warning)  
  
 This warning is generated when a value that is not <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is assigned or coerced into type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. Typically, this message is caused by assigning <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> variables to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> variables where the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> variable contains only values **true** and **false**, and could be redeclared as type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. If you cannot rewrite the expression to use type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, then you can add "<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>" to the expression, which gives the expression type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. Casting the expression to type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> will not disable the warning, which is by design.  
  
 The following sample generates C4800:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>