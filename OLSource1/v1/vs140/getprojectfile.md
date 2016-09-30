---
title: "GetProjectFile"
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
  - "GetProjectFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetProjectFile method"
ms.assetid: e5fdc468-755a-4b4e-81bd-e63881531bed
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# GetProjectFile
Returns the file name specified type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 oProj  
 The selected project.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type of file to retrieve, such as STDAFX, RC, IDL, CPP, H, ODL, or DEF.  
  
 *bFullPath*  
 Flag indicating whether to return the full path name.  
  
 *bMFC*  
 Indicates if the project is an MFC-based project. If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is .cpp or .h, it is considered MFC based. If not, the project is assumed to be ATL based.  
  
## Return Value  
 The file name of the per-project type of files.  
  
## Remarks  
 Call this function to get the file name of the specified type in the specified project.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../vs140/customizing-c---wizards-with-common-jscript-functions.md)   
 [JScript Functions for C++ Wizards](../vs140/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../vs140/creating-a-custom-wizard.md)   
 [Designing a Wizard](../vs140/designing-a-wizard.md)   
 [GetProjectPath](../vs140/getprojectpath.md)   
 [GetUniqueFileName](../vs140/getuniquefilename.md)