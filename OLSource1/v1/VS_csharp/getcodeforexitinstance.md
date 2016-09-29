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
Gets the [ExitInstance](../Topic/CWinApp::ExitInstance.md) code for terminating the wizard.  
  
## Syntax  
  
```  
  
      function GetCodeForExitInstance(   
   nLineStart,   
   nLineEnd    
)   
```  
  
#### Parameters  
 `nLineStart`  
 The zero-based line number for the start of the function.  
  
 `nLineEnd`  
 The zero-based line number for the end of the function.  
  
## Return Value  
 A string containing the code for exiting the wizard instance.  
  
## Remarks  
 Call this member function to retrieve the appropriate code for exiting an instance of the wizard:  
  
|Line number|ExitInstance code|  
|-----------------|-----------------------|  
|0|_AtlModule.RevokeClassObjects();|  
|1|return CWinApp::ExitInstance();|  
  
 For each of the lines returned, `GetCodeForExitInstance` adds a leading tab (`\t`) and a trailing "CR-LF" (carriage return - linefeed) character pair (`\r\n`).  
  
## Example  
  
```  
if (!oExitInstance)  
   {  
      oExitInstance = oCWinApp.AddFunction("ExitInstance",   
      vsCMFunctionFunction, "BOOL", vsCMAddPositionEnd, vsCMAccessPublic,   
      strProjectCPP);  
      oExitInstance.BodyText = GetCodeForExitInstance(0, 1);  
   }  
// returns the following string  
// "\t_AtlModule.RevokeClassObjects();\r\n  
// \treturn CWinApp::ExitInstance();\r\n"  
else  
   {  
   oExitInstance.StartPointOf(vsCMPartBody,   
   vsCMWhereDefinition).CreateEditPoint().Insert(GetCodeForExitInstance(0,   
   0));  
// returns the following string  
// "\t_AtlModule.RevokeClassObjects();\r\n  
      oCM.Synchronize();  
   }  
  
```  
  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../VS_csharp/customizing-c---wizards-with-common-jscript-functions.md)   
 [JScript Functions for C++ Wizards](../VS_csharp/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../VS_csharp/creating-a-custom-wizard.md)   
 [Designing a Wizard](../VS_csharp/designing-a-wizard.md)   
 [GetCodeForDllCanUnloadNow](../VS_csharp/getcodefordllcanunloadnow.md)   
 [GetCodeForInitInstance](../VS_csharp/getcodeforinitinstance.md)