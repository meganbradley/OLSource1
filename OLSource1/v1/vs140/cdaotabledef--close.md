---
title: "CDaoTableDef::Close"
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
  - "CDaoTableDef::Close"
  - "CDaoTableDef.Close"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Close method"
  - "tabledefs, closing"
  - "CDaoTableDef class, closing"
ms.assetid: 4dc26669-a00a-4e3e-aa7b-ea4334cd8f74
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoTableDef::Close
Call this member function to close and release the tabledef object.  
  
## Syntax  
  
```  
  
virtual void Close( );  
  
```  
  
## Remarks  
 Usually after calling **Close**, you delete the tabledef object if it was allocated with **new**.  
  
 You can call [Open](../vs140/cdaotabledef--open.md) again after calling **Close**. This lets you reuse the tabledef object.  
  
 For related information, see the topic "Close Method" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoTableDef Class](../vs140/cdaotabledef-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoTableDef::Open](../vs140/cdaotabledef--open.md)   
 [CDaoTableDef::Create](../vs140/cdaotabledef--create.md)