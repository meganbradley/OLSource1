---
title: "CDaoRecordset::GetFieldInfo"
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
  - "CDaoRecordset::GetFieldInfo"
  - "GetFieldInfo"
  - "CDaoRecordset.GetFieldInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "recordsets, getting field information"
  - "CDaoRecordset class, getting field information"
  - "GetFieldInfo method"
ms.assetid: 00fdd9de-ea09-4b89-9f34-1fc91f6d2b07
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::GetFieldInfo
Call this member function to obtain information about the fields in a recordset.  
  
## Syntax  
  
```  
  
      void GetFieldInfo(  
   int nIndex,  
   CDaoFieldInfo& fieldinfo,  
   DWORD dwInfoOptions = AFX_DAO_PRIMARY_INFO   
);  
void GetFieldInfo(  
   LPCTSTR lpszName,  
   CDaoFieldInfo& fieldinfo,  
   DWORD dwInfoOptions = AFX_DAO_PRIMARY_INFO   
);  
```  
  
#### Parameters  
 `nIndex`  
 The zero-based index of the predefined field in the recordset's Fields collection, for lookup by index.  
  
 `fieldinfo`  
 A reference to a [CDaoFieldInfo](../vs140/cdaofieldinfo-structure.md) structure.  
  
 `dwInfoOptions`  
 Options that specify which information about the recordset to retrieve. The available options are listed here along with what they cause the function to return. For best performance, retrieve only the level of information you need:  
  
-   `AFX_DAO_PRIMARY_INFO` (Default) Name, Type, Size, Attributes  
  
-   `AFX_DAO_SECONDARY_INFO` Primary information, plus: Ordinal Position, Required, Allow Zero Length, Collating Order, Foreign Name, Source Field, Source Table  
  
-   `AFX_DAO_ALL_INFO` Primary and secondary information, plus: Default Value, Validation Rule, Validation Text  
  
 `lpszName`  
 The name of the field.  
  
## Remarks  
 One version of the function lets you look up a field by index. The other version lets you look up a field by name.  
  
 For a description of the information returned, see the [CDaoFieldInfo](../vs140/cdaofieldinfo-structure.md) structure. This structure has members that correspond to the items of information listed above in the description of `dwInfoOptions`. When you request information at one level, you get information for any prior levels as well.  
  
 For related information, see the topic "Attributes Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::GetFieldCount](../vs140/cdaorecordset--getfieldcount.md)   
 [CDaoRecordset::GetFieldValue](../vs140/cdaorecordset--getfieldvalue.md)   
 [CDaoRecordset::GetIndexCount](../vs140/cdaorecordset--getindexcount.md)   
 [CDaoRecordset::GetIndexInfo](../vs140/cdaorecordset--getindexinfo.md)