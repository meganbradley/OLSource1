---
title: "_U_MENUorID Class"
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
  - "ATL._U_MENUorID"
  - "ATL::_U_MENUorID"
  - "_U_MENUorID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "U_MENUorID class"
  - "_U_MENUorID class"
ms.assetid: cfc8032b-61b4-4a68-ba3a-92b82500ccae
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _U_MENUorID Class
This class provides wrappers for **CreateWindow** and **CreateWindowEx**.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
```  
  
class _U_MENUorID  
  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[_U_MENUorID::_U_MENUorID](../vs140/_u_menuorid--_u_menuorid.md)|The constructor.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[_U_MENUorID::m_hMenu](../vs140/_u_menuorid--m_hmenu.md)|A handle to a menu.|  
  
## Remarks  
 This argument adapter class allows either IDs (                **UINT**s) or menu handles ( `HMENU`s) to be passed to a function without requiring an explicit cast on the part of the caller.  
  
 This class is designed for implementing wrappers to the Windows API, particularly the [CreateWindow](http://msdn.microsoft.com/library/windows/desktop/ms632679) and [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) functions, both of which accept an `HMENU` argument that may be a child window identifier (                **UINT**) rather than a menu handle. For example, you can see this class in use as a parameter to [CWindowImpl::Create](../vs140/cwindowimpl--create.md).  
  
 The class defines two constructor overloads: one accepts a **UINT** argument and the other accepts an `HMENU` argument. The **UINT** argument is just cast to an `HMENU` in the constructor and the result stored in the class's single data member, [m_hMenu](../vs140/_u_menuorid--m_hmenu.md). The argument to the `HMENU` constructor is stored directly without conversion.  
  
## Requirements  
 **Header:** atlwin.h  
  
##  <a name="_u_menuorid__m_hmenu"></a>  _U_MENUorID::m_hMenu  
 The class holds the value passed to either of its constructors as a public `HMENU` data member.  
  
```  
  
HMENU m_hMenu;  
  
```  
  
##  <a name="_u_menuorid___u_menuorid"></a>  _U_MENUorID::_U_MENUorID  
 The **UINT** argument is just cast to an `HMENU` in the constructor and the result stored in the class's single data member, [m_hMenu](../vs140/_u_menuorid--m_hmenu.md).  
  
```  
  
_U_MENUorID(  
      UINT  nID  
   );  
   _U_MENUorID(  
      HMENU  hMenu  
   );  
  
```  
  
### Parameters  
 `nID`  
 A child window identifier.  
  
 `hMenu`  
 A menu handle.  
  
### Remarks  
 The argument to the `HMENU` constructor is stored directly without conversion.  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)