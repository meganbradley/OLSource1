---
title: "SetErrorInfo"
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
  - "SetErrorInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetErrorInfo method"
ms.assetid: 78bca763-3f90-4e04-b566-b4b7fe2431b1
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SetErrorInfo
Called by [OnWizFinish](../vs140/onwizfinish.md) and [CanUseFileName](../vs140/canusefilename.md) to provide current error information.  
  
## Syntax  
  
```  
  
      function SetErrorInfo(   
   oErrorObj   
);  
```  
  
#### Parameters  
 *oErrorObj*  
 The error object.  
  
## Remarks  
 Called by [OnWizFinish](../vs140/onwizfinish.md) and [CanUseFileName](../vs140/canusefilename.md) to provide current error information. See [M:Microsoft.VisualStudio.VsWizard.VCWizCtlClass.SetErrorInfo(System.String,System.UInt32,System.UInt32,System.String,System.String)](assetId:///M:Microsoft.VisualStudio.VsWizard.VCWizCtlClass.SetErrorInfo(System.String,System.UInt32,System.UInt32,System.String,System.String)?qualifyHint=False&autoUpgrade=True) in the Visual C++ Wizard Model documentation for more information.  
  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../vs140/customizing-c---wizards-with-common-jscript-functions.md)   
 [JScript Functions for C++ Wizards](../vs140/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../vs140/creating-a-custom-wizard.md)   
 [Designing a Wizard](../vs140/designing-a-wizard.md)