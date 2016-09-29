---
title: "CPropertySheet::m_psh"
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
  - "CPropertySheet.m_psh"
  - "CPropertySheet::m_psh"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPropertySheet class, data members"
  - "m_psh"
ms.assetid: 52eb4a50-6d27-432d-a946-2b7911b2185e
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropertySheet::m_psh
A structure whose members store the characteristics of [PROPSHEETHEADER](http://msdn.microsoft.com/library/windows/desktop/bb774546).  
  
## Remarks  
 Use this structure to initialize the appearance of the property sheet after it is constructed but before it is displayed with the [DoModal](../vs140/cpropertysheet--domodal.md) member function. For example, set the `dwSize` member of `m_psh` to the size you want the property sheet to have.  
  
 For more information on this structure, including a listing of its members, see **PROPSHEETHEADER** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFCDocView#143](../vs140/codesnippet/CPP/cpropertysheet--m_psh_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertySheet Class](../vs140/cpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPropertySheet::DoModal](../vs140/cpropertysheet--domodal.md)