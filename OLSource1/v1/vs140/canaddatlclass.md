---
title: "CanAddATLClass"
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
  - "CanAddATLClass"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanAddATLClass method"
ms.assetid: 7a8abf90-c1b8-475c-af22-7948478084f9
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CanAddATLClass
Called by the wizard to verify that the user can add an ATL class to the project.  
  
## Syntax  
  
```  
  
      function CanAddATLClass(   
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
 **true** if the class can be added; **false** if the user calls the function for a project that is not an ATL project and does not have ATL support.  
  
## Remarks  
 Called by the wizard to verify if the project is compatible with the code wizard that is about to be run (in other words, it can accept an ATL class).  
  
 The wizard calls this function when the parameter PREPROCESS_FUNCTION is in the [project control's .vsz file](../vs140/.vsz-file--project-control-.md) and checks if the [Visual C++ Code Model](assetId:///dd6452c2-1054-44a1-b0eb-639a94a1216b) is available. If the code model is not available, the function reports an error and returns **false**.  
  
## Example  
  
```  
// Determine if an ATL class can be added to the project  
if (CanAddATLClass(selProj, selObj))  
{  
   return true;  
}  
```  
  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../vs140/customizing-c---wizards-with-common-jscript-functions.md)   
 [JScript Functions for C++ Wizards](../vs140/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../vs140/creating-a-custom-wizard.md)   
 [Designing a Wizard](../vs140/designing-a-wizard.md)   
 [CanAddClass](../vs140/canaddclass.md)   
 [IsMFCProject](../vs140/ismfcproject.md)   
 [CanAddMFCClass](../vs140/canaddmfcclass.md)