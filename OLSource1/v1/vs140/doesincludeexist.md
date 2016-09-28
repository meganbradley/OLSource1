---
title: "DoesIncludeExist"
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
  - "DoesIncludeExist"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoesIncludeExist method"
ms.assetid: 39751a3d-dfe5-423c-bd94-a53771c3e360
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DoesIncludeExist
Indicates whether a `#include` statement for a specified header file exists in a file.  
  
## Syntax  
  
```  
  
      function DoesIncludeExist(   
   oProj,   
   strHeaderFile,   
   strInsertIntoFile    
);  
```  
  
#### Parameters  
 `oProj`  
 The selected project.  
  
 *strHeaderFile*  
 The name of the header file to find.  
  
 `strInsertIntoFile`  
 The source file containing the `#include` statement for the header file (excluding the path).  
  
## Return Value  
 **true** if the specified header file is included; otherwise **false**.  
  
## Remarks  
 Indicates whether a #include for a specific header file exists in the file specified by `strInsertIntoFile`.  
  
## Example  
  
```  
// Check to see if #include for atlbase.h   
// is included in the project's stdafx.h.  
// and add it if it is not.  
if (!DoesIncludeExist(selProj, "<atlbase.h>", strSTDAFX))  
   oCM.AddInclude("<atlbase.h>", strSTDAFX, vsCMAddPositionEnd);  
```  
  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../vs140/customizing-c---wizards-with-common-jscript-functions.md)   
 [JScript Functions for C++ Wizards](../vs140/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../vs140/creating-a-custom-wizard.md)   
 [Designing a Wizard](../vs140/designing-a-wizard.md)