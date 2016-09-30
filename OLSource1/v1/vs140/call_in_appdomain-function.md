---
title: "call_in_appdomain Function"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "call_in_appdomain"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "call_in_appdomain function"
ms.assetid: 9a1a5026-b76b-4cae-a3d4-29badeb9db9c
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# call_in_appdomain Function
Executes a function in a specified application domain.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The appdomain in which to call the function.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function that takes N parameters (0 <= N <= 15).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to a non-<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function that takes N parameters (0 <= N <= 15).  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Zero to 15 parameters to be passed to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in the other appdomain.  
  
## Return Value  
 The result of executing <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> in the specified application domain.  
  
## Remarks  
 The arguments of the function passed to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> must not be CLR types.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header file** \<msclr\appdomain.h>  
  
 **Namespace** msclr