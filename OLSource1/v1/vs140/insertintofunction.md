---
title: "InsertIntoFunction"
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
  - "InsertIntoFunction"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsertIntoFunction method"
ms.assetid: 50500c3c-bee3-4a9c-a403-7dcd752de23c
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# InsertIntoFunction
Used by [AddATLSupportToProject](../vs140/addatlsupporttoproject.md) to insert code into [InitInstance](../vs140/cwinapp--initinstance.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *oFunction*  
 The function object into which the insertion is made.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The string to find to determine insertion point.  
  
 *nStartLine*  
 The starting line to pass to [GetCodeForInitInstance](../vs140/getcodeforinitinstance.md).  
  
 *nEndLine*  
 Ending line to pass to [GetCodeForInitInstance](../vs140/getcodeforinitinstance.md).  
  
 *bInsideIfBlock*  
 Indicates whether the insertion is into a function block.  
  
## Return Value  
 **true** if successful; otherwise **false**.  
  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../vs140/customizing-c---wizards-with-common-jscript-functions.md)   
 [JScript Functions for C++ Wizards](../vs140/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../vs140/creating-a-custom-wizard.md)   
 [Designing a Wizard](../vs140/designing-a-wizard.md)   
 [GetMemberfunction](../vs140/getmemberfunction.md)