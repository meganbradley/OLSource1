---
title: "CDaoQueryDef::GetFieldInfo"
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
  - "CDaoQueryDef.GetFieldInfo"
  - "GetFieldInfo"
  - "AFX_DAO_SECONDARY_INFO"
  - "CDaoQueryDef::GetFieldInfo"
  - "AFX_DAO_PRIMARY_INFO"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoQueryDef class, getting information"
  - "field information for querydef"
  - "AFX_DAO_ALL_INFO"
  - "AFX_DAO_SECONDARY_INFO"
  - "AFX_DAO_PRIMARY_INFO"
  - "GetFieldInfo method"
  - "QueryDef objects, getting field information"
ms.assetid: f1fa4b04-d2f4-4c16-96a1-81838db9f231
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoQueryDef::GetFieldInfo
Call this member function to obtain various kinds of information about a field defined in the querydef.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The zero-based index of the desired field in the querydef's Fields collection, for lookup by index.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object that returns the information requested.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Options that specify which information about the field to retrieve. The available options are listed here along with what they cause the function to return:  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> (Default) Name, Type, Size, Attributes  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> Primary information plus: Ordinal Position, Required, Allow Zero Length, Source Field, Foreign Name, Source Table, Collating Order  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> Primary and secondary information plus: Default Value, Validation Text, Validation Rule  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A string containing the name of the desired field, for lookup by name. You can use a [CString](../vs140/cstringt-class.md).  
  
## Remarks  
 For a description of the information returned in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, see the [CDaoFieldInfo](../vs140/cdaofieldinfo-structure.md) structure. This structure has members that correspond to the descriptive information under <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> above. If you request one level of information, you get any prior levels of information as well.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoQueryDef Class](../vs140/cdaoquerydef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoQueryDef::GetFieldCount](../vs140/cdaoquerydef--getfieldcount.md)