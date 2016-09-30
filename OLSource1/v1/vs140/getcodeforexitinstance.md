---
title: "GetCodeForExitInstance"
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
  - "GetCodeForExitInstance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCodeForExitInstance method"
ms.assetid: 41fe3d79-a1f4-4bb5-b3f5-7859e255b4e7
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# GetCodeForExitInstance
Gets the [ExitInstance](../vs140/cwinapp--exitinstance.md) code for terminating the wizard.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The zero-based line number for the start of the function.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The zero-based line number for the end of the function.  
  
## Return Value  
 A string containing the code for exiting the wizard instance.  
  
## Remarks  
 Call this member function to retrieve the appropriate code for exiting an instance of the wizard:  
  
|Line number|ExitInstance code|  
|-----------------|-----------------------|  
|0|_AtlModule.RevokeClassObjects();|  
|1|return CWinApp::ExitInstance();|  
  
 For each of the lines returned, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> adds a leading tab (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) and a trailing "CR-LF" (carriage return - linefeed) character pair (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../vs140/customizing-c---wizards-with-common-jscript-functions.md)   
 [JScript Functions for C++ Wizards](../vs140/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../vs140/creating-a-custom-wizard.md)   
 [Designing a Wizard](../vs140/designing-a-wizard.md)   
 [GetCodeForDllCanUnloadNow](../vs140/getcodefordllcanunloadnow.md)   
 [GetCodeForInitInstance](../vs140/getcodeforinitinstance.md)