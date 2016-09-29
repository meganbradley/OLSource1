---
title: "CAdapt::operator =="
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
  - "ATL::CAdapt<T>::operator=="
  - "CAdapt<T>::operator=="
  - "ATL::CAdapt::operator=="
  - "CAdapt.operator=="
  - "ATL.CAdapt.operator=="
  - "ATL.CAdapt<T>.operator=="
  - "CAdapt<T>.operator=="
  - "CAdapt::operator=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator==, adapters"
  - "operator ==, adapters"
  - "== operator"
ms.assetid: fe429b72-0984-4c52-8362-1b256036573c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAdapt::operator ==
Compares an object of the adapted type with [m_T](../vs140/cadapt--m_t.md).  
  
## Syntax  
  
```  
  
      bool operator==(  
   const T& rSrc  
) const;  
```  
  
#### Parameters  
 `rSrc`  
 A reference to the object to be compared.  
  
## Return Value  
 The result of the comparison between `m_T` and `rSrc`.  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CAdapt Class](../vs140/cadapt-class.md)   
 [CAdapt::operator <](../vs140/cadapt--operator--.md)