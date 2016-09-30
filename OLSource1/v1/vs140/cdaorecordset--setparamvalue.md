---
title: "CDaoRecordset::SetParamValue"
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
  - "SetParamValue"
  - "CDaoRecordset::SetParamValue"
  - "CDaoRecordset.SetParamValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "recordsets, setting param values"
  - "SetParamValue method"
  - "CDaoRecordset class, setting parameter values"
ms.assetid: 2b3f233e-98b8-4a44-b61c-05f1c49cad71
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::SetParamValue
Call this member function to set the value of a parameter in the recordset at run time.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The numerical position of the parameter in the querydef's Parameters collection.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The value to set; see Remarks.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The name of the parameter whose value you want to set.  
  
## Remarks  
 The parameter must already have been established as part of the recordset's SQL string. You can access the parameter either by name or by its index position in the collection.  
  
 Specify the value to set as a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object. For information about setting the desired value and type in your <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object, see class [COleVariant](../vs140/colevariant-class.md). Note that if you are not creating a UNICODE recordset, the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object must be explicitly declared ANSI. This can be done by using the [COleVariant::COleVariant](../vs140/colevariant--colevariant.md)**(** <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>**,** <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> **)** form of constructor with <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> (ANSI) or by using the **COleVariant** function [SetString](../vs140/colevariant--setstring.md)**(** <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>**,** <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> **)** with <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::GetParamValue](../vs140/cdaorecordset--getparamvalue.md)   
 [CDaoRecordset::m_nParams](../vs140/cdaorecordset--m_nparams.md)   
 [CDaoRecordset::SetParamValueNull](../vs140/cdaorecordset--setparamvaluenull.md)