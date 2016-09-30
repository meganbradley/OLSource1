---
title: "GetCodeForDllCanUnloadNow"
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
  - "GetCodeForDllCanUnloadNow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCodeForDllCanUnloadNow method"
ms.assetid: 24ee3ef7-45be-4778-99e8-6df493f0782b
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# GetCodeForDllCanUnloadNow
Gets the appropriate code for unloading the DLL.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The zero-based line number for the start of the function.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The zero-based line number for the end of the function.  
  
## Return Value  
 A string containing the code for unloading the DLL.  
  
## Remarks  
 Call this member function to retrieve the appropriate code for unloading the DLL. Calling this function creates a single string by concatenating the array elements you specify.  
  
 The following table shows code for unloading the DLL.  
  
|Line number|Code|  
|-----------------|----------|  
|0|AFX_MANAGE_STATE(AfxGetStaticModuleState());|  
|1|if (_AtlModule.GetLockCount() > 0)|  
|2|\treturn S_FALSE;|  
|3|return S_OK;|  
  
 For each of the lines returned, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> adds a leading tab (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) and a trailing "CR-LF" (carriage return - linefeed) character pair (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../vs140/customizing-c---wizards-with-common-jscript-functions.md)   
 [JScript Functions for C++ Wizards](../vs140/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../vs140/creating-a-custom-wizard.md)   
 [Designing a Wizard](../vs140/designing-a-wizard.md)   
 [GetCodeForDllGetClassObject](../vs140/getcodefordllgetclassobject.md)   
 [GetCodeForExitInstance](../vs140/getcodeforexitinstance.md)