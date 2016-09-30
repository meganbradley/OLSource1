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
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An existing <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object or **SAFEARRAY** to be copied into the new <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The **VARTYPE** of the new <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A pointer to a **SAFEARRAY** to be copied into the new <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.  
  
 *varSrc*  
 An existing **VARIANT** or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object to be copied into the new <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A pointer to a **VARIANT** object to be copied into the new <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.  
  
## Remarks  
 All of these constructors create new <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> objects. If there is no parameter, an empty <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object is created (<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>). If the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is copied from another array whose [VARTYPE](assetId:///317b911b-1805-402d-a9cb-159546bc88b4) is known implicitly (a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, or **VARIANT**), the **VARTYPE** of the source array is retained and need not be specified. If the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is copied from another array whose **VARTYPE** is not known (**SAFEARRAY**), the **VARTYPE** must be specified in the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> parameter.  
  
 On error, the function throws a [CMemoryException](../vs140/cmemoryexception-class.md) or [COleException](../vs140/coleexception-class.md).  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleSafeArray Class](../vs140/colesafearray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [VariantCopy](assetId:///f6ddbe1f-37b0-44f1-a3f0-b7ef4df88f8a)