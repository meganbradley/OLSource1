---
title: "CDaoRecordset::SetFieldValue"
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
  - "CDaoRecordset::SetFieldValue"
  - "SetFieldValue"
  - "CDaoRecordset.SetFieldValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "recordsets, setting field flags and values"
  - "SetFieldValue method"
  - "CDaoRecordset class, setting field values"
ms.assetid: e34c33a8-5077-4e53-b828-ad1963a98551
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::SetFieldValue
Call this member function to set the value of a field, either by ordinal position or by changing the value of the string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a string containing the name of a field.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to a [COleVariant](../vs140/colevariant-class.md) object containing the value of the field's contents.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An integer that represents the ordinal position of the field in the recordset's Fields collection (zero-based).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to a string containing the value of the field's contents.  
  
## Remarks  
 Use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and [GetFieldValue](../vs140/cdaorecordset--getfieldvalue.md) to dynamically bind fields at run time rather than statically binding columns using the [DoFieldExchange](../vs140/cdaorecordset--dofieldexchange.md) mechanism.  
  
 Note that if you are not creating a UNICODE recordset, you must either use a form of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> that does not contain a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter, or the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object must be explicitly declared ANSI. This can be done by using the [COleVariant::COleVariant](../vs140/colevariant--colevariant.md)**(** <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>**,** <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> **)** form of constructor with <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> (ANSI) or by using the **COleVariant** function [SetString](../vs140/colevariant--setstring.md)**(** <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>**,** <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> **)** with <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 For related information, see the topics "Field Object" and "Value Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::GetFieldValue](../vs140/cdaorecordset--getfieldvalue.md)   
 [CDaoRecordset::m_nParams](../vs140/cdaorecordset--m_nparams.md)   
 [CDaoRecordset::SetFieldValueNull](../vs140/cdaorecordset--setfieldvaluenull.md)   
 [COleVariant::COleVariant](../vs140/colevariant--colevariant.md)   
 [COleVariant::SetString](../vs140/colevariant--setstring.md)