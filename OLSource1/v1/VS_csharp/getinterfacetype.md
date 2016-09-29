---
title: "GetInterfaceType"
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
  - "GetInterfaceType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetInterfaceType method"
ms.assetid: cc6403a8-0c2b-47f7-a8f7-9db95df87d5a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# GetInterfaceType
Gets the type of interface.  
  
## Syntax  
  
```  
  
      function GetInterfaceType(   
   oInterface    
);  
```  
  
#### Parameters  
 *oInterface*  
 A <xref:Microsoft.VisualStudio.VCCodeModel.VCCodeInterface*> object.  
  
## Return Value  
 The string indicating the type of interface, such as custom, dual, dispinterface, or oleautomation.  
  
## Remarks  
 Call this function to get the type of interface.  
  
## Example  
 See [GetMaxID](../VS_csharp/getmaxid.md).  
  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../VS_csharp/customizing-c---wizards-with-common-jscript-functions.md)   
 [JScript Functions for C++ Wizards](../VS_csharp/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../VS_csharp/creating-a-custom-wizard.md)   
 [Designing a Wizard](../VS_csharp/designing-a-wizard.md)   
 [GetInterfaceClasses](../VS_csharp/getinterfaceclasses.md)