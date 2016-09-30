---
title: "IDebugClassField::EnumConstructors"
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
  - "IDebugClassField::EnumConstructors"
helpviewer_keywords: 
  - "IDebugClassField::EnumConstructors method"
ms.assetid: 66a250b2-75a0-45aa-8d58-40f91cc4bf7b
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugClassField::EnumConstructors
Creates an enumerator for the constructors for this class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A value from the [CONSTRUCTOR_ENUM](../vs140/constructor_enum.md) enumeration that specifies the type of constructors to enumeration.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns an [IEnumDebugFields](../vs140/ienumdebugfields.md) object representing the list of constructors. Returns a null value if there are no constructors.  
  
## Return Value  
 If successful, returns S_OK or returns S_FALSE if there are no constructors. Otherwise, returns an error code.  
  
## Remarks  
 Each element of the enumeration is an [IDebugMethodField](../vs140/idebugmethodfield.md) object describing a constructor method.  
  
 The list of constructors typically does not include the default constructors supplied by a compiler.  
  
## See Also  
 [IDebugClassField](../vs140/idebugclassfield.md)   
 [IEnumDebugFields](../vs140/ienumdebugfields.md)   
 [IDebugMethodField](../vs140/idebugmethodfield.md)   
 [CONSTRUCTOR_ENUM](../vs140/constructor_enum.md)