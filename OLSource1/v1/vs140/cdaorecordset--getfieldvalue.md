---
title: "CDaoRecordset::GetFieldValue"
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
  - "CDaoRecordset::GetFieldValue"
  - "CDaoRecordset.GetFieldValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "recordsets, getting field information"
  - "CDaoRecordset class, getting field information"
  - "GetFieldValue method"
ms.assetid: 7606c2ff-86c8-4d49-8af0-e48f55e95ebf
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::GetFieldValue
Call this member function to retrieve data in a recordset.  
  
## Syntax  
  
```  
  
      virtual void GetFieldValue(  
   LPCTSTR lpszName,  
   COleVariant& varValue   
);  
virtual void GetFieldValue(  
   int nIndex,  
   COleVariant& varValue   
);  
virtual COleVariant GetFieldValue(  
   LPCTSTR lpszName   
);  
virtual COleVariant GetFieldValue(  
   int nIndex   
);  
```  
  
#### Parameters  
 `lpszName`  
 A pointer to a string that contains the name of a field.  
  
 `varValue`  
 A reference to a `COleVariant` object that will store the value of a field.  
  
 `nIndex`  
 A zero-based index of the field in the recordset's Fields collection, for lookup by index.  
  
## Return Value  
 The two versions of `GetFieldValue` that return a value return a [COleVariant](../vs140/colevariant-class.md) object that contains the value of a field.  
  
## Remarks  
 You can look up a field by name or by ordinal position.  
  
> [!NOTE]
>  It is more efficient to call one of the versions of this member function that takes a `COleVariant` object reference as a parameter, rather than calling a version that returns a `COleVariant` object. The latter versions of this function are kept for backward compatibility.  
  
 Use `GetFieldValue` and [SetFieldValue](../vs140/cdaorecordset--setfieldvalue.md) to dynamically bind fields at run time rather than statically binding columns using the [DoFieldExchange](../vs140/cdaorecordset--dofieldexchange.md) mechanism.  
  
 `GetFieldValue` and the `DoFieldExchange` mechanism can be combined to improve performance. For example, use `GetFieldValue` to retrieve a value that you need only on demand, and assign that call to a "More Information" button in the interface.  
  
 For related information, see the topics "Field Object" and "Value Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::SetFieldValue](../vs140/cdaorecordset--setfieldvalue.md)