---
title: "CComControlBase::GetAmbientProperty"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CComControlBase.GetAmbientProperty"
  - "ATL.CComControlBase.GetAmbientProperty"
  - "GetAmbientProperty"
  - "ATL::CComControlBase::GetAmbientProperty"
  - "CComControlBase::GetAmbientProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAmbientProperty method"
ms.assetid: 3bb0b59a-37f9-4117-94cc-dfd99d8db731
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::GetAmbientProperty
Retrieves the container property specified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Identifier of the container property to be retrieved.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Variable to receive the property.  
  
## Return Value  
 One of the standard HRESULT values.  
  
## Remarks  
 ATL has provided a set of helper functions to retrieve specific properties, for example, [CComControlBase::GetAmbientBackColor](../vs140/ccomcontrolbase--getambientbackcolor.md). If there is no suitable method available, use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)