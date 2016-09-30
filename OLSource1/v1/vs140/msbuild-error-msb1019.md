---
title: "MSBuild Error MSB1019"
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
  - "MSBuild.InvalidLoggerError"
helpviewer_keywords: 
  - "MSB1019"
ms.assetid: 5d0169f7-f878-433a-ac30-d9d6010130af
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MSBuild Error MSB1019
**Logger switch was not correctly formed.**  
  
 The **/logger** switch is not correctly specified. To specify a logger, you must provide at least the logger assembly, or if you want to be explicitly specify which logger to load, provide both the logger class and the logger assembly. Logger parameters are optional.  
  
### To correct this error  
  
1.  Specify a logger using both the logger class and logger assembly. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> syntax is:  
  
     <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
     The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> syntax is:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>syntax is:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> are optional and are passed to the logger exactly as you typed them.  
  
     Example: /<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
## See Also  
 [MSBuild Command Line Reference](../vs140/msbuild-command-line-reference.md)   
 [How To: Write a Logger](../vs140/build-loggers.md)