---
title: "CanAddClass"
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
  - "CanAddClass"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanAddClass method"
ms.assetid: 76739742-1e34-470c-910d-8784f0adfbf0
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CanAddClass
Called by the wizard to verify that the project is compatible with the code wizard the user is trying to run.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The selected project.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The selected object. In this case, the current project.  
  
## Return Value  
 **true** if the class can be added; otherwise **false**.  
  
## Remarks  
 The wizard calls this function when the parameter PREPROCESS_FUNCTION is in the [project control's .vsz file](../vs140/.vsz-file--project-control-.md).  
  
 It verifies if the [Visual C++ Code Model](assetId:///dd6452c2-1054-44a1-b0eb-639a94a1216b) object is available. If the code model is not available, the function reports an error and returns **false**.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../vs140/customizing-c---wizards-with-common-jscript-functions.md)   
 [JScript Functions for C++ Wizards](../vs140/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../vs140/creating-a-custom-wizard.md)   
 [Designing a Wizard](../vs140/designing-a-wizard.md)   
 [CanAddMFCClass](../vs140/canaddmfcclass.md)   
 [CanAddATLClass](../vs140/canaddatlclass.md)   
 [IsMFCProject](../vs140/ismfcproject.md)