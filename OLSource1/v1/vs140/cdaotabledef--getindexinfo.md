---
title: "CDaoTableDef::GetIndexInfo"
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
  - "CDaoTableDef::GetIndexInfo"
  - "GetIndexInfo"
  - "CDaoTableDef.GetIndexInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tabledefs, getting index info"
  - "GetIndexInfo method"
  - "CDaoTableDef class, getting index information"
ms.assetid: 1acbd84d-dd73-44cc-945d-dac38a820621
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoTableDef::GetIndexInfo
Call this member function to obtain various kinds of information about an index defined in the tabledef.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The numeric index of the Index object in the table's zero-based Indexes collection, for lookup by its position in the collection.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to a [CDaoIndexInfo](../vs140/cdaoindexinfo-structure.md) structure.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Options that specify which information about the index to retrieve. The available options are listed here along with what they cause the function to return:  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> Name, Field Info, Fields. Use this option for fastest performance.  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> Primary information, plus: Primary, Unique, Clustered, Ignore Nulls, Required, Foreign  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> Primary and secondary information, plus: Distinct Count  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A pointer to the name of the index object, for lookup by name.  
  
## Remarks  
 One version of the function lets you look up an index by its position in the collection. The other version lets you look up an index by name.  
  
 For a description of the information returned, see the [CDaoIndexInfo](../vs140/cdaoindexinfo-structure.md) structure. This structure has members that correspond to the items of information listed above in the description of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. When you request information at one level, you get information for any prior levels as well.  
  
 For related information, see the topic "Attributes Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoTableDef Class](../vs140/cdaotabledef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoTableDef::GetFieldInfo](../vs140/cdaotabledef--getfieldinfo.md)   
 [CDaoTableDef::GetIndexCount](../vs140/cdaotabledef--getindexcount.md)   
 [CDaoTableDef::GetFieldCount](../vs140/cdaotabledef--getfieldcount.md)