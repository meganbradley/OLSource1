---
title: "CDaoTableDef::GetFieldInfo"
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
  - "CDaoTableDef::GetFieldInfo"
  - "GetFieldInfo"
  - "CDaoTableDef.GetFieldInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFieldInfo method"
  - "tabledefs, getting field info"
  - "CDaoTableDef class, getting field info"
ms.assetid: c26c2e0f-9a27-40be-a9d3-0c223ebc9c64
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoTableDef::GetFieldInfo
Call this member function to obtain various kinds of information about a field defined in the tabledef.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The index of the field object in the table's zero-based Fields collection, for lookup by index.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to a [CDaoFieldInfo](../vs140/cdaofieldinfo-structure.md) structure.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Options that specify which information about the field to retrieve. The available options are listed here along with what they cause the function to return:  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (Default) Name, Type, Size, Attributes. Use this option for fastest performance.  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> Primary information, plus: Ordinal Position, Required, Allow Zero Length, Collating Order, Foreign Name, Source Field, Source Table  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> Primary and secondary information, plus: Validation Rule, Validation Text, Default Value  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A pointer to the name of the field object, for lookup by name. The name is a string with up to 64 characters that uniquely names the field.  
  
## Remarks  
 One version of the function lets you look up a field by index. The other version lets you look up a field by name.  
  
 For a description of the information returned, see the [CDaoFieldInfo](../vs140/cdaofieldinfo-structure.md) structure. This structure has members that correspond to the items of information listed above in the description of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. When you request information at one level, you get information for any prior levels as well.  
  
 For related information, see the topic "Attributes Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoTableDef Class](../vs140/cdaotabledef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoTableDef::GetIndexInfo](../vs140/cdaotabledef--getindexinfo.md)   
 [CDaoTableDef::GetIndexCount](../vs140/cdaotabledef--getindexcount.md)   
 [CDaoTableDef::GetFieldCount](../vs140/cdaotabledef--getfieldcount.md)