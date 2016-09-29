---
title: "GetCodeForDllGetClassObject"
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
  - "GetCodeForDllGetClassObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCodeForDllGetClassObject method"
ms.assetid: 67b61b3b-9784-494f-ba01-17bffa9941ff
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# GetCodeForDllGetClassObject
Retrieves the code for the DLL class object.  
  
## Syntax  
  
```  
  
      function GetCodeForDllGetClassObject(   
   nLineStart,   
   nLineEnd    
);  
```  
  
#### Parameters  
 `nLineStart`  
 The zero-based line number for the start of the function.  
  
 `nLineEnd`  
 The zero-based line number for the end of the function.  
  
## Return Value  
 A string containing the code for getting the class object.  
  
## Remarks  
 Call this member function to retrieve the code for the class object. Calling this function creates a single string by concatenating the array elements you specify.  
  
 The following table shows code for getting the code for the class object:  
  
|Line number|Code|  
|-----------------|----------|  
|0|AFX_MANAGE_STATE(AfxGetStaticModuleState());|  
|1|if (S_OK == _AtlModule.GetClassObject(rclsid, riid, ppv))|  
|2|\treturn S_OK;|  
|3|return AfxDllGetClassObject(rclsid, riid, ppv);|  
  
 For each of the lines returned, `GetCodeForDllGetClassObject` adds a leading tab (`\t`) and a trailing "CR-LF" (carriage return - linefeed) character pair (`\r\n`).  
  
## Example  
  
```  
// Get the lines numbered 1 and 2 above  
GetCodeForDllGetClassObject(1, 2)  
  
// returns the following string  
// "\tif (S_OK == _AtlModule.GetClassObject(rclsid, riid, ppv))\r\n\t\treturn S_OK;\r\n"  
  
```  
  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../vs140/customizing-c---wizards-with-common-jscript-functions.md)   
 [JScript Functions for C++ Wizards](../vs140/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../vs140/creating-a-custom-wizard.md)   
 [Designing a Wizard](../vs140/designing-a-wizard.md)