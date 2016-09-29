---
title: "IncludeCodeElementDeclaration"
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
  - "IncludeCodeElementDeclaration"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IncludeCodeElementDeclaration method"
ms.assetid: 714e76e4-76bc-439a-982a-cf9d4ada7677
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IncludeCodeElementDeclaration
Adds the include statement to `strInFile`, including the header where `strCodeElemName` is implemented, if such a header found in the `oProj`.  
  
## Syntax  
  
```  
  
      function IncludeCodeElementDeclaration(   
   oProj,   
   strCodeElemName,   
   strInFile    
);  
```  
  
#### Parameters  
 `oProj`  
 The selected project.  
  
 `strCodeElemName`  
 The full name of the code element for which you are searching the definition header.  
  
 `strInFile`  
 The file that will include the definition header, if found.  
  
## Remarks  
 Adds the include statement to `strInFile`, including the header where `strCodeElemName` is implemented, if such a header found in `oProj`.  
  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../VS_csharp/customizing-c---wizards-with-common-jscript-functions.md)   
 [JScript Functions for C++ Wizards](../VS_csharp/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../VS_csharp/creating-a-custom-wizard.md)   
 [Designing a Wizard](../VS_csharp/designing-a-wizard.md)