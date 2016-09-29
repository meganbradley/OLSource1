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
  
```  
  
      function CanAddClass(   
   oProj,   
   oObject    
);  
```  
  
#### Parameters  
 `oProj`  
 The selected project.  
  
 `oObject`  
 The selected object. In this case, the current project.  
  
## Return Value  
 **true** if the class can be added; otherwise **false**.  
  
## Remarks  
 The wizard calls this function when the parameter PREPROCESS_FUNCTION is in the [project control's .vsz file](../VS_csharp/.vsz-file--project-control-.md).  
  
 It verifies if the [Visual C++ Code Model](assetId:///dd6452c2-1054-44a1-b0eb-639a94a1216b) object is available. If the code model is not available, the function reports an error and returns **false**.  
  
## Example  
  
```  
// Determine if a class can be added to the project  
if (CanAddClass(selProj, selObj))  
{  
   return true;  
}  
```  
  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../VS_csharp/customizing-c---wizards-with-common-jscript-functions.md)   
 [JScript Functions for C++ Wizards](../VS_csharp/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../VS_csharp/creating-a-custom-wizard.md)   
 [Designing a Wizard](../VS_csharp/designing-a-wizard.md)   
 [CanAddMFCClass](../VS_csharp/canaddmfcclass.md)   
 [CanAddATLClass](../VS_csharp/canaddatlclass.md)   
 [IsMFCProject](../VS_csharp/ismfcproject.md)