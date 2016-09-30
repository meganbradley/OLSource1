---
title: "MSBuild Error MSB1007"
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
  - "MSBuild.MissingLoggerError"
helpviewer_keywords: 
  - "MSB1007"
ms.assetid: bf45dbc3-50cd-488a-87df-9e647cd71f10
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB1007
**Specify a logger.**  
  
 A logger must be specified for the **/logger** switch.  
  
### To correct this error  
  
1.  Specify a logger using both the logger class and logger assembly. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> syntax is:  
  
     <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
     The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> syntax is:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>syntax is:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> are optional and are passed to the logger exactly as you typed them.  
  
     Some examples of the **/logger** switch are:  
  
     <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
## See Also  
 [MSBuild Command Line Reference](../vs140/msbuild-command-line-reference.md)