---
title: "Fatal Error C1017"
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
  - "C1017"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C1017"
ms.assetid: 5542e604-599d-4e36-8f83-1d454c5753c9
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Fatal Error C1017
invalid integer constant expression  
  
 The expression in an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> directive did not exist or did not evaluate to a constant.  
  
 Constants defined using <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> must have values that evaluate to an integer constant if they are used in an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> directive.  
  
 The following sample generates C1017:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Possible resolution:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Because <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> evaluates to a string and not an integer, the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> directive generates fatal error C1017.  
  
 In other cases, the preprocessor evaluates an undefined constant as zero. This can cause unintended results, as shown in the following sample. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is undefined, so it evaluates to zero. The expression <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> evaluates to false and the code to be used on <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is removed by the preprocessor. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is also undefined (zero), so <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> evaluates to true (<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>), causing the preprocessor to leave the code in the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> portion of the statement — exactly the opposite of the intended behavior.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 To see exactly how the compiler handles preprocessor directives, use [/P](../vs140/-p--preprocess-to-a-file-.md), [/E](../vs140/-e--preprocess-to-stdout-.md), or [/EP](../vs140/-ep--preprocess-to-stdout-without-sharpline-directives-.md).