---
title: "OffsetToLineNumber"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "OffsetToLineNumber"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OffsetToLineNumber function"
ms.assetid: ac7e3c22-6b3b-432c-85cc-b50bbef9ce8c
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OffsetToLineNumber
Called by [InsertIntoFunction](../vs140/insertintofunction.md) to convert an index in a function body to a line number.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The string containing the function body. The function body is a multi-line string where its lines are delimited by cr-lf character pairs.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A position within the string.  
  
## Return Value  
 The line within the body function where <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is located. The first line in the function is considered to be line 1 (not 0).  
  
## Remarks  
 Finds the line number for a given position in a function body.  
  
 This function is called by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to convert the index located at <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in a function body to a line number.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../vs140/customizing-c---wizards-with-common-jscript-functions.md)   
 [JScript Functions for C++ Wizards](../vs140/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../vs140/creating-a-custom-wizard.md)   
 [Designing a Wizard](../vs140/designing-a-wizard.md)   
 [LineBeginsWith](../vs140/linebeginswith.md)