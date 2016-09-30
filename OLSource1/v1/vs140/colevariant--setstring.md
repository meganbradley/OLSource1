---
title: "COleVariant::SetString"
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
  - "COleVariant.SetString"
  - "COleVariant::SetString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetString method"
ms.assetid: 1d8c05db-cfe0-4b79-b330-3c5772786430
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleVariant::SetString
Sets the string to a particular type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A null-terminated string to be copied into the new <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
 *VtSrc*  
 The **VARTYPE** for the new <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
## Remarks  
 The parameter <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> must be <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> (UNICODE) or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> (ANSI). <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is typically used to set strings to ANSI, since the default for the [COleVariant::COleVariant](../vs140/colevariant--colevariant.md) constructor with a string or string pointer parameter and no **VARTYPE** is UNICODE.  
  
 A DAO recordset in a non-UNICODE build expects strings to be ANSI. Thus, for DAO functions that use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> objects, if you are not creating a UNICODE recordset, you must use the **COleVariant::COleVariant(** <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>**,** <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> **)** form of constructor with <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> (ANSI) or use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to make ANSI strings. For example, the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> functions [CDaoRecordset::Seek](../vs140/cdaorecordset--seek.md) and [CDaoRecordset::SetFieldValue](../vs140/cdaorecordset--setfieldvalue.md) use <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> objects as parameters. These objects must be ANSI if the DAO recordset is not UNICODE.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleVariant Class](../vs140/colevariant-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleVariant::COleVariant](../vs140/colevariant--colevariant.md)   
 [CDaoRecordset::Seek](../vs140/cdaorecordset--seek.md)   
 [CDaoRecordset::SetFieldValue](../vs140/cdaorecordset--setfieldvalue.md)