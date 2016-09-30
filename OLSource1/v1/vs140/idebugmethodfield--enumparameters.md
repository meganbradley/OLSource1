---
title: "IDebugMethodField::EnumParameters"
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
  - "IDebugMethodField::EnumParameters"
helpviewer_keywords: 
  - "IDebugMethodField::EnumParameters method"
ms.assetid: d77b1197-deb6-4144-8d1b-8b09949ccfac
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugMethodField::EnumParameters
Creates an enumerator for the parameters of the method.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns an [IEnumDebugFields](../vs140/ienumdebugfields.md) object representing the list of parameters to the method; otherwise, returns a null value if there are no parameters.  
  
## Return Value  
 If successful, returns S_OK or returns S_FALSE if there are no parameters. Otherwise, returns an error code.  
  
## Remarks  
 Each element is an [IDebugField](../vs140/idebugfield.md) object representing different types of parameters. Call the [IDebugField::GetKind](../vs140/idebugfield--getkind.md) method on each object to determine exactly what kind of parameter the object represents.  
  
 A parameter includes both its variable name and its type. The first parameter to a class method is typically the "this" pointer.  
  
 If only the types of the parameters is needed, call the [IDebugMethodField::EnumArguments](../vs140/idebugmethodfield--enumarguments.md) method.  
  
## See Also  
 [IDebugMethodField](../vs140/idebugmethodfield.md)   
 [IEnumDebugFields](../vs140/ienumdebugfields.md)   
 [IDebugField](../vs140/idebugfield.md)   
 [IDebugMethodField::EnumArguments](../vs140/idebugmethodfield--enumarguments.md)