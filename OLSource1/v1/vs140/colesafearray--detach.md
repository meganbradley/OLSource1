---
title: "COleSafeArray::Detach"
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
  - "COleSafeArray::Detach"
  - "COleSafeArray.Detach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Detach method"
ms.assetid: eb061d94-f251-4995-a933-b56d34693d88
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleSafeArray::Detach
Detaches the **VARIANT** data from the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The underlying **VARIANT** value in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
## Remarks  
 The function detaches the data in a safe array by setting the [VARTYPE](assetId:///317b911b-1805-402d-a9cb-159546bc88b4) of the object to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. It is the caller's responsibility to free the array by calling the Windows function [VariantClear](assetId:///28741d81-8404-4f85-95d3-5c209ec13835).  
  
 On error, the function throws a [COleException](../vs140/coleexception-class.md).  
  
## Example  
 See the example for [COleSafeArray::PutElement](../vs140/colesafearray--putelement.md).  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleSafeArray Class](../vs140/colesafearray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleSafeArray::Attach](../vs140/colesafearray--attach.md)   
 [VariantClear](assetId:///28741d81-8404-4f85-95d3-5c209ec13835)