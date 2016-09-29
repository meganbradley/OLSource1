---
title: "OnWizFinish"
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
  - "OnWizFinish"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnWizFinish method"
ms.assetid: 5e0790c3-c5b4-43de-b9db-b18d07c19f41
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OnWizFinish
Called from the wizard HTML script when the user clicks **Finish**. This function in turn calls the wizard control's **Finish** function.  
  
## Syntax  
  
```  
  
      function OnWizFinish(   
   document    
);  
```  
  
#### Parameters  
 `document`  
 The HTML document object  
  
## Remarks  
 This function is called from the wizard HTML script when the user clicks **Finish**.  
  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../VS_csharp/customizing-c---wizards-with-common-jscript-functions.md)   
 [JScript Functions for C++ Wizards](../VS_csharp/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../VS_csharp/creating-a-custom-wizard.md)   
 [Designing a Wizard](../VS_csharp/designing-a-wizard.md)