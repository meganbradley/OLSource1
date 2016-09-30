---
title: "IDebugMethodField::EnumArguments"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugMethodField::EnumArguments"
helpviewer_keywords: 
  - "IDebugMethodField::EnumArguments method"
ms.assetid: 3ab55488-2437-4ff6-a9ae-78ea6d7b23a8
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugMethodField::EnumArguments
Creates an enumerator for the type of each argument required to call the method.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns an [IEnumDebugFields](../vs140/ienumdebugfields.md) object representing the list of argument types. Returns a null value if there are no arguments.  
  
## Return Value  
 If successful, returns S_OK or returns S_FALSE if there are no arguments. Otherwise, returns an error code.  
  
## Remarks  
 Each element is an [IDebugField](../vs140/idebugfield.md) object representing the types of each parameter. Call the [IDebugField::GetInfo](../vs140/idebugfield--getinfo.md) method to retrieve information about the type of each parameter.  
  
 If the name of the parameter is needed along with the type, then call the [IDebugMethodField::EnumParameters](../vs140/idebugmethodfield--enumparameters.md) method.  
  
## See Also  
 [IDebugMethodField](../vs140/idebugmethodfield.md)   
 [IEnumDebugFields](../vs140/ienumdebugfields.md)   
 [IDebugField](../vs140/idebugfield.md)   
 [IDebugMethodField::EnumParameters](../vs140/idebugmethodfield--enumparameters.md)