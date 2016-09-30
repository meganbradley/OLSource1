---
title: "CComControlBase::GetAmbientFontDisp"
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
  - "CComControlBase.GetAmbientFontDisp"
  - "GetAmbientFontDisp"
  - "ATL.CComControlBase.GetAmbientFontDisp"
  - "CComControlBase::GetAmbientFontDisp"
  - "ATL::CComControlBase::GetAmbientFontDisp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAmbientFontDisp method"
ms.assetid: 19df3079-f4c7-4969-a78b-542a581b624b
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::GetAmbientFontDisp
Retrieves a pointer to the container's ambient **IFontDisp** dispatch interface.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the container's ambient [IFontDisp](http://msdn.microsoft.com/library/windows/desktop/ms692695) dispatch interface.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 If the property is **NULL**, the pointer is **NULL**. If the pointer is not **NULL**, the caller must release the pointer.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)