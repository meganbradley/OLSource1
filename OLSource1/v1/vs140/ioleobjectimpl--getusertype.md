---
title: "IOleObjectImpl::GetUserType"
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
  - "ATL.IOleObjectImpl.GetUserType"
  - "GetUserType"
  - "ATL.IOleObjectImpl<T>.GetUserType"
  - "IOleObjectImpl::GetUserType"
  - "IOleObjectImpl<T>::GetUserType"
  - "ATL::IOleObjectImpl<T>::GetUserType"
  - "IOleObjectImpl.GetUserType"
  - "ATL::IOleObjectImpl::GetUserType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetUserType method"
ms.assetid: 59fd615b-5478-4fb1-8da5-29f939c6c957
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IOleObjectImpl::GetUserType
Returns the control's user-type name by calling **OleRegGetUserType**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The user-type name is used for display in user-interfaces elements such as menus and dialog boxes. You can change the user-type name in your project's .rgs file.  
  
 See [IOleObject::GetUserType](http://msdn.microsoft.com/library/windows/desktop/ms688643) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [IOleObjectImpl Class](../vs140/ioleobjectimpl-class.md)   
 [OleRegGetUserType](http://msdn.microsoft.com/library/windows/desktop/ms682271)   
 [IOleObjectImpl::GetUserClassID](../vs140/ioleobjectimpl--getuserclassid.md)   
 [IOleObjectImpl::GetMiscStatus](../vs140/ioleobjectimpl--getmiscstatus.md)   
 [IOleObjectImpl::EnumVerbs](../vs140/ioleobjectimpl--enumverbs.md)