---
title: "IOleInPlaceObjectWindowlessImpl::UIDeactivate"
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
  - "IOleInPlaceObjectWindowlessImpl::UIDeactivate"
  - "IOleInPlaceObjectWindowlessImpl.UIDeactivate"
  - "UIDeactivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UIDeactivate method"
ms.assetid: 9f520596-681c-4d9d-b1b0-1e029d83ce26
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleInPlaceObjectWindowlessImpl::UIDeactivate
Deactivates and removes the control's user interface that supports in-place activation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Sets the control class's data member <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to **FALSE**. The ATL implementation of this function always returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 See [IOleInPlaceObject::UIDeactivate](http://msdn.microsoft.com/library/windows/desktop/ms693348) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleInPlaceObjectWindowlessImpl Class](../vs140/ioleinplaceobjectwindowlessimpl-class.md)   
 [CComControlBase::m_bUIActive](../vs140/ccomcontrolbase--m_buiactive.md)