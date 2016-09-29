---
title: "COleSafeArray::COleSafeArray"
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
  - "COleSafeArray::COleSafeArray"
  - "COleSafeArray.COleSafeArray"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleSafeArray class, constructor"
ms.assetid: fc5a5987-9e5b-404b-8cf5-42c942ccf873
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleSafeArray::COleSafeArray
Constructs a `COleSafeArray` object.  
  
## Syntax  
  
```  
  
      COleSafeArray( );  
COleSafeArray(  
   const SAFEARRAY& saSrc,  
   VARTYPE vtSrc   
);  
COleSafeArray(  
   LPCSAFEARRAY pSrc,  
   VARTYPE vtSrc   
);  
COleSafeArray(  
   const COleSafeArray& saSrc   
);  
COleSafeArray(  
   const VARIANT& varSrc   
);  
COleSafeArray(  
   LPCVARIANT pSrc   
);  
COleSafeArray(  
   const COleVariant& varSrc   
);  
```  
  
#### Parameters  
 `saSrc`  
 An existing `COleSafeArray` object or **SAFEARRAY** to be copied into the new `COleSafeArray` object.  
  
 `vtSrc`  
 The **VARTYPE** of the new `COleSafeArray` object.  
  
 `psaSrc`  
 A pointer to a **SAFEARRAY** to be copied into the new `COleSafeArray` object.  
  
 *varSrc*  
 An existing **VARIANT** or `COleVariant` object to be copied into the new `COleSafeArray` object.  
  
 `pSrc`  
 A pointer to a **VARIANT** object to be copied into the new `COleSafeArray` object.  
  
## Remarks  
 All of these constructors create new `COleSafeArray` objects. If there is no parameter, an empty `COleSafeArray` object is created (`VT_EMPTY`). If the `COleSafeArray` is copied from another array whose [VARTYPE](assetId:///317b911b-1805-402d-a9cb-159546bc88b4) is known implicitly (a `COleSafeArray`, `COleVariant`, or **VARIANT**), the **VARTYPE** of the source array is retained and need not be specified. If the `COleSafeArray` is copied from another array whose **VARTYPE** is not known (**SAFEARRAY**), the **VARTYPE** must be specified in the `vtSrc` parameter.  
  
 On error, the function throws a [CMemoryException](../vs140/cmemoryexception-class.md) or [COleException](../vs140/coleexception-class.md).  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleSafeArray Class](../vs140/colesafearray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [VariantCopy](assetId:///f6ddbe1f-37b0-44f1-a3f0-b7ef4df88f8a)