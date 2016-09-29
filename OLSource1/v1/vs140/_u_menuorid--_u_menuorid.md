---
title: "_U_MENUorID::_U_MENUorID"
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
  - "ATL._U_MENUorID._U_MENUorID"
  - "ATL::_U_MENUorID::_U_MENUorID"
  - "_U_MENUorID"
  - "_U_MENUorID._U_MENUorID"
  - "_U_MENUorID::_U_MENUorID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "U_MENUorID constructor"
  - "U_MENUorID class, constructor"
  - "_U_MENUorID constructor"
  - "_U_MENUorID class, constructor"
ms.assetid: 8b8f99ad-428c-4195-923a-e63bfacb26e2
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _U_MENUorID::_U_MENUorID
The **UINT** argument is just cast to an `HMENU` in the constructor and the result stored in the class's single data member, [m_hMenu](../vs140/_u_menuorid--m_hmenu.md).  
  
## Syntax  
  
```  
  
      _U_MENUorID(  
   UINT nID   
);  
_U_MENUorID(  
   HMENU hMenu   
);  
```  
  
#### Parameters  
 `nID`  
 A child window identifier.  
  
 `hMenu`  
 A menu handle.  
  
## Remarks  
 The argument to the `HMENU` constructor is stored directly without conversion.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [_U_MENUorID Class](../vs140/_u_menuorid-class.md)   
 [_U_MENUorID::m_hMenu](../vs140/_u_menuorid--m_hmenu.md)