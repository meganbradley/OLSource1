---
title: "_variant_t::ChangeType"
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
  - "_variant_t::ChangeType"
  - "_variant_t.ChangeType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ChangeType method"
  - "VARIANT object, ChangeType"
  - "VARIANT object"
ms.assetid: 829d2eeb-3338-4a88-9dce-0ca145f47aac
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _variant_t::ChangeType
**Microsoft Specific**  
  
 Changes the type of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object to the indicated **VARTYPE**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The **VARTYPE** for this <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object to be converted. If this value is **NULL**, conversion is done in place.  
  
## Remarks  
 This member function converts a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object into the indicated **VARTYPE**. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is **NULL**, the conversion is done in place, otherwise this <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object is copied from <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and then converted.  
  
 **END Microsoft Specific**  
  
## See Also  
 [_variant_t Class](../vs140/_variant_t-class.md)