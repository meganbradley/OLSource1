---
title: "_U_STRINGorID::_U_STRINGorID"
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
  - "_U_STRINGorID::_U_STRINGorID"
  - "ATL::_U_STRINGorID::_U_STRINGorID"
  - "_U_STRINGorID._U_STRINGorID"
  - "ATL._U_STRINGorID._U_STRINGorID"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "U_STRINGorID class, constructor"
  - "U_STRINGorID constructor"
  - "_U_STRINGorID constructor"
  - "_U_STRINGorID class, constructor"
ms.assetid: 9b6fd512-10b0-4a9c-95ff-2566a5d8623a
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _U_STRINGorID::_U_STRINGorID
The **UINT** constructor converts its argument to a resource type compatible with Windows resource-management functions using the **MAKEINTRESOURCE** macro and the result is stored in the class's single data member, [m_lpstr](../VS_csharp/_u_stringorid--m_lpstr.md).  
  
## Syntax  
  
```  
  
      _U_STRINGorID(  
   UINT nID   
);  
_U_STRINGorID(  
   LPCTSTR lpString   
);  
```  
  
#### Parameters  
 `nID`  
 A resource ID.  
  
 `lpString`  
 A resource name.  
  
## Remarks  
 The argument to the `LPCTSTR` constructor is stored directly without conversion.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [_U_STRINGorID Class](../VS_csharp/_u_stringorid-class.md)   
 [_U_STRINGorID::m_lpstr](../VS_csharp/_u_stringorid--m_lpstr.md)