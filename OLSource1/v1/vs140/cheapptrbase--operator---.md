---
title: "CHeapPtrBase::operator -&gt;"
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
  - "ATL.CHeapPtrBase.operator->"
  - "ATL::CHeapPtrBase::operator->"
  - "CHeapPtrBase.operator->"
  - "CHeapPtrBase::operator->"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-> operator"
  - "operator->"
ms.assetid: e2d981d9-88cb-4004-aad4-7e23045e5c30
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHeapPtrBase::operator -&gt;
The pointer-to-member operator.  
  
## Syntax  
  
```  
  
T* operator ->( ) const throw( );  
  
```  
  
## Return Value  
 Returns the value of the [CHeapPtrBase::m_pData](../vs140/cheapptrbase--m_pdata.md) member variable.  
  
## Remarks  
 Use this operator to call a method in a class pointed to by the `CHeapPtrBase` object. In debug builds, an assertion failure will occur if the `CHeapPtrBase` points to NULL.  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CHeapPtrBase Class](../vs140/cheapptrbase-class.md)