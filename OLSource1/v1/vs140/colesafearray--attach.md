---
title: "COleSafeArray::Attach"
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
  - "COleSafeArray::Attach"
  - "COleSafeArray.Attach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Attach method [MFC]"
ms.assetid: 93222227-1636-41e7-a71f-0cb0e1e22b0c
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleSafeArray::Attach
Gives control of the data in an existing **VARIANT** array to the `COleSafeArray` object.  
  
## Syntax  
  
```  
  
      void Attach(  
   VARIANT& varSrc   
);  
```  
  
#### Parameters  
 *varSrc*  
 A **VARIANT** object. The *varSrc* parameter must have the [VARTYPE](assetId:///317b911b-1805-402d-a9cb-159546bc88b4)**VT_ARRAY**.  
  
## Remarks  
 The source **VARIANT**'s type is set to `VT_EMPTY`. This function clears the current array data, if any.  
  
## Example  
 See the example for [COleSafeArray::AccessData](../vs140/colesafearray--accessdata.md).  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleSafeArray Class](../vs140/colesafearray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleSafeArray::Detach](../vs140/colesafearray--detach.md)