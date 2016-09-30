---
title: "COleVariant::operator ="
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
  - "COleVariant::operator="
  - "COleVariant.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleVariant class, operators"
  - "operator=, variant"
  - "= operator, with specific MFC objects"
  - "operator =, variant"
ms.assetid: 025926e8-f15c-4d2e-86cc-292ac86a06d2
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleVariant::operator =
These overloaded assignment operators copy the source value into this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 A brief description of each operator follows:  
  
-   **operator =(** *varSrc* **)** Copies an existing **VARIANT** or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object into this object.  
  
-   **operator =(** <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> **)** Copies the **VARIANT** object accessed by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> into this object.  
  
-   **operator =(** <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> **)** Copies a null-terminated string into this object and sets the **VARTYPE** to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
-   **operator =(** <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> **)** Copies a [CString](../vs140/cstringt-class.md) object into this object and sets the **VARTYPE** to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
-   **operator =(** <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> **)** Copies an 8- or 16-bit integer value into this object. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is an 8-bit value, the **VARTYPE** of this is set to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is a 16-bit value and the **VARTYPE** of this is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, it is kept; otherwise, it is set to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
-   **operator =(** <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> **)** Copies a 32-bit integer value into this object. If the **VARTYPE** of this is <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, it is kept; otherwise, it is set to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
-   **operator =(** <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> **)** Copies a [COleCurrency](../vs140/colecurrency-class.md) object into this object and sets the **VARTYPE** to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
-   **operator =(** <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> **)** Copies a 32-bit floating-point value into this object and sets the **VARTYPE** to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
-   **operator =(** <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> **)** Copies a 64-bit floating-point value into this object and sets the **VARTYPE** to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
-   **operator =(** <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> **)** Copies a [COleDateTime](../vs140/coledatetime-class.md) object into this object and sets the **VARTYPE** to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
-   **operator =(** <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> **)** Copies a [CByteArray](../vs140/cbytearray-class.md) object into this <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object.  
  
-   **operator =(** <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> **)** Copies a [CLongBinary](../vs140/clongbinary-class.md) object into this <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object.  
  
 For more information, see the [VARIANT](assetId:///e305240e-9e11-4006-98cc-26f4932d2118) and [VARTYPE](assetId:///317b911b-1805-402d-a9cb-159546bc88b4) entries in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleVariant Class](../vs140/colevariant-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleVariant::COleVariant](../vs140/colevariant--colevariant.md)   
 [COleCurrency Class](../vs140/colecurrency-class.md)   
 [COleDateTime Class](../vs140/coledatetime-class.md)