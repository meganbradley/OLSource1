---
title: "IDebugClassField::EnumNestedClasses"
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
  - "IDebugClassField::EnumNestedClasses"
helpviewer_keywords: 
  - "IDebugClassField::EnumNestedClasses method"
ms.assetid: 2ba5ef0c-395e-4006-9e3c-9b06e1d711d0
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugClassField::EnumNestedClasses
Creates an enumerator for the classes nested in this class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns an [IEnumDebugFields](../vs140/ienumdebugfields.md) object representing the list of nested classes. Returns a null value if there are no nested classes.  
  
## Return Value  
 If successful, returns S_OK or returns S_FALSE if there are no nested classes. Otherwise, returns an error code.  
  
## Remarks  
 Each element of the enumeration is an [IDebugClassField](../vs140/idebugclassfield.md) object describing a nested class.  
  
 A nested class is a class defined inside another class. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The [IEnumDebugFields](../vs140/ienumdebugfields.md) enumeration would contain one object representing the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class.  
  
## See Also  
 [IDebugClassField](../vs140/idebugclassfield.md)   
 [IEnumDebugFields](../vs140/ienumdebugfields.md)