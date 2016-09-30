---
title: "_variant_t::Detach"
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
  - "_variant_t::Detach"
  - "_variant_t.Detach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "VARIANT object, detatch"
  - "Detach method"
  - "VARIANT object"
ms.assetid: c348ac08-62cf-4657-a16f-974a79c12158
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _variant_t::Detach
**Microsoft Specific**  
  
 Detaches the encapsulated **VARIANT** object from this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The encapsulated **VARIANT**.  
  
## Remarks  
 Extracts and returns the encapsulated **VARIANT**, then clears this <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object without destroying it. This member function removes the **VARIANT** from encapsulation and sets the **VARTYPE** of this <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. It is up to you to release the returned **VARIANT** by calling the [VariantClear](assetId:///28741d81-8404-4f85-95d3-5c209ec13835) function.  
  
 **END Microsoft Specific**  
  
## See Also  
 [_variant_t Class](../vs140/_variant_t-class.md)