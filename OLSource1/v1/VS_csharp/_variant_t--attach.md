---
title: "_variant_t::Attach"
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
  - "_variant_t::Attach"
  - "_variant_t.Attach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Attach method"
  - "VARIANT object, attach"
  - "VARIANT object"
ms.assetid: 2f02bd08-2306-4477-aa88-d2a5dee2b859
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _variant_t::Attach
**Microsoft Specific**  
  
 Attaches a **VARIANT** object into the `_variant_t` object.  
  
## Syntax  
  
```  
  
      void Attach(  
   VARIANT& varSrc   
);  
```  
  
#### Parameters  
 *varSrc*  
 A **VARIANT** object to be attached to this `_variant_t` object.  
  
## Remarks  
 Takes ownership of the **VARIANT** by encapsulating it. This member function releases any existing encapsulated **VARIANT**, then copies the supplied **VARIANT**, and sets its **VARTYPE** to `VT_EMPTY` to make sure its resources can only be released by the `_variant_t` destructor.  
  
 **END Microsoft Specific**  
  
## See Also  
 [_variant_t Class](../VS_csharp/_variant_t-class.md)