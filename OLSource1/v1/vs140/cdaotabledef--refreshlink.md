---
title: "CDaoTableDef::RefreshLink"
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
  - "CDaoTableDef.RefreshLink"
  - "CDaoTableDef::RefreshLink"
  - "RefreshLink"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDaoTableDef class, refreshing links"
  - "tabledefs, refreshing links"
  - "RefreshLink method"
ms.assetid: 487912f4-cf57-42bf-a1a1-93afd6463fd3
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoTableDef::RefreshLink
Call this member function to update the connection information for an attached table.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 You change the connection information for an attached table by calling [SetConnect](../vs140/cdaotabledef--setconnect.md) on the corresponding <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object and then using the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member function to update the information. When you call <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the attached table's properties are not changed.  
  
 To force the modified connect information to take effect, all open [CDaoRecordset](../vs140/cdaorecordset-class.md) objects based on this tabledef must be closed.  
  
 For related information, see the topic "RefreshLink Method" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoTableDef Class](../vs140/cdaotabledef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoTableDef::SetConnect](../vs140/cdaotabledef--setconnect.md)