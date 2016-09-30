---
title: "GetUniqueFileName"
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
  - "GetUniqueFileName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetUniqueFilename method"
ms.assetid: f9760e1a-82d0-4d8b-b00a-6f4c36f6b2c6
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# GetUniqueFileName
Returns a unique file name.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *strDirectory*  
 Directory to look for file name in  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 File name to check.  
  
## Return Value  
 The file name indicated in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if unique; otherwise this function returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, appended with a number from 1 to 9999999, to make it unique. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is not provided, this function returns a unique file name by using [GetTempName Method](jsmthGetTempName).  
  
## Remarks  
 Returns a unique file name.  
  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../vs140/customizing-c---wizards-with-common-jscript-functions.md)   
 [JScript Functions for C++ Wizards](../vs140/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../vs140/creating-a-custom-wizard.md)   
 [Designing a Wizard](../vs140/designing-a-wizard.md)   
 [GetProjectFile](../vs140/getprojectfile.md)