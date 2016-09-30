---
title: "Method &#39;&lt;methodname&gt;&#39; does not have a signature compatible with delegate &lt;&#39;delegatename&#39;&gt;"
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
  - "vbc31143"
  - "bc31143"
helpviewer_keywords: 
  - "BC31143"
ms.assetid: 88990637-7c92-467e-a3d3-db5498dc1dce
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Method &#39;&lt;methodname&gt;&#39; does not have a signature compatible with delegate &lt;&#39;delegatename&#39;&gt;
This error occurs when a conversion is required between a method and a delegate that is not possible. The cause of the error can be conversion between parameters or, when the method and delegate are functions, conversion in the return values.  
  
 The following code illustrates failed conversions. The delegate is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following functions each differ from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in a way that will cause this error.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Each of the following assignment statements causes the error.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Error ID:** BC31143  
  
### To correct this error  
  
-   Examine the corresponding parameters and, if they are present, return types to determine which pair is not compatible.  
  
## See Also  
 [Relaxed Delegate Conversion](../vs140/relaxed-delegate-conversion--visual-basic-.md)   
 [NOT IN BUILD: Delegates and the AddressOf Operator](assetId:///7b2ed932-8598-4355-b2f7-5cedb23ee86f)