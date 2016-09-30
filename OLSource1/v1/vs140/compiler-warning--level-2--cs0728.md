---
title: "Compiler Warning (level 2) CS0728"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS0728"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0728"
ms.assetid: ad6d860d-bac4-48f3-9eab-1efd2b6de6c0
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 2) CS0728
Possibly incorrect assignment to local 'variable' which is the argument to a using or lock statement.  The Dispose call or unlocking will happen on the original value of the local.  
  
 There are several scenarios where <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> blocks will result in a temporary leak of resources. Here is one example:  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 In this case, the original value, such as null, of the variable <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> will be disposed of when the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> block finishes executing, but the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object created inside the block will not be, although it will eventually get garbage collected.  
  
 To resolve this error, use the following form:  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 In this case, the newly allocated <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object will be disposed of.  
  
## Example  
 The following code will generate warning CS0728.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>