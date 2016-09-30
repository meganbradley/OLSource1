---
title: "CComVariant::ChangeType"
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
  - "CComVariant::ChangeType"
  - "ATL.CComVariant.ChangeType"
  - "CComVariant.ChangeType"
  - "ATL::CComVariant::ChangeType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ChangeType method"
ms.assetid: 32acb97e-11fa-471b-8682-9bfa3c665eb8
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComVariant::ChangeType
Converts the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object to a new type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The new type for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] A pointer to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> whose value will be converted to the new type. The default value is **NULL**, meaning the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object will be converted in place.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> value.  
  
## Remarks  
 If you pass a value for <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> will use this **VARIANT** as the source for the conversion. Otherwise, the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object will be the source.  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CComVariant Class](../vs140/ccomvariant-class.md)