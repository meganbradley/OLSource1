---
title: "IDebugPropertyField::GetPropertySetter"
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
  - "IDebugPropertyField::GetPropertySetter"
helpviewer_keywords: 
  - "IDebugPropertyField::GetPropertySetter method"
ms.assetid: 744d76fd-2bcc-4917-a040-ce4cc714ef61
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPropertyField::GetPropertySetter
Gets the method that sets the property.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns an [IDebugMethodField](../vs140/idebugmethodfield.md) object representing the method that sets the property.  
  
## Return Value  
 If successful, returns S_OK; otherwise returns an error code.  
  
## Remarks  
 To get the method that gets the property, call the [GetPropertyGetter](../vs140/idebugpropertyfield--getpropertygetter.md) method.  
  
## See Also  
 [IDebugPropertyField](../vs140/idebugpropertyfield.md)   
 [IDebugMethodField](../vs140/idebugmethodfield.md)   
 [GetPropertyGetter](../vs140/idebugpropertyfield--getpropertygetter.md)