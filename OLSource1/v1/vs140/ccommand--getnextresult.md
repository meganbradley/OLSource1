---
title: "CCommand::GetNextResult"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ATL::CCommand::GetNextResult"
  - "CCommand::GetNextResult"
  - "GetNextResult"
  - "CCommand.GetNextResult"
  - "ATL.CCommand.GetNextResult"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNextResult method"
ms.assetid: 63df9b55-9490-45c4-934a-879c5c2725d8
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCommand::GetNextResult
Fetches the next result set if one is available.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pulRowsAffected*  
 [in/out] A pointer to memory where the count of rows affected by a command is returned.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] Specifies whether to bind the command automatically after being executed. The default is **true**, which causes the command to be bound automatically. Setting <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to **false** prevents the automatic binding of the command so that you can bind manually. (Manual binding is of particular interest to OLAP users.)  
  
## Return Value  
 A standard <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 If a result set has been previously fetched, this function releases the previous result set and unbinds the columns. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is **true**, it binds the new columns.  
  
 You should call this function only if you have specified multiple results by setting the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> template parameter *TMultiple*=<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CCommand Class](../vs140/ccommand-class.md)