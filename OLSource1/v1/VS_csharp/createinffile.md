---
title: "CreateInfFile"
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
  - "CreateInfFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateInfFile method"
ms.assetid: 941ea2ce-db10-428e-b423-8dc2a7e825cf
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CreateInfFile
Creates the wizard's Templates.inf file.  
  
## Syntax  
  
```  
  
function CreateInfFile( );  
  
```  
  
## Return Value  
 The wizard template file.  
  
## Remarks  
 Call this function to create the wizard's Templates.inf file from Templatesinf.txt, a temporary text file it first creates in the temporary directory, based on the user's selections. Templates.inf contains the list of file names that the wizard creates. See [The Template File](../VS_csharp/template-files.md) for more information.  
  
 If this function cannot create the Templatesinf.txt file in the temporary directory, it displays an error.  
  
## Example  
 See [AddFilesToProject](../VS_csharp/addfilestoproject.md).  
  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../VS_csharp/customizing-c---wizards-with-common-jscript-functions.md)   
 [JScript Functions for C++ Wizards](../VS_csharp/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../VS_csharp/creating-a-custom-wizard.md)   
 [Designing a Wizard](../VS_csharp/designing-a-wizard.md)   
 [AddFilesToProject](../VS_csharp/addfilestoproject.md)   
 [SetFilters](../VS_csharp/setfilters.md)   
 [AddFilesToProject](../VS_csharp/addfilestoproject.md)