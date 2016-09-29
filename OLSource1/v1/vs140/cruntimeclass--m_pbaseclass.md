---
title: "CRuntimeClass::m_pBaseClass"
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
  - "CRuntimeClass.m_pBaseClass"
  - "m_pBaseClass"
  - "CRuntimeClass::m_pBaseClass"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_pBaseClass"
ms.assetid: f6252076-7870-4df4-b144-e5e9c80219a5
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRuntimeClass::m_pBaseClass
If your application statically links to MFC, this data member contains a pointer to the `CRuntimeClass` structure of the base class.  
  
## Remarks  
 If your application dynamically links to the MFC library, see [m_pfnGetBaseClass](../vs140/cruntimeclass--m_pfngetbaseclass.md).  
  
## Example  
 See the example for [IsDerivedFrom](../vs140/cruntimeclass--isderivedfrom.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CRuntimeClass Structure](../vs140/cruntimeclass-structure.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)