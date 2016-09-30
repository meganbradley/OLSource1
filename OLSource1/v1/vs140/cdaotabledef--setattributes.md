---
title: "CDaoTableDef::SetAttributes"
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
  - "CDaoTableDef.SetAttributes"
  - "CDaoTableDef::SetAttributes"
  - "SetAttributes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tabledefs, setting attributes"
  - "SetAttributes method"
  - "CDaoTableDef class, setting attributes"
ms.assetid: 3f9390fa-9872-4181-a933-c57a73bee0aa
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoTableDef::SetAttributes
Sets a value that indicates one or more characteristics of a `CDaoTableDef` object.  
  
## Syntax  
  
```  
  
      void SetAttributes(   
   long lAttributes    
);  
```  
  
#### Parameters  
 `lAttributes`  
 Characteristics of the table represented by the `CDaoTableDef` object and can be a sum of these constants:  
  
|Constant|Description|  
|--------------|-----------------|  
|**dbAttachExclusive**|For databases that use the Microsoft Jet database engine, indicates the table is an attached table opened for exclusive use.|  
|**dbAttachSavePWD**|For databases that use the Microsoft Jet database engine, indicates that the user ID and password for the attached table are saved with the connection information.|  
|**dbSystemObject**|Indicates the table is a system table provided by the Microsoft Jet database engine.|  
|**dbHiddenObject**|Indicates the table is a hidden table provided by the Microsoft Jet database engine.|  
  
## Remarks  
 When setting multiple attributes, you can combine them by summing the appropriate constants using the bitwise-OR operator. Setting **dbAttachExclusive** on a nonattached table produces an exception. Combining the following values also produce an exception:  
  
-   **dbAttachExclusive &#124; dbAttachedODBC**  
  
-   **dbAttachSavePWD &#124; dbAttachedTable**  
  
 For related information, see the topic "Attributes Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoTableDef Class](../vs140/cdaotabledef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoTableDef::SetConnect](../vs140/cdaotabledef--setconnect.md)