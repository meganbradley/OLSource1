---
title: "_variant_t Relational Operators"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "_variant_t::operator=="
  - "_variant_t.operator!="
  - "_variant_t::operator!="
  - "_variant_t.operator=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "!= operator"
  - "relational operators, _variant_t class"
  - "operator!=, variant"
  - "operator!=, relational operators"
  - "operator !=, variant"
  - "operator ==, variant"
  - "operator==, variant"
  - "operator !=, relational operators"
  - "== operator, with specific Visual C++ objects"
ms.assetid: 141bacb8-41a2-44dd-b3c0-4ad1f884f4ea
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _variant_t Relational Operators
**Microsoft Specific**  
  
 Compare two `_variant_t` objects for equality or inequality.  
  
## Syntax  
  
```  
  
      bool operator==(  
   const VARIANT& varSrc   
) const;  
bool operator==(  
   const VARIANT* pSrc   
) const;  
bool operator!=(  
   const VARIANT& varSrc   
) const;  
bool operator!=(  
   const VARIANT* pSrc   
) const;  
```  
  
#### Parameters  
 *varSrc*  
 A **VARIANT** to be compared with the `_variant_t` object.  
  
 `pSrc`  
 Pointer to the **VARIANT** to be compared with the `_variant_t` object.  
  
## Return Value  
 Returns **true** if comparison holds, **false** if not.  
  
## Remarks  
 Compares a `_variant_t` object with a **VARIANT**, testing for equality or inequality.  
  
 **END Microsoft Specific**  
  
## See Also  
 [_variant_t Class](../vs140/_variant_t-class.md)