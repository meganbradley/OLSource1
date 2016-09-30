---
title: "A.23   Examples of the ordered Directive"
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
ms.assetid: f8fa761b-7fc5-4447-95f9-8571e9ca31bf
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# A.23   Examples of the ordered Directive
It is possible to have multiple ordered sections with a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> specified with the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> clause. The first example is noncompliant because the API specifies the following:  
  
 "An iteration of a loop with a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> construct must not execute the same <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> directive more than once, and it must not execute more than one <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> directive." (See [Section 2.6.6](../vs140/2.6.6-ordered-construct.md) on page 22)  
  
 In this noncompliant example, all iterations execute 2 ordered sections:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following compliant example shows a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> with more than one ordered section:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>