---
title: "_variant_t Class"
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
  - "Variant"
  - "_variant_t"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_variant_t class, operators"
  - "_variant_t class"
  - "_variant_t class, member functions"
  - "VARIANT object"
  - "VARIANT object, COM encapsulation"
ms.assetid: 6a3cbd4e-0ae8-425e-b4cf-ca0df894c93f
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _variant_t Class
**Microsoft Specific**  
  
 A <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> object encapsulates the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> data type. The class manages resource allocation and deallocation and makes function calls to **VariantInit** and **VariantClear** as appropriate.  
  
### Construction  
  
|||  
|-|-|  
|[_variant_t](../vs140/_variant_t--_variant_t.md)|Constructs a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.|  
  
### Operations  
  
|||  
|-|-|  
|[Attach](../vs140/_variant_t--attach.md)|Attaches a **VARIANT** object into the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.|  
|[Clear](../vs140/_variant_t--clear.md)|Clears the encapsulated **VARIANT** object.|  
|[ChangeType](../vs140/_variant_t--changetype.md)|Changes the type of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object to the indicated **VARTYPE**.|  
|[Detach](../vs140/_variant_t--detach.md)|Detaches the encapsulated **VARIANT** object from this <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.|  
|[SetString](../vs140/_variant_t--setstring.md)|Assigns a string to this <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.|  
  
### Operators  
  
|||  
|-|-|  
|[Operator =](../vs140/_variant_t--operator-=.md)|Assigns a new value to an existing <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.|  
|[operator ==, !=](../vs140/_variant_t-relational-operators.md)|Compare two <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> objects for equality or inequality.|  
|[Extractors](../vs140/_variant_t-extractors.md)|Extract data from the encapsulated **VARIANT** object.|  
  
## END Microsoft Specific  
  
## Requirements  
 **Header:** comutil.h  
  
 **Lib:** comsuppw.lib or comsuppwd.lib (see [/Zc:wchar_t (wchar_t Is Native Type)](../vs140/-zc-wchar_t--wchar_t-is-native-type-.md) for more information)  
  
## See Also  
 [Compiler COM Support Classes](../vs140/compiler-com-support-classes.md)