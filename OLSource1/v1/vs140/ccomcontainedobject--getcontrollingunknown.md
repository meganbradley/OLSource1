---
title: "CComContainedObject::GetControllingUnknown"
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
  - "CComContainedObject.GetControllingUnknown"
  - "ATL::CComContainedObject<Base>::GetControllingUnknown"
  - "ATL.CComContainedObject.GetControllingUnknown"
  - "GetControllingUnknown"
  - "CComContainedObject::GetControllingUnknown"
  - "ATL::CComContainedObject::GetControllingUnknown"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetControllingUnknown method"
ms.assetid: 343ddb9a-483c-49b2-93a7-65e5f67c4c28
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComContainedObject::GetControllingUnknown
Returns the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member pointer (inherited through the *Base* class) that holds the owner object's **IUnknown**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The owner object's **IUnknown**.  
  
## Remarks  
 This method may be virtual if <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> has declared the [DECLARE_GET_CONTROLLING_UNKNOWN](../vs140/declare_get_controlling_unknown.md) macro.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComContainedObject Class](../vs140/ccomcontainedobject-class.md)   
 [CComObjectRootEx::m_pOuterUnknown](../vs140/ccomobjectrootex--m_pouterunknown.md)