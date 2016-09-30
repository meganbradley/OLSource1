---
title: "CDaoTableDef::GetAttributes"
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
  - "CDaoTableDef::GetAttributes"
  - "CDaoTableDef.GetAttributes"
  - "GetAttributes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAttributes method"
  - "CDaoTableDef class, getting attributes"
  - "tabledefs, getting attributes"
ms.assetid: 9b7b560e-252a-4f84-9ef4-1ed727c0c672
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoTableDef::GetAttributes
For a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object, the return value specifies characteristics of the table represented by the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object and can be a sum of these constants:  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns a value that indicates one or more characteristics of a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
## Remarks  
  
|Constant|Description|  
|--------------|-----------------|  
|**dbAttachExclusive**|For databases that use the Microsoft Jet database engine, indicates the table is an attached table opened for exclusive use.|  
|**dbAttachSavePWD**|For databases that use the Microsoft Jet database engine, indicates that the user ID and password for the attached table are saved with the connection information.|  
|**dbSystemObject**|Indicates the table is a system table provided by the Microsoft Jet database engine.|  
|**dbHiddenObject**|Indicates the table is a hidden table provided by the Microsoft Jet database engine.|  
|**dbAttachedTable**|Indicates the table is an attached table from a non-ODBC database, such as a Paradox database.|  
|**dbAttachedODBC**|Indicates the table is an attached table from an ODBC database, such as Microsoft SQL Server.|  
  
 A system table is a table created by the Microsoft Jet database engine to contain various internal information.  
  
 A hidden table is a table created for temporary use by the Microsoft Jet database engine.  
  
 For related information, see the topic "Attributes Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoTableDef Class](../vs140/cdaotabledef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoTableDef::SetAttributes](../vs140/cdaotabledef--setattributes.md)