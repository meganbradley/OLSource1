---
title: "_variant_t Extractors"
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
  - "_variant_t.operatordouble"
  - "operatorlong"
  - "_variant_t::operator_bstr_t"
  - "operatordouble"
  - "_variant_t.operatorCY"
  - "operatorCY"
  - "_variant_t::operatorCY"
  - "_variant_t::operatordouble"
  - "operatorfloat"
  - "operatorBYTE"
  - "_variant_t.operatorDECIMAL"
  - "_variant_t::operatorlong"
  - "operatorIDispatch"
  - "_variant_t.operatorBYTE"
  - "operatorDECIMAL"
  - "_variant_t.operator_bstr_t"
  - "_variant_t::operatorDECIMAL"
  - "_variant_t.operatorIUnknown"
  - "_variant_t.operatorlong"
  - "_variant_t::operatorIDispatch"
  - "_variant_t::operatorIUnknown"
  - "operatorIUnknown"
  - "_variant_t.operatorbool"
  - "_variant_t::operatorBYTE"
  - "_variant_t.operatorfloat"
  - "operator_bstr_t"
  - "_variant_t::operatorbool"
  - "operatorshort"
  - "_variant_t::operatorshort"
  - "_variant_t::operatorfloat"
  - "_variant_t.operatorIDispatch"
  - "_variant_t.operatorshort"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "extractors, _variant_t class"
  - "operator CY"
  - "operator IDispatch"
  - "operator SHORT"
  - "operator double"
  - "operator long"
  - "operator _bstr_t"
  - "operator DECIMAL"
  - "operator float"
  - "operator bool"
  - "operator BYTE"
  - "operator IUnknown"
ms.assetid: 33c1782f-045a-4673-9619-1d750efc83a9
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _variant_t Extractors
**Microsoft Specific**  
  
 Extract data from the encapsulated **VARIANT** object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Extracts raw data from an encapsulated **VARIANT**. If the **VARIANT** is not already the proper type, **VariantChangeType** is used to attempt a conversion, and an error is generated upon failure:  
  
-   **operator short( )** Extracts a **short** integer value.  
  
-   **operator long( )** Extracts a **long** integer value.  
  
-   **operator float( )** Extracts a **float** numerical value.  
  
-   **operator double( )** Extracts a **double** integer value.  
  
-   **operator CY( )** Extracts a **CY** object.  
  
-   **operator bool( )** Extracts a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> value.  
  
-   **operator DECIMAL( )** Extracts a **DECIMAL** value.  
  
-   **operator BYTE( )** Extracts a **BYTE** value.  
  
-   **operator _bstr_t( )** Extracts a string, which is encapsulated in a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
-   **operator IDispatch\*( )** Extracts a dispinterface pointer from an encapsulated **VARIANT**. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is called on the resulting pointer, so it is up to you to call **Release** to free it.  
  
-   **operator IUnknown\*( )** Extracts a COM interface pointer from an encapsulated **VARIANT**. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is called on the resulting pointer, so it is up to you to call **Release** to free it.  
  
 **END Microsoft Specific**  
  
## See Also  
 [_variant_t Class](../vs140/_variant_t-class.md)