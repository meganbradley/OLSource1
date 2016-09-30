---
title: "GetCodeForDllUnregisterServer"
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
  - "GetCodeForDllUnregisterServer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCodeForDllUnregisterServer method"
ms.assetid: 6b152943-8c30-49f4-a55c-d0cba8d27a17
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# GetCodeForDllUnregisterServer
Gets the appropriate code for unregistering a server.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The zero-based line number for the start of the function.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The zero-based line number for the end of the function.  
  
## Return Value  
 A string containing the code for unregistering the server.  
  
## Remarks  
 Call this member function to retrieve the appropriate code for unregistering the server:  
  
|Line number|Code|  
|-----------------|----------|  
|0|AFX_MANAGE_STATE(AfxGetStaticModuleState());|  
|1|_AtlModule.UpdateRegistryAppId(FALSE);|  
|2|HRESULT hRes = _AtlModule.UnregisterServer(TRUE);|  
|3|if (hRes != S_OK)|  
|4|\treturn hRes;|  
|5|if (!COleObjectFactory::UpdateRegistryAll(FALSE))|  
|6|\treturn ResultFromScode(SELFREG_E_CLASS);|  
|7|return S_OK;|  
  
 For each of the lines returned, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> adds a leading tab (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) and a trailing "CR-LF" (carriage return - linefeed) character pair (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Customizing C++ Wizards with Common JScript Functions](../vs140/customizing-c---wizards-with-common-jscript-functions.md)   
 [JScript Functions for C++ Wizards](../vs140/jscript-functions-for-c---wizards.md)   
 [Creating a Custom Wizard](../vs140/creating-a-custom-wizard.md)   
 [Designing a Wizard](../vs140/designing-a-wizard.md)   
 [GetCodeForDllRegisterServer](../vs140/getcodefordllregisterserver.md)